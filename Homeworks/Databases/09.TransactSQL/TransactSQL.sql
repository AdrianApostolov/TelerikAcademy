--01.Create a database with two tables
--PERSONS is wrong :)

CREATE DATABASE BankSystem

CREATE TABLE [BankSystem].[dbo].[People] (
PersonID INT IDENTITY,
FirstName NVARCHAR(50),
LastName NVARCHAR(50),
SSN NVARCHAR(50),
CONSTRAINT PK_PersonID PRIMARY KEY (PersonID)
)

CREATE TABLE [BankSystem].[dbo].[Accounts] (
AccountID INT IDENTITY,
PersonID INT NOT NULL,
Balance MONEY NOT NULL,
CONSTRAINT PK_AccountID PRIMARY KEY (AccountID),
CONSTRAINT FK_Accounts_People_PersonID FOREIGN KEY (PersonID) REFERENCES [BankSystem].[dbo].[People](PersonID)
)

INSERT INTO [BankSystem].[dbo].[People] 
	(FirstName,LastName,SSN)
VALUES 
	('Pesho','Peshev','12312278'	),
	('Stamat','Stamatov','87213421'),
	('Gosho','Goshov','54681512'),
	('Penka','Penkova','12453133')

INSERT INTO [BankSystem].[dbo].[Accounts] 
	(PersonID,Balance)
VALUES 
	(1,15020150.14),
	(2,2124210.52),
	(3,15202.00),
	(4,21129.75)

--02.Create a stored procedure
	--Procedure creation
GO
CREATE PROC usp_UsersWithMoreMoney @minMoney MONEY = 0
AS
SELECT p.FirstName,p.LastName,a.Balance FROM [BankSystem].[dbo].[People] p
JOIN [BankSystem].[dbo].[Accounts] a ON p.PersonID=a.PersonID
WHERE a.Balance>@minMoney
GO
	--Test the procedure
EXEC usp_UsersWithMoreMoney @minMoney = 30000

--03.Create a function with parameters
--interest is in percent 5, 5.5, 99.5 etc.
GO
CREATE FUNCTION ufn_CalculateSumWithInterest (@sum MONEY, @yearInterest DECIMAL, @months INT) RETURNS MONEY
AS
BEGIN
RETURN (@sum + @sum*(@yearInterest/100)*@months/12)
END
GO


DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE AccountID = 1)
PRINT dbo.ufn_CalculateSumWithInterest(@sum,5,5)



--04.Create a stored procedure that uses the function from the previous example.
--interest is in percent 5, 5.5, 99.5 etc.
GO
CREATE PROC usp_AddInterestForOneMonth (@accountID INT,@interest DECIMAL)
AS
DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE AccountID = @accountID)
UPDATE Accounts
SET Balance = (@sum+@sum*(@interest/100)/12)
WHERE AccountID = @accountID
GO

EXEC usp_AddInterestForOneMonth 4, 5

--05.Add two more stored procedures WithdrawMoney and DepositMoney.
GO
CREATE PROC usp_WithdrawMoney (@accountID INT,@money MONEY)
AS
DECLARE @currentBalanace MONEY = (SELECT Balance FROM Accounts WHERE AccountID = @accountID)
IF(@money<=@currentBalanace)
BEGIN
UPDATE Accounts
SET Balance = Balance-@money
WHERE AccountID = @accountID
END
ELSE
BEGIN
PRINT 'Not enough money in account'
END 
GO

GO
CREATE PROC usp_DepositMoney (@accountID INT,@money MONEY)
AS
UPDATE Accounts
SET Balance = Balance+@money
WHERE AccountID = @accountID
GO

EXEC usp_WithdrawMoney 4, 5000
EXEC usp_DepositMoney 4,5000

--06.Create table Logs.
CREATE TABLE Logs(
LogID INT IDENTITY,
AccountID INT,
OldSum MONEY,
NewSum MONEY,
CONSTRAINT PK_LogID PRIMARY KEY (LogID))
GO

CREATE TRIGGER Tr_AccountUpdate
ON Accounts
FOR UPDATE
AS
SET NOCOUNT ON
INSERT INTO Logs
SELECT
i.AccountID,
d.Balance,
i.Balance
FROM INSERTED i, DELETED d
GO

--07.Define function in the TelerikAcademy database.

