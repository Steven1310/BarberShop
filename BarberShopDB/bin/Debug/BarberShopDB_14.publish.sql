﻿/*
Deployment script for BarberShop

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BarberShop"
:setvar DefaultFilePrefix "BarberShop"
:setvar DefaultDataPath "C:\Users\hp\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\hp\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Appointment]...';


GO
CREATE TABLE [dbo].[Appointment] (
    [appointment_id]   INT        IDENTITY (0, 1) NOT NULL,
    [shop_id]          INT        NULL,
    [barber_id]        INT        NULL,
    [shift_id]         INT        NULL,
    [haircut_id]       INT        NULL,
    [user_id]          INT        NULL,
    [appointment_time] TIME (7)   NULL,
    [status_id]        NCHAR (10) NULL,
    [payment_status]   NCHAR (1)  NULL,
    [review]           INT        NULL,
    PRIMARY KEY CLUSTERED ([appointment_id] ASC)
);


GO
PRINT N'Creating [dbo].[Barber]...';


GO
CREATE TABLE [dbo].[Barber] (
    [barber_id]      INT        IDENTITY (1, 1) NOT NULL,
    [barber_name]    NCHAR (10) NOT NULL,
    [barber_email]   NCHAR (30) NOT NULL,
    [barber_contact] NCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([barber_id] ASC)
);


GO
PRINT N'Creating [dbo].[Barber_Avail]...';


GO
CREATE TABLE [dbo].[Barber_Avail] (
    [shop_id]   INT IDENTITY (1, 1) NOT NULL,
    [barber_id] INT NOT NULL,
    [shift_id]  INT NOT NULL,
    CONSTRAINT [PK_BarbershopAvail] PRIMARY KEY CLUSTERED ([shop_id] ASC, [barber_id] ASC, [shift_id] ASC)
);


GO
PRINT N'Creating [dbo].[Barber_shifts]...';


GO
CREATE TABLE [dbo].[Barber_shifts] (
    [barber_id] INT IDENTITY (1, 1) NOT NULL,
    [shift_id]  INT NOT NULL,
    [price]     INT NOT NULL,
    CONSTRAINT [PK_BarberShifts] PRIMARY KEY CLUSTERED ([barber_id] ASC, [shift_id] ASC)
);


GO
PRINT N'Creating [dbo].[Haircut]...';


GO
CREATE TABLE [dbo].[Haircut] (
    [haircut_id]  INT         IDENTITY (1, 1) NOT NULL,
    [picture]     NCHAR (15)  NOT NULL,
    [description] NCHAR (100) NOT NULL,
    [price]       INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([haircut_id] ASC)
);


GO
PRINT N'Creating [dbo].[Shifts]...';


GO
CREATE TABLE [dbo].[Shifts] (
    [shift_id]         INT      IDENTITY (1, 1) NOT NULL,
    [shift_start_time] TIME (7) NOT NULL,
    [shift_end_time]   TIME (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([shift_id] ASC)
);


GO
PRINT N'Creating [dbo].[Shops]...';


GO
CREATE TABLE [dbo].[Shops] (
    [shop_id]     INT        IDENTITY (1, 1) NOT NULL,
    [shop_name]   NCHAR (70) NOT NULL,
    [location]    NCHAR (70) NOT NULL,
    [postal_code] NCHAR (6)  NOT NULL,
    PRIMARY KEY CLUSTERED ([shop_id] ASC)
);


GO
PRINT N'Creating [dbo].[Status]...';


GO
CREATE TABLE [dbo].[Status] (
    [status_id]   NCHAR (10)  NOT NULL,
    [description] NCHAR (500) NOT NULL,
    PRIMARY KEY CLUSTERED ([status_id] ASC)
);


GO
PRINT N'Creating [dbo].[User]...';


GO
CREATE TABLE [dbo].[User] (
    [user_id]      INT        IDENTITY (1, 1) NOT NULL,
    [user_name]    NCHAR (10) NOT NULL,
    [user_email]   NCHAR (30) NOT NULL,
    [user_contact] NCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Appointment]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD DEFAULT 'N' FOR [payment_status];


GO
PRINT N'Creating unnamed constraint on [dbo].[Appointment]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD DEFAULT 0 FOR [review];


GO
PRINT N'Creating unnamed constraint on [dbo].[Appointment]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD FOREIGN KEY ([haircut_id]) REFERENCES [dbo].[Haircut] ([haircut_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Appointment]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD FOREIGN KEY ([user_id]) REFERENCES [dbo].[User] ([user_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Appointment]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD FOREIGN KEY ([status_id]) REFERENCES [dbo].[Status] ([status_id]);


GO
PRINT N'Creating [dbo].[fK_BarbershopAvail]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD CONSTRAINT [fK_BarbershopAvail] FOREIGN KEY ([shop_id], [barber_id], [shift_id]) REFERENCES [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Barber_Avail]...';


GO
ALTER TABLE [dbo].[Barber_Avail]
    ADD FOREIGN KEY ([shop_id]) REFERENCES [dbo].[Shops] ([shop_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Barber_Avail]...';


GO
ALTER TABLE [dbo].[Barber_Avail]
    ADD FOREIGN KEY ([shop_id]) REFERENCES [dbo].[Barber] ([barber_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Barber_Avail]...';


GO
ALTER TABLE [dbo].[Barber_Avail]
    ADD FOREIGN KEY ([shift_id]) REFERENCES [dbo].[Shifts] ([shift_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Barber_shifts]...';


GO
ALTER TABLE [dbo].[Barber_shifts]
    ADD FOREIGN KEY ([barber_id]) REFERENCES [dbo].[Barber] ([barber_id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Barber_shifts]...';


GO
ALTER TABLE [dbo].[Barber_shifts]
    ADD FOREIGN KEY ([shift_id]) REFERENCES [dbo].[Shifts] ([shift_id]);


GO
PRINT N'Creating [dbo].[chk_Review]...';


GO
ALTER TABLE [dbo].[Appointment]
    ADD CONSTRAINT [chk_Review] CHECK ([review]>=0 AND [review]<=10);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '321eef4c-510d-4a0e-b62c-99d2df8abbd9')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('321eef4c-510d-4a0e-b62c-99d2df8abbd9')

GO

GO
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

SET IDENTITY_INSERT [dbo].[Barber_Avail] ON
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,1,1)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,2,4)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (1,3,5)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,4,7)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,5,3)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (2,6,2)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,7,10)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,8,11)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (3,9,13)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,10,12)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,11,3)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (4,12,5)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,13,6)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,14,2)
INSERT INTO [dbo].[Barber_Avail] ([shop_id], [barber_id], [shift_id]) VALUES (5,15,14)
SET IDENTITY_INSERT [dbo].[Barber_Avail] OFF
GO


INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('PENDING','The request is pending and yet to be processed');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('ACCEPTED','The request is accepted');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('REJECTED','The request is rejected');
INSERT INTO [dbo].[Status] ([status_id],[description]) VALUES ('FULLFILLED','The request is fullfilled');


SET IDENTITY_INSERT [dbo].[Appointment] ON
INSERT INTO [dbo].[Appointment] ([appointment_id],[shop_id], [barber_id], [shift_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (1,1,1,1,1,1,'14:00:00','PENDING','N')
INSERT INTO [dbo].[Appointment] ([appointment_id],[shop_id], [barber_id], [shift_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (2,1,2,4,2,3,'11:30:00','PENDING','N')
INSERT INTO [dbo].[Appointment] ([appointment_id],[shop_id], [barber_id], [shift_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (3,1,3,5,3,1,'13:30:00','ACCEPTED','Y')
INSERT INTO [dbo].[Appointment] ([appointment_id],[shop_id], [barber_id], [shift_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES (4,2,4,7,4,4,'14:15:00','REJECTED','N')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
