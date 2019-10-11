CREATE TABLE Menu (
	Id int IDENTITY(1,1) PRIMARY KEY,
	FoodDescription varchar(256) NOT NULL,
	Price smallmoney NOT NULL,
	Available bit NOT NULL,
	CategoryID int FOREIGN KEY REFERENCES Categories(Id)
);