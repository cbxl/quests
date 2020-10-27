CREATE DATABASE CustomerToProspect;
GO

USE CustomerToProspect;
CREATE TABLE Customer(
	id INT PRIMARY KEY IDENTITY (1,1),
	name_customer VARCHAR(50) NOT NULL ,


INSERT INTO Customer (name_customer
VALUES ('Suarez'),('Fernandez'),('Ernandez'),('Marques');


GO
DECLARE @SuppressionZ VARCHAR(20) = 'Transaction1';
BEGIN TRAN @SuppressionZ
UPDATE Customer
set name_Customer = TRIM ('z' FROM name_customer)
COMMIT;
