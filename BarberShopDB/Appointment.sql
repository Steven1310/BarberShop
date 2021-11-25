CREATE TABLE [dbo].[Appointment]
(
    [appointment_id] INT IDENTITY (1,1) PRIMARY KEY,
	[barberAvail_id] INT ,
    [haircut_id] INT Foreign key(haircut_id)  references [dbo].[Haircut],
    [user_id] INT Foreign key(user_id)  references [dbo].[User],
    [appointment_time] time(7),
    [status_id] NCHAR(10) Foreign key(status_id)  references [dbo].[Status],
    [payment_status] NCHAR(1) DEFAULT 'N',
    [review] INT DEFAULT 0, 
    CONSTRAINT fK_BarbershopAvail Foreign KEY([barberAvail_id]) references [dbo].[Barber_Avail],
    CONSTRAINT chk_Review CHECK ([review]>=0 AND [review]<=10)
)
