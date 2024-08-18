CREATE TABLE [dbo].[users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(50) NOT NULL, 
    [username] VARCHAR(50) NOT NULL UNIQUE, 
    [password] VARCHAR(100) NOT NULL, 
    [date_registered] DATETIME NULL,
)

/* make a new Database.mdt file under repository folder.
insert above table by executing this string.
make sure to change connection string for DbManager.cs */
