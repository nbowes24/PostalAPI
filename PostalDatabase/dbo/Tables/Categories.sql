CREATE TABLE Categories (
	Id int IDENTITY(1,1) PRIMARY KEY,
	CategoriesText varchar(128) NOT NULL,
	DisplayOrder int NOT NULL
);