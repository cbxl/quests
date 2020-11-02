CREATE DATABASE GalaxyRools;
GO

USE GalaxyRools;

CREATE TABLE Continent (
	ContinentId INT PRIMARY KEY IDENTITY (1,1),
	ContinentName VARCHAR (80)
);

CREATE TABLE Earthling (
	EarthlingId INT PRIMARY KEY IDENTITY (1,1),
	EarthlingName VARCHAR (80),
	FK_ContinentId INT FOREIGN KEY REFERENCES Continent (ContinentId) NOT NULL,
);

CREATE TABLE MartianEmperor (
	MartianEmperorId INT PRIMARY KEY IDENTITY (1,1),
	MartianEmperorName VARCHAR (80)
);

CREATE TABLE MartianChief (
	MartianChiefId INT PRIMARY KEY IDENTITY (1,1),
	MartianChiefName VARCHAR (80),
	FK_MartianEmperorId INT FOREIGN KEY REFERENCES MartianEmperor (MartianEmperorId) NOT NULL
	);

CREATE TABLE MartianBase (
	MartianBaseId INT PRIMARY KEY IDENTITY (1,1),
	MartianBaseName VARCHAR (80)
);

CREATE TABLE Martian (
	MartianId INT PRIMARY KEY IDENTITY (1,1),
	MartianName VARCHAR (80),
	FK_MartianBaseId INT FOREIGN KEY REFERENCES MartianBase (MartianBaseId) NOT NULL,
	FK_MartianChiefId INT FOREIGN KEY REFERENCES MartianChief (MartianChiefId) NOT NULL,
	FK_EarthlingId INT FOREIGN KEY REFERENCES  Earthling (EarthlingId) NOT NULL,
);



USE GalaxyRools;
INSERT INTO Continent(ContinentName) VALUES ('Asia'), ('Africa'), ('Europe');
INSERT INTO Earthling(EarthlingName, FK_ContinentId) VALUES ('Terrien', 1), ('Terrien 2', 1), ('Terrien 3', 2), ('Terrien 4', 3), ('Terrien 5', 3), ('Terrien 6', 3) ;
INSERT INTO MartianEmperor (MartianEmperorName) VALUES ('Dark Vador');
INSERT INTO MartianChief(MartianChiefName, FK_MartianEmperorId) VALUES ('Chef Martien 1', 1), ('Chef Martien 2', 1) ;
INSERT INTO MartianBase(MartianBaseName) VALUES ('Base Spatiale'), ('Base HyperSpatiale');
INSERT INTO Martian(MartianName, FK_MartianBaseId, FK_MartianChiefId, FK_EarthlingId) VALUES ('Marti', 1, 2,1), ('Marto', 1, 1,2), ('Marta', 2, 1,3), ('Martu', 2, 2,4), ('Marte', 1, 2,5), ('Marty', 2, 2,6) ;

USE GalaxyRools;
SELECT 	MartianName AS "Nom du Martien",  MartianBaseName AS "Nom de la base martienne", EarthlingName AS "Nom du Terrien", ContinentName AS "Nom du Continent"
FROM Martian
INNER JOIN MartianBase ON MartianBaseId = FK_MartianBaseId
INNER JOIN Earthling ON EarthlingId = FK_EarthlingId
FULL OUTER JOIN Continent ON ContinentId = FK_continentId;





