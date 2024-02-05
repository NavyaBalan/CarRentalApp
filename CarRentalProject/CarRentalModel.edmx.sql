
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/30/2024 10:41:42
-- Generated from EDMX file: C:\Users\krishnakumar\source\repos\CarRentalProject\CarRentalProject\CarRentalModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarRental];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarRentalRecord_CarRentalRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarRentalRecord] DROP CONSTRAINT [FK_CarRentalRecord_CarRentalRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_CarRentalRecord_TypesOfCars]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarRentalRecord] DROP CONSTRAINT [FK_CarRentalRecord_TypesOfCars];
GO
IF OBJECT_ID(N'[dbo].[FK_TypesOfCars_TypesOfCars]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TypesOfCars] DROP CONSTRAINT [FK_TypesOfCars_TypesOfCars];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CarRentalRecord]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarRentalRecord];
GO
IF OBJECT_ID(N'[dbo].[TypesOfCars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypesOfCars];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CarRentalRecords'
CREATE TABLE [dbo].[CarRentalRecords] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerName] nchar(10)  NULL,
    [DateRented] datetime  NULL,
    [DateReturned] datetime  NULL,
    [Cost] decimal(18,0)  NULL,
    [TypesOfCarsId] int  NULL
);
GO

-- Creating table 'TypesOfCars'
CREATE TABLE [dbo].[TypesOfCars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Make] nvarchar(50)  NOT NULL,
    [Model] nvarchar(50)  NULL,
    [VIN] nvarchar(50)  NULL,
    [LicensePlateNumber] nchar(10)  NULL,
    [Year] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CarRentalRecords'
ALTER TABLE [dbo].[CarRentalRecords]
ADD CONSTRAINT [PK_CarRentalRecords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypesOfCars'
ALTER TABLE [dbo].[TypesOfCars]
ADD CONSTRAINT [PK_TypesOfCars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'CarRentalRecords'
ALTER TABLE [dbo].[CarRentalRecords]
ADD CONSTRAINT [FK_CarRentalRecord_CarRentalRecord]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[CarRentalRecords]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TypesOfCarsId] in table 'CarRentalRecords'
ALTER TABLE [dbo].[CarRentalRecords]
ADD CONSTRAINT [FK_CarRentalRecord_TypesOfCars]
    FOREIGN KEY ([TypesOfCarsId])
    REFERENCES [dbo].[TypesOfCars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarRentalRecord_TypesOfCars'
CREATE INDEX [IX_FK_CarRentalRecord_TypesOfCars]
ON [dbo].[CarRentalRecords]
    ([TypesOfCarsId]);
GO

-- Creating foreign key on [Id] in table 'TypesOfCars'
ALTER TABLE [dbo].[TypesOfCars]
ADD CONSTRAINT [FK_TypesOfCars_TypesOfCars]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TypesOfCars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------