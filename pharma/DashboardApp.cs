using pharma.EFModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DashboardApp.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard
    {
        private GestionMagasinPharmacieEntities5 gmp;
        private DateTime startDate;
        private DateTime endDate;

        // Define properties
        public int NumOrders { get; private set; }
        public decimal TotalRevenue { get; private set; }
        public decimal TotalProfit { get; private set; }
        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }

        // Constructor
        public Dashboard(GestionMagasinPharmacieEntities5 gmp)
        {
            this.gmp = gmp;
        }

        // LoadData method
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;

            // Assigner les valeurs aux propriétés et charger les données
            NumCustomers = GetNumberCustomers();
            TotalRevenue = CalculateTotalRevenue(startDate, endDate);
            TotalProfit = CalculateTotalProfit(startDate, endDate);
            NumOrders = CalculateNumberOrders();
            NumSuppliers = GetNumberSuppliers();
            NumProducts = GetNumberProducts();
            GrossRevenueList = GetGrossRevenue(startDate, endDate);
            TopProductsList = GetTopProducts(startDate, endDate);
            UnderstockList = GetUnderstock(startDate, endDate);

            return true; // Return true if data loading is successful
        }


        private int GetNumberCustomers()
        {
            return gmp.Client.Count();
        }

        private int GetNumberSuppliers()
        {
            return gmp.Entreprise.Count();
        }

        private int GetNumberProducts()
        {
            return gmp.Stock.Count();
        }

        private int CalculateNumberOrders()
        {
            return gmp.Vente.Count();
        }

        private List<KeyValuePair<string, int>> GetTopProducts(DateTime startDate, DateTime endDate)
        {
            // Query the database to get the grouped data
            var groupedData = gmp.Vente
                .Where(v => v.DateTransaction >= startDate && v.DateTransaction <= endDate)
                .GroupBy(v => v.NomArticle)
                .OrderByDescending(g => g.Sum(v => v.QuantiteVendue))
                .Take(5)
                .Select(g => new
                {
                    ArticleName = g.Key,
                    TotalQuantity = g.Sum(v => v.QuantiteVendue)
                })
                .ToList();

            // Project the grouped data into KeyValuePair<string, int> objects
            var topProducts = groupedData
                .Select(g => new KeyValuePair<string, int>(g.ArticleName, (int)g.TotalQuantity))
                .ToList();

            return topProducts;
        }


        private List<KeyValuePair<string, int>> GetUnderstock(DateTime startDate, DateTime endDate)
        {
            // Query the database to get the filtered data
            var filteredData = gmp.Stock
                .Where(s => s.QuantiteDisponible <= 6 && s.QuantiteDisponible > 0)
                .ToList();

            // Project the filtered data into KeyValuePair<string, int> objects
            var understockItems = filteredData
                .Select(s => new KeyValuePair<string, int>(s.NomArticle, (int)s.QuantiteDisponible))
                .ToList();

            return understockItems;
        }


        private List<RevenueByDate> GetGrossRevenue(DateTime startDate, DateTime endDate)
        {
            // Query the database to get the grouped data
            var groupedData = gmp.Vente
                .Where(v => v.DateTransaction >= startDate && v.DateTransaction <= endDate)
                .GroupBy(v => DbFunctions.TruncateTime(v.DateTransaction))
                .Select(g => new
                {
                    Date = g.Key,
                    TotalAmount = g.Sum(v => v.PrixTotal)
                })
                .ToList();

            // Project the grouped data into RevenueByDate objects
            var revenueByDates = groupedData
                .Select(g => new RevenueByDate
                {
                    Date = g.Date.Value.ToString("yyyy-MM-dd"),
                    TotalAmount = (decimal)g.TotalAmount
                })
                .ToList();

            return revenueByDates;
        }


        // Calculate total revenue based on sales data
        private decimal CalculateTotalRevenue(DateTime startDate, DateTime endDate)
        {
            // Ensure that gmp.Vente is not null
            if (gmp.Vente == null)
            {
                return 0; // or throw an exception if appropriate
            }

            // Calculate total revenue using SQL SUM function within the database query
            var totalRevenue = gmp.Vente
                .Where(v => v.DateTransaction >= startDate && v.DateTransaction <= endDate)
                .Select(v => (decimal?)v.PrixTotal) // Convert to nullable decimal to handle potential nulls
                .Sum() ?? 0; // Use null-coalescing operator to handle potential null result

            return totalRevenue;
        }



        // Calculate total profit based on sales and cost data
        private decimal CalculateTotalProfit(DateTime startDate, DateTime endDate)
        {
            // Ensure that gmp.Vente is not null
            if (gmp.Vente == null)
            {
                return 0; // or throw an exception if appropriate
            }

            // Calculate total profit using SQL SUM function within the database query
            var totalProfit = gmp.Vente
                .Where(v => v.DateTransaction >= startDate && v.DateTransaction <= endDate)
                .Select(v => (decimal?)(v.PrixTotal - v.PrixUnitaire * v.QuantiteVendue)) // Convert to nullable decimal to handle potential nulls
                .Sum() ?? 0; // Use null-coalescing operator to handle potential null result

            return totalProfit;
        }


    }

}
