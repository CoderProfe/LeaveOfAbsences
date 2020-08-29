create database Company;
go
use Company;
go
create table Employees (
	Id				integer identity(1,1) primary key,
	LastName		varchar(50) not null,
	FirstName		varchar(50) not null,
);
go
create table AbsenceTypes(
	Id				integer identity(1,1) primary Key,
	Description		varchar(100) not null
);
go
create table LeaveOfAbsences(
	Id				integer identity(1,1) primary key,
	EmployeeId		integer,
	AbsenceTypeId	integer,
	AbsenceDate		date	not null,
	constraint	FK_leaveOfAbsences_Employees foreign key (EmployeeId)
		references Employees(Id),
	constraint	FK_leaveOfAbsences_AbsebceType foreign key (AbsenceTypeId)
		references AbsenceTypes(Id)
);
go

SET IDENTITY_INSERT AbsenceTypes ON 

INSERT AbsenceTypes (Id, Description) VALUES (1, 'Cita medica')
INSERT AbsenceTypes (Id, Description) VALUES (2, 'Diligencia personal')
INSERT AbsenceTypes (Id, Description) VALUES (3, 'Licencia por maternidad')
INSERT AbsenceTypes (Id, Description) VALUES (4, 'Licencia por luto')
INSERT AbsenceTypes (Id, Description) VALUES (5, 'Reunión sindical')
SET IDENTITY_INSERT AbsenceTypes OFF

SET IDENTITY_INSERT Employees ON 

INSERT Employees (Id, LastName, FirstName) VALUES (1, 'Doe', 'Jho')
INSERT Employees (Id, LastName, FirstName) VALUES (2, 'Doe', 'Jane')
INSERT Employees (Id, LastName, FirstName) VALUES (3, 'Smith', 'Michael')
INSERT Employees (Id, LastName, FirstName) VALUES (4, 'Goodma', 'William')
INSERT Employees (Id, LastName, FirstName) VALUES (5, 'Bluehat', 'Nancy')
SET IDENTITY_INSERT Employees OFF

SET IDENTITY_INSERT LeaveOfAbsences ON 

INSERT LeaveOfAbsences (Id, EmployeeId, AbsenceTypeId, AbsenceDate) VALUES (1, 1, 1, CAST('2020-08-28' AS Date))
INSERT LeaveOfAbsences (Id, EmployeeId, AbsenceTypeId, AbsenceDate) VALUES (2, 2, 4, CAST('2020-08-29' AS Date))
INSERT LeaveOfAbsences (Id, EmployeeId, AbsenceTypeId, AbsenceDate) VALUES (6, 4, 5, CAST('2020-08-29' AS Date))
INSERT LeaveOfAbsences (Id, EmployeeId, AbsenceTypeId, AbsenceDate) VALUES (8, 5, 2, CAST('2020-08-29' AS Date))
SET IDENTITY_INSERT LeaveOfAbsences OFF

go