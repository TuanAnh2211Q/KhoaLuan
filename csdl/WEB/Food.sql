CREATE DATABASE FoodDB
GO
USE FoodDB
GO

Create Table [Users]
(
[UserID] int Primary key Identity(1,1) not null,
[Name] nvarchar(50) null,
[Username] varchar(50) null Unique,
[Mobile] varchar(50),
[Email] varchar(50) null unique,
[CreateDate] datetime null
)
go
Create Table [Contact]
(
[ContactId] int primary key identity(1,1) not null,
[Name] nvarchar(50) null,
[Email] varchar(50) null,
[Subject] nvarchar(200) null,
[Message] varchar(max) null,
[CreateDate] datetime null
)
go
Create Table [Categories]
(
[CategoryId] int primary key identity(1,1) not null,
[Name] nvarchar(50) null,
[ImageUrl] varchar(max) null,
[IsActive] bit null,
[CreateDate] datetime null
)
go
Create Table [Products]
(
[ProductId] int primary key identity(1,1) not null,
[Name] nvarchar(50) null,
[Description] varchar(max) null,
[Price] decimal(18,2) null,
[Quantity] int null,
[ImageUrl] varchar(max) null,
[CategoryId] int null,
[IsActive] bit null,
[CreateDate] datetime null
)
go
Create Table [Carts]
(
[CartID] int primary key identity(1,1) not null,
[ProductId] int null,
[Quantity] int null,
[UserID] int null
)
go
Create Table [Orders]
(
[OrderDetailsID] int primary key identity(1,1) not null,
[OrderNo] varchar(max) null,
[ProductId] int null,
[Quantity] int null,
[UserID] int null,
[Status] varchar(50) null,
[PaymentID] int null,
[OrderDate] datetime null
)
go
Create Table [Payment]
(
[PaymentID] int primary key identity(1,1) not null,
[Name] nvarchar(50) null,
[CardNo] varchar(50) null,
[ExpiryDate] varchar(50) null,
[CvvNO] int null,
[Address] nvarchar(max) null,
[PaymentMode] nvarchar(50) null 
)

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Category_Crud
@Action VARCHAR(10),
@CategoryID INT = NULL,
@Name NVARCHAR(50) = NULL,
@IsActive BIT = false,
@ImageUrl VARCHAR(MAX) = NULL
AS
BEGIN
SET NOCOUNT ON;

--SELECT
IF @Action = 'SELECT'
BEGIN
	SELECT * FROM dbo.Categories ORDER BY CreateDate DESC
END

--INSERT
IF @Action = 'INSERT'
BEGIN
	INSERT INTO dbo.Categories(Name, ImageUrl, IsActive, CreateDate)
	VALUES (@Name, @ImageUrl, @IsActive, GETDATE())
END

--UPDATE
IF @Action = 'UPDATE'
BEGIN
	DECLARE @UPDATE_IMAGE VARCHAR(20)
	SELECT @UPDATE_IMAGE = (CASE WHEN @ImageUrl IS NULL THEN 'NO' ELSE 'YES' END)
	IF @UPDATE_IMAGE = 'NO'
		BEGIN
			UPDATE dbo.Categories
			SET Name = @Name,
				IsActive= @IsActive
			WHERE CategoryId=@CategoryID
		END
	ELSE
		BEGIN
			UPDATE dbo.Categories
			SET Name = @Name,
				ImageUrl=@ImageUrl,
				IsActive= @IsActive
			WHERE CategoryId=@CategoryID
		END
END

--DELETE
IF @Action = 'DELETE'
BEGIN
	DELETE FROM dbo.Categories WHERE CategoryId = @CategoryID
END

--GETBYID
IF @Action = 'GETBYID'
BEGIN
	SELECT * FROM dbo.Categories WHERE CategoryId = @CategoryID
END


END
GO