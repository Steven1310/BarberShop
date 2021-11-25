CREATE TABLE [dbo].[Barber_shifts]
(
	[barber_id] INT Foreign key (barber_id)  references [Barber] IDENTITY, 
    [shift_id] INT Foreign key(shift_id)  references [Shifts],
    [price] INT NOT NULL, 
    CONSTRAINT PK_BarberShifts PRIMARY KEY ([barber_id],[shift_id])  
)
