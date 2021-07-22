
CREATE TABLE CUSTOMER (
CustomerId int UNIQUE NOT NULL,
FirstName varchar(50),
LastName varchar(50),
City varchar(50),
Email varchar(50),
Gender varchar(1),
BankerId int,
Primary key(CustomerId)
);

CREATE TABLE BANKER (
BankerId int unique not null,
FirstName varchar(50),
LastName varchar(50),
City varchar(50),
Email varchar(50),
Gender varchar(1),
Primary key(BankerId),
CustomerId int,
Foreign key(CustomerId) references CUSTOMER(CustomerId)
);

CREATE TABLE ACCOUNT(
CustomerId int,
CustomerName varchar(50),
AccountNumber int unique not null,
CreditCardNumber int,
Primary key(AccountNumber),
BankerId int,
Foreign key(CustomerId) references CUSTOMER(CustomerId),
Category varchar(50),
Balance int
);

CREATE TABLE CREDITCARD(
CreditCardNumber int,
AccountNumber int,
CustomerId int,
CustomerName varchar(50),
Primary key(CreditCardNumber),
Foreign key(AccountNumber) references ACCOUNT(AccountNumber),
Foreign key(CustomerId) references CUSTOMER(CustomerId),
Limit int,
ExpiredDate date
);

