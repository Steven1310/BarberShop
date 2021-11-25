CREATE TABLE [dbo].[Barber]
(
	[barber_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [barber_name] NCHAR(10) NOT NULL, 
    [barber_email] NCHAR(30) NOT NULL,
    [barber_contact] NCHAR(12) NOT NULL
)
