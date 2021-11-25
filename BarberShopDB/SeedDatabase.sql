/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [dbo].[Shifts] ON
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (1, '13:20:00', '17:50:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (2, '9:30:00', '17:45:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (3, '10:25:00', '13:30:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (4, '11:00:00', '17:00:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (5, '10:30:00', '19:30:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (6, '11:00:00', '12:25:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (7, '14:00:00', '14:45:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (8, '11:00:00', '13:50:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (9, '12:15:00', '16:50:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (10, '11:30:00', '12:20:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (11, '12:20:00', '14:30:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (12, '11:00:00', '13:30:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (13, '14:30:00', '15:00:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (14, '10:00:00', '18:00:00');
INSERT INTO [dbo].[Shifts] ([shift_id], [shift_start_time], [shift_end_time]) VALUES (15, '11:50:00', '13:30:00');
SET IDENTITY_INSERT [dbo].[Shifts] OFF
GO

SET IDENTITY_INSERT [dbo].[Barber] ON
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (1, N'John', N'john@gmail.com', N'236-789-1234')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (2, N'Bill', N'jbkelling1@discuz.net', N'488-681-5180')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (3, N'Tudor', N'tharris2@over-blog.com', N'869-743-7544')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (4, N'Lucais', N'lparcell3@skyrock.com', N'632-446-9773')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (5, N'Rheta', N'rdundredge4@linkedin.com', N'134-581-1712')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (6, N'Emmalynn', N'eedinburough5@github.com', N'566-643-4531')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (7, N'Iorgos', N'imundell6@deliciousdays.com', N'526-643-4331')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (8, N'Abbot', N'aswatton7@squarespace.com', N'223-402-8437')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (9, N'Augustus', N'ahedan8@vistaprint.com', N'767-738-5395')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (10, N'Kingsley', N'kwarters9@yelp.com', N'346-838-8774')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (11, N'Florinda', N'jstacka@google.com', N'574-865-0888')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (12, N'Bryon', N'rfreakq@goo.com', N'767-221-3642')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (13, N'Inna', N'eesbergers@acquirethisname.com', N'273-481-5406')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (14, N'Winnie', N'llehuquetu@angelfire.com', N'371-785-7410')
INSERT INTO [dbo].[Barber] ([barber_id], [barber_name], [barber_email] , [barber_contact]) VALUES (15, N'Rod', N'edeehanw@tamu.edu', N'837-564-7153')
SET IDENTITY_INSERT [dbo].[Barber] OFF
GO

SET IDENTITY_INSERT [dbo].[Barber_Shifts] ON
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (1, 15, 1)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (2, 25, 2)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (3, 20, 3)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (4, 15, 4)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (5, 15, 5)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (6, 20, 6)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (7, 25, 7)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (8, 15, 8)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (9, 20, 9)
INSERT INTO [dbo].[Barber_Shifts] ([barber_id], [price], [shift_id]) VALUES (10, 15, 10)
SET IDENTITY_INSERT [dbo].[Barber_Shifts] OFF
GO

SET IDENTITY_INSERT [dbo].[Shops] ON
INSERT INTO [dbo].[Shops] ([shop_id], [shop_name], [location],[postal_code]) VALUES (1,  N'Deckow Bogan and Hammes', N'3943 Tennessee Junction', N'568 92')
INSERT INTO [dbo].[Shops] ([shop_id], [shop_name], [location],[postal_code]) VALUES (2,  N'Ferry, D''Amore and Krajcik', N'80 Bunting Pass', N'9201')
INSERT INTO [dbo].[Shops] ([shop_id], [shop_name], [location],[postal_code]) VALUES (3,  N'King, Thiel and Moore', N'8096 Colorado Hill', N'7301')
INSERT INTO [dbo].[Shops] ([shop_id], [shop_name], [location],[postal_code]) VALUES (4,  N'Larkin LLC', N'1 Dixon Junction', N'5302')
INSERT INTO [dbo].[Shops] ([shop_id], [shop_name], [location],[postal_code]) VALUES (5,  N'Zemlak-Barton', N'075 Larry Trail', N'4302')
SET IDENTITY_INSERT [dbo].[Shops] OFF
GO

SET IDENTITY_INSERT [dbo].[Haircut] ON
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (1, N'a',N'undercut' ,12)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (2, N'b',N'quiff' ,12)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (3, N'c',N'side part' ,13)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (4, N'd',N'buzz cut' ,13)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (5, N'e',N'modern french crop' ,13)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (6, N'f',N'Forward Stranded Top with Faded Sides' ,14)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (7, N'g',N'Simple Top and Mustache Duet' ,15)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (8, N'h',N'Classic Taper and Brush-Back' ,15)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (9, N'i',N'Afro Mid Temple Fade' ,15)
INSERT INTO [dbo].[Haircut] ([haircut_id], [picture], [description],[price]) VALUES (10, N'j',N'Short Textured Men Haircut' ,15)
SET IDENTITY_INSERT [dbo].[Haircut] OFF
GO


SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (1, 'Maribelle Gurton', 'mgurton0@cisco.com', '592-244-8780')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (2, 'Gilles Land', 'gland1@wikia.com', '982-904-8538')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (3, 'Sammie Whichelow', 'swhichelow2@yahoo.co.jp', '115-117-3750')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (4, 'Archibold Chestle', 'achestle3@ifeng.com', '751-286-0322')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (5, 'Shaughn Puckett', 'spuckett4@businesswire.com', '516-865-3047')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (6, 'Bonnee Clere', 'bclere5@opera.com', '576-660-3857')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (7, 'Packston Ector', 'pector6@clickbank.net', '311-842-6119')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (8, 'Redford Tinghill', 'rtinghill7@deviantart.com', '912-879-9131')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES (9, 'Jodi Biglin', 'jbiglin8@yandex.ru', '757-579-7339')
INSERT INTO [dbo].[User] ([user_id], [user_name], [user_email],[user_contact]) VALUES(10, 'Nikolaos Diable', 'ndiable9@thetimes.co.uk', '141-579-1270')
SET IDENTITY_INSERT [dbo].[User] OFF
GO


INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,1,1)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,2,2)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,3,3)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,4,4)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,5,5)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,1,1)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,2,2)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,3,3)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,4,4)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,5,5)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,1,1)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,2,2)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,3,3)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,4,4)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,5,5)



INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('PENDING','The request is pending and yet to be processed');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('ACCEPTED','The request is accepted');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('REJECTED','The request is rejected');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('FULLFILLED','The request is fullfilled');


SET IDENTITY_INSERT [dbo].[Appointment] ON
INSERT INTO [dbo].[Appointment] ([appointment_id],[barberAvail_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (1,1,1,1,'14:00:00','PENDING','N')
INSERT INTO [dbo].[Appointment] ([appointment_id],[barberAvail_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (2,4,2,3,'11:30:00','PENDING','N')
INSERT INTO [dbo].[Appointment] ([appointment_id],[barberAvail_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (3,5,3,1,'13:30:00','ACCEPTED','Y')
INSERT INTO [dbo].[Appointment] ([appointment_id],[barberAvail_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (4,8,4,4,'14:15:00','REJECTED','N')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO