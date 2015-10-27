--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

--02. Write a SQL query to find the names and salaries of the employees that have a 
--salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary <=
	(SELECT MIN(Salary) FROM Employees) * 1.1
ORDER BY Salary

--03. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName AS FullName, Salary, d.Name 
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary)
	 FROM Employees emp
	 WHERE emp.DepartmentID = d.DepartmentID)
ORDER BY Salary DESC

--04. Write a SQL query to find the average salary in the department #1.
SELECT ROUND(AVG(Salary), 2) AS AverageSalary
FROM Employees
WHERE DepartmentID = 1

--05. Write a SQL query to find the average salary in the "Sales" department.
SELECT ROUND(AVG(Salary), 2) AS AverageSalary
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--06. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) AS EmployeesInDepartmentSales
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--07. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(ManagerID) AS EmployeesWithManager
FROM Employees

--08. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS EmployeesWithoutManager
FROM Employees
WHERE ManagerID IS NULL

--09. Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name, ROUND(AVG(Salary), 2) AS AverageSalary
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY AverageSalary DESC

--10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(*) AS NumberOfEmployees, d.Name AS Department, t.Name AS Town
FROM Employees e
	JOIN Departments d
	 ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	 ON e.AddressID = a.AddressID
	JOIN Towns t
	 ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY NumberOfEmployees DESC

--11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.FirstName, m.LastName
FROM Employees e
	JOIN Employees m
	 ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(m.EmployeeID) = 5

--12. Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee], 
		COALESCE(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager]
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
SELECT CONVERT(DATETIME, GETDATE(), 112) AS CurrentTime

--15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
	--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	--Define the primary key column as identity to facilitate inserting records.
	--Define unique constraint to avoid repeating usernames.
	--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
	UserId int IDENTITY PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL CHECK (LEN(Username) > 3) UNIQUE,
    Pass NVARCHAR(100) NOT NULL CHECK (LEN(Pass) > 5),
    FullName NVARCHAR(100) NOT NULL CHECK (LEN(FullName) > 5),
    LastLoginTime DATETIME,
)
GO

--16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
--Test if the view works correctly.

CREATE VIEW [Today login users] AS
SELECT Username, LastLoginTime
FROM Users
WHERE
CONVERT(VARCHAR(10), LastLoginTime, 102) <= CONVERT(VARCHAR(10) ,GETDATE(), 102)
GO

--17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.
CREATE TABLE Groups (
	GroupId int IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) UNIQUE NOT NULL 
)
GO

--18. Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users
ADD GroupId int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupId)
REFERENCES Groups(GroupId)

--19. Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users (Username, Pass, FullName, LastLoginTime)
VALUES('Pesho', 123456, 'Pesho Peshev',GETDATE()),
	  ('Gosho', 654321, 'Gosho Goshec', GETDATE())

INSERT INTO Groups (Name)
VALUES ('C#'),
	   ('Databases')

--20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET FullName = 'Pesho Stamatov'
WHERE UserId = 1

UPDATE Groups
SET Name = 'DSA'
WHERE GroupId = 1

--21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Username = 'Pesho'

DELETE FROM Groups
WHERE GroupId = 1

--22. -Task 22: Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.
INSERT INTO Users (Username, Pass, FullName, LastLoginTime)
SELECT LOWER(LEFT(FirstName, 3) + LastName),
		LOWER(LEFT(FirstName, 3) + LastName),
		FirstName + ' ' + LastName,
		NULL
FROM Employees

--23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET Pass = 'NULL'
WHERE LastLoginTime < CONVERT(DATETIME, '2010-03-10')

--24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE
FROM Users
WHERE Pass IS NULL

--25. Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name AS DepartmentName, e.JobTitle, ROUND(AVG(e.Salary), 2) AS AverageSalary
FROM Employees e
	JOIN Departments d
	 ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY AverageSalary DESC

--26. Write a SQL query to display the minimal employee salary by department and 
--job title along with the name of some of the employees that take it.
SELECT ROUND(MIN(e.Salary), 2) AS [MinSalary], 
        d.Name AS [Department],
        e.JobTitle, 
        MIN(CONCAT(e.FirstName, ' ', e.LastName)) AS [Employee]
    FROM Employees e 
    JOIN Departments d
        ON e.DepartmentID = d.DepartmentID
    GROUP BY d.Name, e.JobTitle
    ORDER BY d.Name

--27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name AS Town, COUNT(*) AS NumberOfEmployees
FROM Employees e
	JOIN Addresses a
	 ON e.AddressID = a.AddressID
	JOIN Towns t
	 ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY NumberOfEmployees DESC

--28. Write a SQL query to display the number of managers from each town.
SELECT t.Name AS [Town], COUNT(DISTINCT e.ManagerID) AS NumberOfManagers
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.ManagerID
	JOIN Addresses a
		ON m.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY NumberOfManagers DESC

--Task 29: Write a SQL to create table WorkHours to store work reports for each employee 
--(employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).
CREATE TABLE WorkHours (
	EmployeeId INT IDENTITY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	Comments NVARCHAR(300)
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeId)
)
GO

INSERT INTO WorkHours
VALUES (GETDATE(), 'Write homework', 5, 'Homework about advanced SQL'),
		(GETDATE(), 'Go go Lecture', 4, 'Attend to lecture in Telerik Academy'),
		(GETDATE(), 'Rest', 2, 'Rest after hard day')

UPDATE WorkHours
SET Date = '2015-10-05 18:00'
WHERE Task LIKE '%Lecture%'

DELETE FROM WorkHours
WHERE [Hours] < 3

CREATE TABLE WorkHoursLogs(
	LogId INT IDENTITY,
	OldRecord nvarchar(500),
	NewRecord nvarchar(500),
	Command nvarchar(10),
	EmployeeId INT,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(LogId),
	CONSTRAINT FK_WorkHoursLogs_WorkHours FOREIGN KEY(EmployeeId) 
	REFERENCES WorkHours(EmployeeId)
)
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES('',
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments
			FROM Inserted),
		   'INSERT',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' +
					 ' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Inserted),
		   'UPDATE',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   '',
		   'DELETE',
		   (SELECT EmployeeID FROM Deleted))
GO

INSERT INTO WorkHours
VALUES(GETDATE(), 'Sleep', 8, 'Sleep when its dark outside')

DELETE FROM WorkHours
WHERE Task = 'Rest'

UPDATE WorkHours
SET Task = 'Win Money'
WHERE EmployeeID = 1

--Task 30: Start a database transaction, delete all employees from the 'Sales' department along with 
--all dependent records from the pother tables. At the end rollback the transaction.

BEGIN TRAN
	ALTER TABLE Departments
	DROP CONSTRAINT FK_Departments_Employees

	ALTER TABLE WorkHours
	DROP CONSTRAINT FK_WorkHours_Employees

	DELETE FROM Employees
	SELECT d.Name
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN

--Task 31: Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?

--BEGIN TRAN
--	DROP TABLE EmployeesProjects
--ROLLBACK TRAN

--Task 32: Find how to use temporary tables in SQL Server.Using temporary tables backup all records
-- from EmployeesProjects and restore them back after dropping and re-creating the table.
BEGIN TRANSACTION
    SELECT * 
        INTO #TempEmployeesProjects  --- Create new table
        FROM EmployeesProjects
    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects --- Create new table
        FROM #TempEmployeesProjects
    DROP TABLE #TempEmployeesProjects
ROLLBACK TRANSACTION