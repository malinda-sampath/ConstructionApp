﻿/*
Deployment script for C:\USERS\CHATH\SOURCE\REPOS\CONSTRUCTIONAPP\REPOSITORIES\DATABASE.MDF

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "C:\USERS\CHATH\SOURCE\REPOS\CONSTRUCTIONAPP\REPOSITORIES\DATABASE.MDF"
:setvar DefaultFilePrefix "C_\USERS\CHATH\SOURCE\REPOS\CONSTRUCTIONAPP\REPOSITORIES\DATABASE.MDF_"
:setvar DefaultDataPath "C:\Users\chath\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\chath\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key  is skipped, element [dbo].[FK_vehical_To_fuelz] (SqlForeignKeyConstraint) will not be renamed to FK_vehical_To_fuel';


GO
PRINT N'Rename refactoring operation with key  is skipped, element [dbo].[daily_vehical_records].[start_millage] (SqlSimpleColumn) will not be renamed to filling_millage';


GO

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
PRINT N'Creating Table [dbo].[daily_vehical_records]...';


GO
CREATE TABLE [dbo].[daily_vehical_records] (
    [Id]              INT             NOT NULL,
    [date]            DATE            NOT NULL,
    [regNo]           INT             NOT NULL,
    [last_filling]    DECIMAL (18, 2) NULL,
    [filling_millage] DECIMAL (18)    NULL,
    [start_millage]   DECIMAL (18)    NULL,
    [route]           VARCHAR (100)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF OBJECT_ID(N'tempdb..#tmpErrors') IS NULL
    CREATE TABLE [#tmpErrors] (
        Error INT
    );

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creating Foreign Key [dbo].[FK_daily_vehical_records_To_vehical]...';


GO
ALTER TABLE [dbo].[daily_vehical_records] WITH NOCHECK
    ADD CONSTRAINT [FK_daily_vehical_records_To_vehical] FOREIGN KEY ([regNo]) REFERENCES [dbo].[vehical] ([regNo]);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF OBJECT_ID(N'tempdb..#tmpErrors') IS NULL
    CREATE TABLE [#tmpErrors] (
        Error INT
    );

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'The transacted portion of the database update succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT N'The transacted portion of the database update failed.'
GO
IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[daily_vehical_records] WITH CHECK CHECK CONSTRAINT [FK_daily_vehical_records_To_vehical];


GO
PRINT N'Update complete.';


GO
