CREATE TABLE [dbo].[User]
(
	[user_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [user_name] NCHAR(20) NOT NULL, 
    [user_email] NCHAR(30) NOT NULL,
    [user_contact] NCHAR(12) NOT NULL
)