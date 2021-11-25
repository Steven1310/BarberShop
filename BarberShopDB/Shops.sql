CREATE TABLE [dbo].[Shops]
(
	[shop_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [shop_name] NCHAR(70) NOT NULL, 
    [location] NCHAR(70) NOT NULL,
    [postal_code] NCHAR(6) NOT NULL,
)
