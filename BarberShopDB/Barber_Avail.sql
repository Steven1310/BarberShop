CREATE TABLE [dbo].[Barber_Avail]
(
    [barberAvail_id] INT PRIMARY KEY IDENTITY,
	[shop_id] INT Foreign key(shop_id)  references [dbo].[Shops], 
    [barber_id] INT, 
    [shift_id] INT,
    CONSTRAINT fk_BarberShiftAvail Foreign KEY([barber_id],[shift_id]) references [dbo].[Barber_shifts],
    CONSTRAINT Unq_BarbershopAvail UNIQUE ([shop_id],[barber_id],[shift_id])
)
