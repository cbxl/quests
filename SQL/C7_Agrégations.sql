CREATE DATABASE Shop2;
GO

Use Shop2;
CREATE TABLE Category(
	CategoryId INT PRIMARY KEY IDENTITY (1,1),
	CategoryName VARCHAR (100) NOT NULL,
);

CREATE TABLE Product(
	ProductId INT PRIMARY KEY IDENTITY (1,1),
	ProductName VARCHAR (100) NOT NULL,
	ProductPrice MONEY NOT NULL,
	ProductCategoryId INT NOT NULL,
	CONSTRAINT FK_CategoryId FOREIGN KEY (ProductCategoryId)
	REFERENCES Category (CategoryId)
	ON DELETE CASCADE
);

CREATE TABLE Purchase(
	PurchaseId INT PRIMARY KEY IDENTITY (1,1),
	PurchaseDate DATE NOT NULL,
	PurchaseProductId INT NOT NULL,
	CONSTRAINT FK_ProductId FOREIGN KEY (PurchaseProductId)
	REFERENCES  Product (ProductId)
	ON DELETE CASCADE 
);

CREATE TABLE Inventory(
	InventoryId INT PRIMARY KEY IDENTITY (1,1),
	InventoryQuantity INT NOT NULL,
	InventoryProductId INT NOT NULL,
	CONSTRAINT FK_InventoryProductId FOREIGN KEY (InventoryProductId)
	REFERENCES  Product (ProductId)
	ON DELETE CASCADE 
);

INSERT INTO Category (CategoryName) VALUES ('Shoes'),('Top'),('Short');
INSERT INTO Product (ProductName, ProductPrice, ProductCategoryId)
VALUES ('Sneakers', 25.5, 1), ('Tongs', 9.90, 1), ('Heels', 24.9,1), 
('Croc Top', 9.99, 2), ('Tank top', 12.5,2), ('V-nek', 19.2,2),
('Bermuda', 19.9,3), ('Mini', 12,3),('Jumpsuit', 22,3);
INSERT INTO Purchase (PurchaseDate, PurchaseProductId) VALUES ('2020-11-03',1),('2020-11-02',2),('2020-10-03',3),('2019-11-03',4),('2018-11-03',5),
('2020-01-03',6),('2019-09-03',7),('2019-12-03',8),('2020-02-03',9),('2020-11-01',1),('2019-02-03',2),('2018-11-03',3),('2020-11-03',4),('2020-11-03',5),
('2020-11-03',6),('2019-11-03',7),('2019-11-03',8),('2019-11-03',9);
INSERT INTO Inventory (InventoryQuantity, InventoryProductId) VALUES (10,1), (5,2), (15,3), (10,4), (10,5), (10,6), (5, 7), (6,8), (7,9);


SELECT CategoryName AS "Nom de catégorie", SUM (PurchaseId) AS "Nombre de ventes", SUM(ProductPrice) AS "Chiffre d'affaires" FROM Purchase
INNER JOIN Product ON PurchaseProductId = ProductId
INNER JOIN Category ON	ProductCategoryId = CategoryId 
GROUP BY CategoryName

SELECT CategoryName AS "Nom de catégorie", SUM (PurchaseId) AS "Nombre de ventes en 2019 et 2020" FROM Purchase
INNER JOIN Product ON PurchaseProductId = ProductId
INNER JOIN Category ON	ProductCategoryId = CategoryId 
WHERE PurchaseDate > '2018-12-31'
GROUP BY CategoryName;