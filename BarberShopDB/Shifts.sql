CREATE TABLE [dbo].[Shifts]
(
	[shift_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [shift_start_time] TIME NOT NULL,
	[shift_end_time] TIME NOT NULL
)
