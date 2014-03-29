
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2014 09:58:21
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
    ALTER TABLE [dbo].[taxis] DROP CONSTRAINT [FK_taxi_typetaxi];
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
    ALTER TABLE [dbo].[collections] DROP CONSTRAINT [FK_groupCollection];
GO
IF OBJECT_ID(N'[dbo].[FK_taxireason]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[reason_no_incomes] DROP CONSTRAINT [FK_taxireason];
GO
IF OBJECT_ID(N'[dbo].[FK_user_roleentity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enties] DROP CONSTRAINT [FK_user_roleentity];
GO
IF OBJECT_ID(N'[dbo].[FK_entityentity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enties] DROP CONSTRAINT [FK_entityentity];
GO
IF OBJECT_ID(N'[dbo].[FK_entitygroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enties] DROP CONSTRAINT [FK_entitygroup];
GO
IF OBJECT_ID(N'[dbo].[FK_entitytaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[taxis] DROP CONSTRAINT [FK_entitytaxi];
GO
IF OBJECT_ID(N'[dbo].[FK_grouptaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[taxis] DROP CONSTRAINT [FK_grouptaxi];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[enties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enties];
GO
IF OBJECT_ID(N'[dbo].[taxis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[taxis];
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
IF OBJECT_ID(N'[dbo].[groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[groups];
GO
IF OBJECT_ID(N'[dbo].[trip_checks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[trip_checks];
GO
IF OBJECT_ID(N'[dbo].[collections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[collections];
GO
IF OBJECT_ID(N'[dbo].[reason_no_incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reason_no_incomes];
GO
IF OBJECT_ID(N'[dbo].[user_role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user_role];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'enties'
CREATE TABLE [dbo].[enties] (
    [id] int IDENTITY(1,1) NOT NULL,
    [firstname] nvarchar(max)  NOT NULL,
    [lastname] nvarchar(max)  NOT NULL,
    [birthday] datetime  NULL,
    [gender] bit  NOT NULL,
    [email] nvarchar(max)  NULL,
    [businessphone] nvarchar(max)  NOT NULL,
    [date_join] datetime  NULL,
    [user_role_id] int  NULL,
    [leader_id] int  NULL,
    [groups_id] int  NULL
);
GO

-- Creating table 'taxis'
CREATE TABLE [dbo].[taxis] (
    [id] int IDENTITY(1,1) NOT NULL,
    [taxi_no] nvarchar(max)  NOT NULL,
    [date_join] datetime  NULL,
    [model] nvarchar(max)  NULL,
    [taxi_type_id] smallint  NOT NULL,
    [entity_id] int  NULL,
    [group_id] int  NULL
);
GO

-- Creating table 'taxi_types'
CREATE TABLE [dbo].[taxi_types] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [symbol] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'price_ranges'
CREATE TABLE [dbo].[price_ranges] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [start] int  NOT NULL,
    [end] int  NOT NULL
);
GO

-- Creating table 'driver_percentanges'
CREATE TABLE [dbo].[driver_percentanges] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [percent] int  NOT NULL,
    [taxi_type_id] smallint  NOT NULL,
    [price_range_id] smallint  NOT NULL
);
GO

-- Creating table 'sumary_numbers'
CREATE TABLE [dbo].[sumary_numbers] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [total] int  NOT NULL,
    [km_sum] int  NOT NULL,
    [trip_sum] nvarchar(max)  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'day_incomes'
CREATE TABLE [dbo].[day_incomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [money_sum] int  NOT NULL,
    [driver_income] int  NOT NULL,
    [company_income] int  NOT NULL,
    [rate_income] int  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'province_incomes'
CREATE TABLE [dbo].[province_incomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [trip_income] int  NOT NULL,
    [over_income] int  NOT NULL,
    [price_income] int  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'subtraction_incomes'
CREATE TABLE [dbo].[subtraction_incomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [reason] int  NOT NULL,
    [created] datetime  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'repair_costs'
CREATE TABLE [dbo].[repair_costs] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [date_in] datetime  NOT NULL,
    [date_out] datetime  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'groups'
CREATE TABLE [dbo].[groups] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'trip_checks'
CREATE TABLE [dbo].[trip_checks] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [date_go] datetime  NOT NULL,
    [date_back] datetime  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'collections'
CREATE TABLE [dbo].[collections] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [taxi_type] nvarchar(max)  NOT NULL,
    [money_sum] int  NOT NULL,
    [driver] nvarchar(max)  NOT NULL,
    [km_sum] int  NOT NULL,
    [trip_sum] int  NOT NULL,
    [created] datetime  NOT NULL,
    [group_id] int  NULL
);
GO

-- Creating table 'reason_no_incomes'
CREATE TABLE [dbo].[reason_no_incomes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'user_role'
CREATE TABLE [dbo].[user_role] (
    [id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [permission] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'enties'
ALTER TABLE [dbo].[enties]
ADD CONSTRAINT [PK_enties]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'taxis'
ALTER TABLE [dbo].[taxis]
ADD CONSTRAINT [PK_taxis]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'taxi_types'
ALTER TABLE [dbo].[taxi_types]
ADD CONSTRAINT [PK_taxi_types]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'price_ranges'
ALTER TABLE [dbo].[price_ranges]
ADD CONSTRAINT [PK_price_ranges]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'driver_percentanges'
ALTER TABLE [dbo].[driver_percentanges]
ADD CONSTRAINT [PK_driver_percentanges]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'sumary_numbers'
ALTER TABLE [dbo].[sumary_numbers]
ADD CONSTRAINT [PK_sumary_numbers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'day_incomes'
ALTER TABLE [dbo].[day_incomes]
ADD CONSTRAINT [PK_day_incomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'province_incomes'
ALTER TABLE [dbo].[province_incomes]
ADD CONSTRAINT [PK_province_incomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'subtraction_incomes'
ALTER TABLE [dbo].[subtraction_incomes]
ADD CONSTRAINT [PK_subtraction_incomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'repair_costs'
ALTER TABLE [dbo].[repair_costs]
ADD CONSTRAINT [PK_repair_costs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'groups'
ALTER TABLE [dbo].[groups]
ADD CONSTRAINT [PK_groups]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'trip_checks'
ALTER TABLE [dbo].[trip_checks]
ADD CONSTRAINT [PK_trip_checks]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'collections'
ALTER TABLE [dbo].[collections]
ADD CONSTRAINT [PK_collections]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'reason_no_incomes'
ALTER TABLE [dbo].[reason_no_incomes]
ADD CONSTRAINT [PK_reason_no_incomes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [PK_user_role]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [taxi_type_id] in table 'taxis'
ALTER TABLE [dbo].[taxis]
ADD CONSTRAINT [FK_taxi_typetaxi]
    FOREIGN KEY ([taxi_type_id])
    REFERENCES [dbo].[taxi_types]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typetaxi'
CREATE INDEX [IX_FK_taxi_typetaxi]
ON [dbo].[taxis]
    ([taxi_type_id]);
GO

-- Creating foreign key on [taxi_type_id] in table 'driver_percentanges'
ALTER TABLE [dbo].[driver_percentanges]
ADD CONSTRAINT [FK_taxi_typedriver_percentange]
    FOREIGN KEY ([taxi_type_id])
    REFERENCES [dbo].[taxi_types]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typedriver_percentange'
CREATE INDEX [IX_FK_taxi_typedriver_percentange]
ON [dbo].[driver_percentanges]
    ([taxi_type_id]);
GO

-- Creating foreign key on [price_range_id] in table 'driver_percentanges'
ALTER TABLE [dbo].[driver_percentanges]
ADD CONSTRAINT [FK_pricedriver_percentange]
    FOREIGN KEY ([price_range_id])
    REFERENCES [dbo].[price_ranges]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pricedriver_percentange'
CREATE INDEX [IX_FK_pricedriver_percentange]
ON [dbo].[driver_percentanges]
    ([price_range_id]);
GO

-- Creating foreign key on [taxi_id] in table 'sumary_numbers'
ALTER TABLE [dbo].[sumary_numbers]
ADD CONSTRAINT [FK_taxisumary_no]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisumary_no'
CREATE INDEX [IX_FK_taxisumary_no]
ON [dbo].[sumary_numbers]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'day_incomes'
ALTER TABLE [dbo].[day_incomes]
ADD CONSTRAINT [FK_taxiincome_per_day]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_per_day'
CREATE INDEX [IX_FK_taxiincome_per_day]
ON [dbo].[day_incomes]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'province_incomes'
ALTER TABLE [dbo].[province_incomes]
ADD CONSTRAINT [FK_taxiincome_provine]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_provine'
CREATE INDEX [IX_FK_taxiincome_provine]
ON [dbo].[province_incomes]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'subtraction_incomes'
ALTER TABLE [dbo].[subtraction_incomes]
ADD CONSTRAINT [FK_taxisubtraction_income]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisubtraction_income'
CREATE INDEX [IX_FK_taxisubtraction_income]
ON [dbo].[subtraction_incomes]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'repair_costs'
ALTER TABLE [dbo].[repair_costs]
ADD CONSTRAINT [FK_taxirepair_cost]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxirepair_cost'
CREATE INDEX [IX_FK_taxirepair_cost]
ON [dbo].[repair_costs]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'trip_checks'
ALTER TABLE [dbo].[trip_checks]
ADD CONSTRAINT [FK_taxicheck_cuoc]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxicheck_cuoc'
CREATE INDEX [IX_FK_taxicheck_cuoc]
ON [dbo].[trip_checks]
    ([taxi_id]);
GO

-- Creating foreign key on [group_id] in table 'collections'
ALTER TABLE [dbo].[collections]
ADD CONSTRAINT [FK_groupCollection]
    FOREIGN KEY ([group_id])
    REFERENCES [dbo].[groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_groupCollection'
CREATE INDEX [IX_FK_groupCollection]
ON [dbo].[collections]
    ([group_id]);
GO

-- Creating foreign key on [taxi_id] in table 'reason_no_incomes'
ALTER TABLE [dbo].[reason_no_incomes]
ADD CONSTRAINT [FK_taxireason]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxireason'
CREATE INDEX [IX_FK_taxireason]
ON [dbo].[reason_no_incomes]
    ([taxi_id]);
GO

-- Creating foreign key on [user_role_id] in table 'enties'
ALTER TABLE [dbo].[enties]
ADD CONSTRAINT [FK_user_roleentity]
    FOREIGN KEY ([user_role_id])
    REFERENCES [dbo].[user_role]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_roleentity'
CREATE INDEX [IX_FK_user_roleentity]
ON [dbo].[enties]
    ([user_role_id]);
GO

-- Creating foreign key on [leader_id] in table 'enties'
ALTER TABLE [dbo].[enties]
ADD CONSTRAINT [FK_entityentity]
    FOREIGN KEY ([leader_id])
    REFERENCES [dbo].[enties]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entityentity'
CREATE INDEX [IX_FK_entityentity]
ON [dbo].[enties]
    ([leader_id]);
GO

-- Creating foreign key on [groups_id] in table 'enties'
ALTER TABLE [dbo].[enties]
ADD CONSTRAINT [FK_entitygroup]
    FOREIGN KEY ([groups_id])
    REFERENCES [dbo].[groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entitygroup'
CREATE INDEX [IX_FK_entitygroup]
ON [dbo].[enties]
    ([groups_id]);
GO

-- Creating foreign key on [entity_id] in table 'taxis'
ALTER TABLE [dbo].[taxis]
ADD CONSTRAINT [FK_entitytaxi]
    FOREIGN KEY ([entity_id])
    REFERENCES [dbo].[enties]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_entitytaxi'
CREATE INDEX [IX_FK_entitytaxi]
ON [dbo].[taxis]
    ([entity_id]);
GO

-- Creating foreign key on [group_id] in table 'taxis'
ALTER TABLE [dbo].[taxis]
ADD CONSTRAINT [FK_grouptaxi]
    FOREIGN KEY ([group_id])
    REFERENCES [dbo].[groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_grouptaxi'
CREATE INDEX [IX_FK_grouptaxi]
ON [dbo].[taxis]
    ([group_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------