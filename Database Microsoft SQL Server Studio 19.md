-- Création de la base de données
CREATE DATABASE GestionMagasinPharmacie;
GO
 
-- Utilisation de la base de données
USE GestionMagasinPharmacie;
GO
 
-- Table Client
CREATE TABLE Client (
    ClientID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(50),
    Prenom NVARCHAR(50),
    Telephone NVARCHAR(20),
    Adresse NVARCHAR(100),
    Ville NVARCHAR(50)
);
 
-- Table Entreprise
CREATE TABLE Entreprise (
    EntrepriseID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(100),
    PersonneContact NVARCHAR(100),
    Adresse NVARCHAR(100),
    CoordonneesContact NVARCHAR(50),
    DateEntree DATE DEFAULT GETDATE()
);
 
-- Table Vente
CREATE TABLE Vente (
    VenteID INT PRIMARY KEY IDENTITY,
    ClientID INT FOREIGN KEY REFERENCES Client(ClientID),
    NomArticle NVARCHAR(100),
    PrixUnitaire DECIMAL(10, 2),
    QuantiteVendue INT,
    PrixTotal DECIMAL(10, 2),
    DateTransaction DATE DEFAULT GETDATE(),
CONSTRAINT FK_Vente_Stock
FOREIGN KEY (StockID)
REFERENCES Stock(StockID);

);
ALTER TABLE Vente
ADD StockID INT,
CONSTRAINT FK_Vente_Stock
FOREIGN KEY (StockID)
REFERENCES Stock(StockID);

-- Table StockIn
CREATE TABLE StockIn (
    StockInID INT PRIMARY KEY IDENTITY,
    NomArticle NVARCHAR(100),
    Description NVARCHAR(255),
    QuantiteEntree INT,
    PrixUnitaire DECIMAL(10, 2),
    EntrepriseID INT FOREIGN KEY REFERENCES Entreprise(EntrepriseID),
    DateExpiration DATE,
    LieuEntree NVARCHAR(100),
    DateEntree DATE DEFAULT GETDATE()
);
ALTER TABLE StockIn
ADD StockID INT;
ALTER TABLE StockIn
ADD FOREIGN KEY (StockID) REFERENCES Stock(StockID);

-- Table Stock
CREATE TABLE Stock (
    StockID INT PRIMARY KEY IDENTITY,
    NomArticle NVARCHAR(100),
    Description NVARCHAR(255),
    QuantiteTotale INT,
    QuantiteVendue INT,
    QuantiteDisponible INT,
    PrixTotal DECIMAL(10, 2),
    PrixUnitaire DECIMAL(10, 2),
    DateEntree DATE DEFAULT GETDATE()
);
 
-- Table Utilisateurs
CREATE TABLE Utilisateurs (
    UtilisateurID INT PRIMARY KEY IDENTITY,
    NomUtilisateur NVARCHAR(50),
    MotDePasse NVARCHAR(50),
    TypeUtilisateur NVARCHAR(50),
    DateInscription DATE DEFAULT GETDATE()
);
