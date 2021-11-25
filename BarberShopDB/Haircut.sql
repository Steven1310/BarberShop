CREATE TABLE [dbo].[Haircut]
(
	[haircut_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [picture] NCHAR(15) NOT NULL, 
    [description] NCHAR(100) NOT NULL,
    [price] INT NOT NULL
)
