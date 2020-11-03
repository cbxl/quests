CREATE DATABASE Shop;
GO

Use Shop;
CREATE TABLE Category(
	CategoryId INT PRIMARY KEY IDENTITY (1,1),
	CategoryName VARCHAR (100) NOT NULL,
);

CREATE TABLE Product(
	ProductId INT PRIMARY KEY IDENTITY (1,1),
	ProductName VARCHAR (100) NOT NULL,
	ProductPrice DECIMAL NOT NULL,
	FK_CategoryId INT FOREIGN KEY REFERENCES Category (CategoryId),
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
INSERT INTO Product (ProductName, ProductPrice, FK_CategoryId)
VALUES ('Sneakers', 25.5, 1), ('Tongs', 9.90, 1), ('Heels', 24.9,1), 
('Croc Top', 9.99, 2), ('Tank top', 12.5,2), ('V-nek', 19.2,2),
('Bermuda', 19.9,3), ('Mini', 12,3),('Jumpsuit', 22,3);
INSERT INTO Purchase (PurchaseDate, PurchaseProductId) VALUES (GetDate(),1),(GetDate(),2),(GetDate(),3),(GetDate(),4),(GetDate(),5),
(GetDate(),6),(GetDate(),7),(GetDate(),8),(GetDate(),9),(GetDate(),1),(GetDate(),2),(GetDate(),3),(GetDate(),4),(GetDate(),5),
(GetDate(),6),(GetDate(),7),(GetDate(),8),(GetDate(),9);
INSERT INTO Inventory (InventoryQuantity, InventoryProductId) VALUES (10,1), (5,2), (15,3), (10,4), (10,5), (10,6), (5, 7), (6,8), (7,9);


SELECT SUM(InventoryQuantity), CategoryName FROM Inventory
INNER JOIN Product ON  InventoryProductId = ProductId
INNER JOIN Category ON CategoryId = FK_CategoryId
GROUP BY CategoryName;
