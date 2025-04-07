create table Customer (

CustomerID varchar(255) primary key,
CustomerName varchar(255) not null,
Gender varchar(255) not null,
Email varchar(255) not null unique,
PhoneNumber varchar(255)

);

create table Employee (

EmployeeID varchar(255) primary key,
EmployeeName varchar(255) not null,
Position varchar(255) not null,
Gender varchar(255) not null,
Email varchar(255) not null unique,
PhoneNumber varchar(255) not null,
DOB date,
AccountPassword varchar(255) not null

);

create table Item (

ItemID varchar(255) primary key,
ItemName varchar(255),
Price decimal(10, 2) check (Price >= 0),
Category varchar(255)

);

create table ItemOrder (

OrderID varchar(255) primary key,
ItemID varchar(255) not null,
CustomerID varchar(255) not null,
ChefEmployeeID varchar(255) not null,
DateOfOrder date not null,
OrderStatus varchar(255) not null,
foreign key (ChefEmployeeID) references Employee(EmployeeID),
foreign key (ItemID) references Item(ItemID),
foreign key (CustomerID) references Customer(CustomerID)

);

create table Hall (

HallNumber varchar(255) primary key,
HallName varchar(255) not null,
Capacity smallint check (Capacity > 0),
RecommendedEvent1 varchar(255),
RecommendedEvent2 varchar(255),
IsAvailable bit not null

);

create table HallReservation (

ReservationID varchar(255) primary key,
HallNumber varchar(255) not null,
CustomerID varchar(255) not null,
EventType varchar(255) not null,
EventDate date not null,
ExpectedCount tinyint,
ReservationStatus varchar(255) not null,
RequestResponse varchar(255),
Remarks varchar(255),
foreign key (HallNumber) references Hall(HallNumber),
foreign key (CustomerID) references Customer(CustomerID)

);

create table Feedback (

FeedbackID varchar(255) primary key,
CustomerID varchar(255) not null,
FeedbackSentence varchar(255),
Rating tinyint check(Rating > 0 and Rating <= 5)
foreign key (CustomerID) references Customer(CustomerID)

);

create table Ingredients (

IngredientNumber varchar(255) primary key,
IngredientName varchar(255),
Quantity smallint

);