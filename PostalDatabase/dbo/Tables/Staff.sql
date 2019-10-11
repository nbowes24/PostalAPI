CREATE TABLE Staff (
	Id int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(128) NOT NULL,
	LastName varchar(128) NOT NULL,
	Pin int NOT NULL,
	AdminFlag bit NOT NULL
);