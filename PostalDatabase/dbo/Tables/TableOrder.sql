CREATE TABLE TableOrder (
	Id int IDENTITY(1,1) PRIMARY KEY,
	OrderTime DateTime DEFAULT GETDATE(),
	Complete bit DEFAULT 0,
	StaffId int FOREIGN KEY REFERENCES Staff(Id),
	TableNumId int FOREIGN KEY REFERENCES TableNum(Id)
);