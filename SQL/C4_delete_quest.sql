CREATE DATABASE SuperMoney;
GO
USE SuperMoney;
CREATE TABLE logs ("id" INT PRIMARY KEY IDENTITY(1,1), "user" VARCHAR(50), "message" VARCHAR(50));
INSERT INTO logs ("user","message") VALUES ('hack3r', 'Connects');
INSERT INTO logs ("user","message") VALUES ('hack3r', 'Connects');
INSERT INTO logs ("user","message") VALUES ('hack3r' , 'Erases file'); 
INSERT INTO logs ("user","message") VALUES ('hack3r', 'Connects');
INSERT INTO logs ("user","message") VALUES ('hack3r', 'Create new file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Leaves');
INSERT INTO logs ("user","message") VALUES ('hack3r','Connects');
INSERT INTO logs ("user","message") VALUES ('hack3r','Erases file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Create new file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Create new file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Leaves');
INSERT INTO logs ("user","message") VALUES ('hack3r','Create new file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Create new file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Erases file');
INSERT INTO logs ("user","message") VALUES ('hack3r','Create new file');
INSERT INTO logs ("user","message") VALUES ('admin','Leaves');
INSERT INTO logs ("user","message") VALUES ('admin','Create new file');
INSERT INTO logs ("user","message") VALUES ('admin','Create new file');
INSERT INTO logs ("user","message") VALUES ('admin','Create new file');
INSERT INTO logs ("user","message") VALUES ('admin','Connects');
INSERT INTO logs ("user","message") VALUES ('admin','Connects');
INSERT INTO logs ("user","message") VALUES ('admin','Leaves');
INSERT INTO logs ("user","message") VALUES ('admin','Leaves');
INSERT INTO logs ("user","message") VALUES ('admin','Erases file');
INSERT INTO logs ("user","message") VALUES ('admin','Connects');
INSERT INTO logs ("user","message") VALUES ('admin','Connects');
INSERT INTO logs ("user","message") VALUES ('admin','Erases file');
INSERT INTO logs ("user","message") VALUES ('admin','Connects');
INSERT INTO logs ("user","message") VALUES ('admin','Leaves');
INSERT INTO logs ("user","message") VALUES ('admin','Create new file');

USE SuperMoney;
GO
BACKUP DATABASE SuperMoney
TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SuperMoney.bak'
   WITH FORMAT,
      MEDIANAME = 'SuperMoney',
      NAME = 'Before Delete SuperMoney';
GO
BEGIN TRANSACTION
USE SuperMoney;
DELETE TOP(3)
FROM logs;
COMMIT ;

GO
USE SuperMoney;
GO
BACKUP DATABASE SuperMoney
TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SuperMoney2.bak'
   WITH FORMAT,
      MEDIANAME = 'SuperMoney2',
      NAME = 'Before last Delete SuperMoney';
GO

BEGIN TRANSACTION
USE SuperMoney;
DELETE FROM logs
WHERE "user" = 'hack3r';
COMMIT ;