
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2014 16:32:25
-- Generated from EDMX file: C:\Users\nqvie_000\Source\Repos\Vinasun\Vinasun\Vinasun\EntityDiagram.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_taxi_typetaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Taxis1] DROP CONSTRAINT [FK_taxi_typetaxi];
GO
IF OBJECT_ID(N'[dbo].[FK_taxi_typedriver_percentange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[driver_percentanges] DROP CONSTRAINT [FK_taxi_typedriver_percentange];
GO
IF OBJECT_ID(N'[dbo].[FK_pricedriver_percentange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[driver_percentanges] DROP CONSTRAINT [FK_pricedriver_percentange];
GO
IF OBJECT_ID(N'[dbo].[FK_taxisumary_no]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sumary_numbers] DROP CONSTRAINT [FK_taxisumary_no];
GO
IF OBJECT_ID(N'[dbo].[FK_taxiincome_per_day]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[day_incomes] DROP CONSTRAINT [FK_taxiincome_per_day];
GO
IF OBJECT_ID(N'[dbo].[FK_taxiincome_provine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[province_incomes] DROP CONSTRAINT [FK_taxiincome_provine];
GO
IF OBJECT_ID(N'[dbo].[FK_taxisubtraction_income]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[subtraction_incomes] DROP CONSTRAINT [FK_taxisubtraction_income];
GO
IF OBJECT_ID(N'[dbo].[FK_taxirepair_cost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[repair_costs] DROP CONSTRAINT [FK_taxirepair_cost];
GO
IF OBJECT_ID(N'[dbo].[FK_taxicheck_cuoc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[trip_checks] DROP CONSTRAINT [FK_taxicheck_cuoc];
GO
IF OBJECT_ID(N'[dbo].[FK_groupCollection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Collections1] DROP CONSTRAINT [FK_groupCollection];
GO
IF OBJECT_ID(N'[dbo].[FK_taxireason]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[reason_no_incomes] DROP CONSTRAINT [FK_taxireason];
GO
IF OBJECT_ID(N'[dbo].[FK_user_roleentity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entities1] DROP CONSTRAINT [FK_user_roleentity];
GO
IF OBJECT_ID(N'[dbo].[FK_entityentity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entities1] DROP CONSTRAINT [FK_entityentity];
GO
IF OBJECT_ID(N'[dbo].[FK_entitygroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entities1] DROP CONSTRAINT [FK_entitygroup];
GO
IF OBJECT_ID(N'[dbo].[FK_entitytaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Taxis1] DROP CONSTRAINT [FK_entitytaxi];
GO
IF OBJECT_ID(N'[dbo].[FK_grouptaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Taxis1] DROP CONSTRAINT [FK_grouptaxi];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Entities1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entities1];
GO
IF OBJECT_ID(N'[dbo].[Taxis1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Taxis1];
GO
IF OBJECT_ID(N'[dbo].[taxi_types]', 'U') IS NOT NULL
    DROP TABLE [dbo].[taxi_types];
GO
IF OBJECT_ID(N'[dbo].[price_ranges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[price_ranges];
GO
IF OBJECT_ID(N'[dbo].[driver_percentanges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[driver_percentanges];
GO
IF OBJECT_ID(N'[dbo].[sumary_numbers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sumary_numbers];
GO
IF OBJECT_ID(N'[dbo].[day_incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[day_incomes];
GO
IF OBJECT_ID(N'[dbo].[province_incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[province_incomes];
GO
IF OBJECT_ID(N'[dbo].[subtraction_incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[subtraction_incomes];
GO
IF OBJECT_ID(N'[dbo].[repair_costs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[repair_costs];
GO
IF OBJECT_ID(N'[dbo].[Groups1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups1];
GO
IF OBJECT_ID(N'[dbo].[trip_checks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[trip_checks];
GO
IF OBJECT_ID(N'[dbo].[Collections1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Collections1];
GO
IF OBJECT_ID(N'[dbo].[reason_no_incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reason_no_incomes];
GO
IF OBJECT_ID(N'[dbo].[UserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRoles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Entities'
CREATE TABLE [dbo].[Entities] (
    [id] int IDENTITY(1,1) NOT NULL,
    [firstname] nvarchar(max)  NOT NULL,
    [lastname] nvarchar(max)  NOT NULL,
    [birthday] datetime  NULL,
    [gender] bit  NOT NULL,
    [email] nvarchar(max)  NULL,
    [businessPhone] nvarchar(max)  NOT NULL,
    [dateJoin] datetime  NULL,
    [UserRole_id] int  NULL,
    [Leader_id] int  NULL,
    [Group_id] int  NULL
);
GO

-- Creating table 'Taxis'
CREATE TABLE [dbo].[Taxis] (
    [id] int IDENTITY(1,1) NOT NULL,
    [taxiNo] nvarchar(max)  NOT NULL,
    [dateJoin] datetime  NULL,
    [model] nvarchar(max)  NULL,
    [TaxiType_id] smallint  NOT NULL,
    [Entity_id] int  NULL,
    [Group_id] int  NULL
);
GO

-- Creating table 'TaxiTypes'
CREATE TABLE [dbo].[TaxiTypes] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [symbol] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RriceRanges'
CREATE TABLE [dbo].[RriceRanges] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [start] int  NOT NULL,
    [end] int  NOT NULL
);
GO

-- Creating table 'DriverPercentanges'
CREATE TABLE [dbo].[DriverPercentanges] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [percent] int  NOT NULL,
    [taxiType_id] smallint  NOT NULL,
    [PriceRange_id] smallint  NOT NULL
);
GO

-- Creating table 'SumaryNumbers'
CREATE TABLE [dbo].[SumaryNumbers] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [total] int  NOT NULL,
    [kmSum] int  NOT NULL,
    [tripSum] nvarchar(max)  NOT NULL,
    [Taxi_id] int  NOT NULL
);
GO

-- Creating table 'DayIncomes'
CREATE TABLE [dbo].[DayIncomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [moneySum] int  NOT NULL,
    [driverIncome] int  NOT NULL,
    [companyIncome] int  NOT NULL,
    [rateIncome] int  NOT NULL,
    [Taxi_id] int  NOT NULL
);
GO

-- Creating table 'ProvineIncomes'
CREATE TABLE [dbo].[ProvineIncomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [tripIncome] int  NOT NULL,
    [overIncome] int  NOT NULL,
    [priceIncome] int  NOT NULL,
    [Taxi_id] int  NULL
);
GO

-- Creating table 'SubtractionIncomes'
CREATE TABLE [dbo].[SubtractionIncomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [reason] int  NOT NULL,
    [created] datetime  NOT NULL,
    [Taxi_id] int  NULL
);
GO

-- Creating table 'RepairCosts'
CREATE TABLE [dbo].[RepairCosts] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [dateIn] datetime  NOT NULL,
    [dateOut] datetime  NOT NULL,
    [Taxi_id] int  NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TripChecks'
CREATE TABLE [dbo].[TripChecks] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [dateGo] datetime  NOT NULL,
    [dateBack] datetime  NOT NULL,
    [Taxi_id] int  NOT NULL
);
GO

-- Creating table 'Collections'
CREATE TABLE [dbo].[Collections] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [taxiType] nvarchar(max)  NOT NULL,
    [moneySum] int  NOT NULL,
    [driver] nvarchar(max)  NOT NULL,
    [kmSum] int  NOT NULL,
    [tripSum] int  NOT NULL,
    [created] datetime  NOT NULL,
    [Group_id] int  NULL
);
GO

-- Creating table 'ReasonNoIncomes'
CREATE TABLE [dbo].[ReasonNoIncomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [Taxi_id] int  NULL
);
GO

-- Creating table 'UserRoles'
CREATE TABLE [dbo].[UserRoles] (
    [id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [permission] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Entities'
ALTER TABLE [dbo].[Entities]
ADD CONSTRAINT [PK_Entities]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Taxis'
ALTER TABLE [dbo].[Taxis]
ADD CONSTRAINT [PK_Taxis]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TaxiTypes'
ALTER TABLE [dbo].[TaxiTypes]
ADD CONSTRAINT [PK_TaxiTypes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'RriceRanges'
ALTER TABLE [dbo].[RriceRanges]
ADD CONSTRAINT [PK_RriceRanges]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DriverPercentanges'
ALTER TABLE [dbo].[DriverPercentanges]
ADD CONSTRAINT [PK_DriverPercentanges]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'SumaryNumbers'
ALTER TABLE [dbo].[SumaryNumbers]
ADD CONSTRAINT [PK_SumaryNumbers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DayIncomes'
ALTER TABLE [dbo].[DayIncomes]
ADD CONSTRAINT [PK_DayIncomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'ProvineIncomes'
ALTER TABLE [dbo].[ProvineIncomes]
ADD CONSTRAINT [PK_ProvineIncomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'SubtractionIncomes'
ALTER TABLE [dbo].[SubtractionIncomes]
ADD CONSTRAINT [PK_SubtractionIncomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'RepairCosts'
ALTER TABLE [dbo].[RepairCosts]
ADD CONSTRAINT [PK_RepairCosts]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TripChecks'
ALTER TABLE [dbo].[TripChecks]
ADD CONSTRAINT [PK_TripChecks]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Collections'
ALTER TABLE [dbo].[Collections]
ADD CONSTRAINT [PK_Collections]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'ReasonNoIncomes'
ALTER TABLE [dbo].[ReasonNoIncomes]
ADD CONSTRAINT [PK_ReasonNoIncomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'UserRoles'
ALTER TABLE [dbo].[UserRoles]
ADD CONSTRAINT [PK_UserRoles]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TaxiType_id] in table 'Taxis'
ALTER TABLE [dbo].[Taxis]
ADD CONSTRAINT [FK_taxi_typetaxi]
    FOREIGN KEY ([TaxiType_id])
    REFERENCES [dbo].[TaxiTypes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typetaxi'
CREATE INDEX [IX_FK_taxi_typetaxi]
ON [dbo].[Taxis]
    ([TaxiType_id]);
GO

-- Creating foreign key on [taxiType_id] in table 'DriverPercentanges'
ALTER TABLE [dbo].[DriverPercentanges]
ADD CONSTRAINT [FK_taxi_typedriver_percentange]
    FOREIGN KEY ([taxiType_id])
    REFERENCES [dbo].[TaxiTypes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typedriver_percentange'
CREATE INDEX [IX_FK_taxi_typedriver_percentange]
ON [dbo].[DriverPercentanges]
    ([taxiType_id]);
GO

-- Creating foreign key on [PriceRange_id] in table 'DriverPercentanges'
ALTER TABLE [dbo].[DriverPercentanges]
ADD CONSTRAINT [FK_pricedriver_percentange]
    FOREIGN KEY ([PriceRange_id])
    REFERENCES [dbo].[RriceRanges]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pricedriver_percentange'
CREATE INDEX [IX_FK_pricedriver_percentange]
ON [dbo].[DriverPercentanges]
    ([PriceRange_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'SumaryNumbers'
ALTER TABLE [dbo].[SumaryNumbers]
ADD CONSTRAINT [FK_taxisumary_no]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisumary_no'
CREATE INDEX [IX_FK_taxisumary_no]
ON [dbo].[SumaryNumbers]
    ([Taxi_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'DayIncomes'
ALTER TABLE [dbo].[DayIncomes]
ADD CONSTRAINT [FK_taxiincome_per_day]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_per_day'
CREATE INDEX [IX_FK_taxiincome_per_day]
ON [dbo].[DayIncomes]
    ([Taxi_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'ProvineIncomes'
ALTER TABLE [dbo].[ProvineIncomes]
ADD CONSTRAINT [FK_taxiincome_provine]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_provine'
CREATE INDEX [IX_FK_taxiincome_provine]
ON [dbo].[ProvineIncomes]
    ([Taxi_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'SubtractionIncomes'
ALTER TABLE [dbo].[SubtractionIncomes]
ADD CONSTRAINT [FK_taxisubtraction_income]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisubtraction_income'
CREATE INDEX [IX_FK_taxisubtraction_income]
ON [dbo].[SubtractionIncomes]
    ([Taxi_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'RepairCosts'
ALTER TABLE [dbo].[RepairCosts]
ADD CONSTRAINT [FK_taxirepair_cost]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxirepair_cost'
CREATE INDEX [IX_FK_taxirepair_cost]
ON [dbo].[RepairCosts]
    ([Taxi_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'TripChecks'
ALTER TABLE [dbo].[TripChecks]
ADD CONSTRAINT [FK_taxicheck_cuoc]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxicheck_cuoc'
CREATE INDEX [IX_FK_taxicheck_cuoc]
ON [dbo].[TripChecks]
    ([Taxi_id]);
GO

-- Creating foreign key on [Group_id] in table 'Collections'
ALTER TABLE [dbo].[Collections]
ADD CONSTRAINT [FK_groupCollection]
    FOREIGN KEY ([Group_id])
    REFERENCES [dbo].[Groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_groupCollection'
CREATE INDEX [IX_FK_groupCollection]
ON [dbo].[Collections]
    ([Group_id]);
GO

-- Creating foreign key on [Taxi_id] in table 'ReasonNoIncomes'
ALTER TABLE [dbo].[ReasonNoIncomes]
ADD CONSTRAINT [FK_taxireason]
    FOREIGN KEY ([Taxi_id])
    REFERENCES [dbo].[Taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxireason'
CREATE INDEX [IX_FK_taxireason]
ON [dbo].[ReasonNoIncomes]
    ([Taxi_id]);
GO

-- Creating foreign key on [UserRole_id] in table 'Entities'
ALTER TABLE [dbo].[Entities]
ADD CONSTRAINT [FK_user_roleentity]
    FOREIGN KEY ([UserRole_id])
    REFERENCES [dbo].[UserRoles]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_roleentity'
CREATE INDEX [IX_FK_user_roleentity]
ON [dbo].[Entities]
    ([UserRole_id]);
GO

-- Creating foreign key on [Leader_id] in table 'Entities'
ALTER TABLE [dbo].[Entities]
ADD CONSTRAINT [FK_entityentity]
    FOREIGN KEY ([Leader_id])
    REFERENCES [dbo].[Entities]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entityentity'
CREATE INDEX [IX_FK_entityentity]
ON [dbo].[Entities]
    ([Leader_id]);
GO

-- Creating foreign key on [Group_id] in table 'Entities'
ALTER TABLE [dbo].[Entities]
ADD CONSTRAINT [FK_entitygroup]
    FOREIGN KEY ([Group_id])
    REFERENCES [dbo].[Groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entitygroup'
CREATE INDEX [IX_FK_entitygroup]
ON [dbo].[Entities]
    ([Group_id]);
GO

-- Creating foreign key on [Entity_id] in table 'Taxis'
ALTER TABLE [dbo].[Taxis]
ADD CONSTRAINT [FK_entitytaxi]
    FOREIGN KEY ([Entity_id])
    REFERENCES [dbo].[Entities]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entitytaxi'
CREATE INDEX [IX_FK_entitytaxi]
ON [dbo].[Taxis]
    ([Entity_id]);
GO

-- Creating foreign key on [Group_id] in table 'Taxis'
ALTER TABLE [dbo].[Taxis]
ADD CONSTRAINT [FK_grouptaxi]
    FOREIGN KEY ([Group_id])
    REFERENCES [dbo].[Groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_grouptaxi'
CREATE INDEX [IX_FK_grouptaxi]
ON [dbo].[Taxis]
    ([Group_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------