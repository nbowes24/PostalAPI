﻿CREATE TABLE TableNum (
	Id int IDENTITY(1,1) PRIMARY KEY,
	StaffId int FOREIGN KEY REFERENCES Staff(Id) NULL,
	TableNumber int NOT NULL
);