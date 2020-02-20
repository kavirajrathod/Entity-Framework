
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 12:03:13
-- Generated from EDMX file: C:\Users\Admin\source\repos\ModelFirstEntityFramework\ModelFirstEntityFramework\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DemoDp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Product2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product2];
GO
IF OBJECT_ID(N'[dbo].[Category2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category2];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Product2'
CREATE TABLE [dbo].[Product2] (
    [Pid] int IDENTITY(1,1) NOT NULL,
    [Ptitle] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Cid] int  NOT NULL
);
GO

-- Creating table 'Category2'
CREATE TABLE [dbo].[Category2] (
    [Cid] int IDENTITY(1,1) NOT NULL,
    [Ctitle] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Pid] in table 'Product2'
ALTER TABLE [dbo].[Product2]
ADD CONSTRAINT [PK_Product2]
    PRIMARY KEY CLUSTERED ([Pid] ASC);
GO

-- Creating primary key on [Cid] in table 'Category2'
ALTER TABLE [dbo].[Category2]
ADD CONSTRAINT [PK_Category2]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------