CREATE TABLE Users(
	Id int,
	FirstName nvarchar(30),
	LastName nvarchar(20),
	Email nvarchar(50),
	Passcode nvarchar(15),
)

CREATE TABLE Customers(
	UserId int,
	CompanyName nvarchar(40),
)

CREATE TABLE Rentals(
	Id int,
	CarId int,
	CustomerId int,
	RentDate nvarchar(20),
	ReturnDate nvarchar(20),
)

INSERT INTO Users(Id,FirstName,LastName,Email,Passcode)
VALUES
	('1','Fatih','Yanık','fatihyanik@live.com','12345'),
	('2','Engin','Demirog','engindemirog@gmail.com','45678'),
	('3','Sadık','Turan','sadikturan@live.com','36579'),
	('4','Mehmed','Taha','mehmedtaha@hotmail.com','36579');

INSERT INTO Customers(UserId,CompanyName)
VALUES
	('1','FynkSoft'),
	('2','Hayat'),
	('3','Peak');

INSERT INTO Rentals(Id,CarId,CustomerId,RentDate,ReturnDate)
VALUES
	('1','1','2','23.01.2021',''),
	('2','3','1','20.01.2021','20.02.2021'),
	('3','4','3','15.02.2021','18.02.2021'),
	('4','2','4','7.02.2021','');
