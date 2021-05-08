CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(30),
	DailyPrice decimal,
	Descriptions nvarchar(30),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID)
)

CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(30)
)

CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(30)
)


INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2018','300','Renault Megane'),
	('2','1','2020','450','Honda Cıvıc'),
	('4','3','2020','600','BMW 520d'),
	('3','3','2020','650','Mercedes E250'),
	('2','1','2016','400','Honda Accord'),
	('1','2','2019','500','Renault Talısman');
	
INSERT INTO Colors(ColorName)
VALUES
	('Black'),
	('White'),
	('Grey');

INSERT INTO Brands(BrandName)
VALUES
	('Renault'),
	('Honda'),
	('Mercedes'),
	('BMW');

SELECT*FROM Cars
SELECT*FROM Brands
SELECT*FROM Colors



	 