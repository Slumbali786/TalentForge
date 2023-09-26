CREATE TABLE tblRegUsers
(
	[RUID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(30) NOT NULL, 
    [Surname] NVARCHAR(30) NOT NULL, 
    [Nationality] NVARCHAR(30) NOT NULL, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Gender] NVARCHAR(1) NOT NULL, 
    [MaritalStatus] BIT NOT NULL, 
    [ContactNum] NVARCHAR(10) NOT NULL, 
    [Email] NVARCHAR(25) NOT NULL, 
    [ResAddress] NVARCHAR(100) NOT NULL, 
    [PostalAddress] NVARCHAR(100) NOT NULL
)
