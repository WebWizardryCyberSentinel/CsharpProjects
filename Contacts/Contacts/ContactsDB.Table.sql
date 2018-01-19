CREATE TABLE [dbo].[Table]
(
	[ContactID] INT NOT NULL DEFAULT yes , 
    [Name] NVARCHAR(50) NULL, 
    [Bedrijf] NVARCHAR(50) NULL, 
    [Telefoon] NVARCHAR(50) NULL, 
    [E-mail] NVARCHAR(50) NULL, 
    [Client] BIT NULL, 
    [Laatste Oproep] DATETIME NULL, 
    PRIMARY KEY ([ContactID])
)