USE TelerikAcademy
GO
CREATE FUNCTION ufn_CheckName (@nameToCheck NVARCHAR(50),@letters NVARCHAR(50)) RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i,1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO


--WITH WHERE AS TABLE
SELECT e.FirstName, e.LastName,t.Name FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID=t.TownID
WHERE 
dbo.ufn_CheckName(e.FirstName,'oistmiahf') = 1 OR 
dbo.ufn_CheckName(e.LastName,'oistmiahf') = 1 OR
dbo.ufn_CheckName(t.Name,'oistmiahf') = 1

--WITH CURSOR AS PRINT
DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
  JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)

OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)
DECLARE @searchString NVARCHAR(50) ='oistmiahf'
FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
    IF(dbo.ufn_CheckName(@firstName,@searchString)=1)
		BEGIN
			PRINT 'First name: ' + @firstName
		END
	IF(dbo.ufn_CheckName(@lastName,@searchString)=1)
		BEGIN
			PRINT 'Last name: ' + @lastName
		END
	IF(dbo.ufn_CheckName(@town,@searchString)=1)
		BEGIN
			PRINT 'Town: ' + @town
		END
	FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town
  END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor

--08.Using database cursor write a T-SQL
DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)


OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE employeeTownCursor1 CURSOR READ_ONLY FOR
		(SELECT e.FirstName, e.LastName, t.Name FROM Employees e
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID=t.TownID)
	OPEN employeeTownCursor1
		DECLARE @firstName1 NVARCHAR(50), @lastName1 NVARCHAR(50), @town1 NVARCHAR(50)
		FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			WHILE @@FETCH_STATUS = 0
			BEGIN
		
				IF(@town = @town1)
				BEGIN
					PRINT @lastname1 + ': ' + @firstname + ' ' +  @lastname + ' ' + @town + ' ' + @firstname1 
				END

			FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			END

	CLOSE employeeTownCursor1
	DEALLOCATE employeeTownCursor1

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town
END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor

--10.Define a .NET aggregate function
		--STEP 00. LOOK AT THE CREATED C# PROJECT. IT IS A CLASS LIBRARY C# PROJECT.
		
		--STEP 01. Enable clr in sql server
		EXEC sp_configure 'clr enabled', 1
		GO
		RECONFIGURE
		GO
		
		--STEP 02. Create the assembly
		USE TelerikAcademy
		CREATE ASSEMBLY ConcatenateStringsWithComma
		AUTHORIZATION dbo
		--- Please be sure that the dll file is here
		FROM 'D:\Marto\Google Drive\Telerik Experience\11.Databases\09.TSql\Aggregate\Aggregate\Aggregate\bin\Release\Aggregate.dll'  
		WITH PERMISSION_SET = SAFE
		GO
		
		--STEP 03. Create the aggregate function
		CREATE AGGREGATE dbo.StrConcat (@value nvarchar(MAX)) RETURNS nvarchar(MAX)
		EXTERNAL NAME ConcatenateStringsWithComma.[Aggregate.StringConcat] --See below for the names
		--EXTERNAL NAME SQLAssemblyName.[C#NameSpace".C#ClassName].C#MethodName
		
		--STEP 04.OPTIONAL!!! If you want to drop the aggregate and the assembly
		--DROP AGGREGATE dbo.StrConcat
		--DROP ASSEMBLY ConcatenateStringsWithComma
		
		--STEP 05.TEST the function
		USE TelerikAcademy
		SELECT dbo.StrConcat(FirstName + ' ' + LastName)
		FROM Employees

--09.Write a T-SQL script
use TelerikAcademy
DECLARE townEmployeesCursor CURSOR READ_ONLY FOR
(SELECT t.Name, dbo.StrConcat(FirstName + ' ' + LastName) AS [List of employees] FROM Employees e
JOIN Addresses a ON a.AddressID = e.AddressID
JOIN Towns t ON t.TownID = a.TownID
GROUP BY t.Name)

OPEN townEmployeesCursor
DECLARE @town NVARCHAR(50), @list NVARCHAR(MAX)

FETCH NEXT FROM townEmployeesCursor INTO @town, @list

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @town + ' -> '+@list
	FETCH NEXT FROM townEmployeesCursor INTO @town, @list
  END

CLOSE townEmployeesCursor
DEALLOCATE townEmployeesCursor









