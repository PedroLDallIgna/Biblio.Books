CREATE DATABASE BiblioBooks;
GO
USE BiblioBooks;
GO
CREATE TABLE UsersTable (User_ID int IDENTITY(1,1), User_Name nvarchar(20) NOT NULL, User_Password nvarchar(40) NOT NULL, User_Level int NOT NULL, CONSTRAINT PK_USER PRIMARY KEY (User_ID));
GO
CREATE TABLE BooksTable (Book_ID int IDENTITY(1,1), Book_Name nvarchar(60) NOT NULL, Book_Author nvarchar(60) NOT NULL, Book_Publisher nvarchar(60) NOT NULL, CONSTRAINT PK_BOOK PRIMARY KEY (Book_ID));
GO
CREATE TABLE ClientsTable (Client_ID int IDENTITY(1,1), Client_Name nvarchar(60) NOT NULL, Client_Cpf nvarchar(11) NOT NULL, Client_Phone nvarchar(14) NOT NULL, Client_Address nvarchar(120) NOT NULL, Client_City nvarchar(50) NOT NULL, CONSTRAINT PK_CLIENT PRIMARY KEY (Client_ID)); 
GO
CREATE TABLE OrdersTable (Order_ID int IDENTITY(1,1), Order_ClientName nvarchar(60) NOT NULL, Order_BookID int NOT NULL, Order_BookName nvarchar(60) NOT NULL, Order_ClientCpf nvarchar(11) NOT NULL, CONSTRAINT PK_ORDER PRIMARY KEY (ORDER_ID));
GO
INSERT INTO UsersTable (User_Name, User_Password, User_Level) VALUES ('admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 1);
GO
