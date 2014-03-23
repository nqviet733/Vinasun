
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2014 21:02:04
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'entities'
CREATE TABLE [dbo].[entities] (
    [id] int IDENTITY(1,1) NOT NULL,
    [firstname] nvarchar(max)  NOT NULL,
    [lastname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'user_role'
CREATE TABLE [dbo].[user_role] (
    [id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'taxis1'
CREATE TABLE [dbo].[taxis1] (
    [id] int IDENTITY(1,1) NOT NULL,
    [taxi_type_id] int  NOT NULL
);
GO

-- Creating table 'taxi_type'
CREATE TABLE [dbo].[taxi_type] (
    [id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'price_range'
CREATE TABLE [dbo].[price_range] (
    [id] int IDENTITY(1,1) NOT NULL,
    [start] nvarchar(max)  NOT NULL,
    [end] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'driver_percentange'
CREATE TABLE [dbo].[driver_percentange] (
    [id] int IDENTITY(1,1) NOT NULL,
    [percent] nvarchar(max)  NOT NULL,
    [taxi_type_id] int  NOT NULL,
    [price_id] int  NOT NULL
);
GO

-- Creating table 'sumary_number'
CREATE TABLE [dbo].[sumary_number] (
    [id] int IDENTITY(1,1) NOT NULL,
    [created] nvarchar(max)  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'day_income'
CREATE TABLE [dbo].[day_income] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'province_income'
CREATE TABLE [dbo].[province_income] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'subtraction_income'
CREATE TABLE [dbo].[subtraction_income] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'repair_cost'
CREATE TABLE [dbo].[repair_cost] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'leaders'
CREATE TABLE [dbo].[leaders] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [user_role_id] int  NOT NULL
);
GO

-- Creating table 'groups'
CREATE TABLE [dbo].[groups] (
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'taxi_relation_checker'
CREATE TABLE [dbo].[taxi_relation_checker] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NOT NULL,
    [checker_id] int  NOT NULL
);
GO

-- Creating table 'group_relation_leader'
CREATE TABLE [dbo].[group_relation_leader] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date_start] nvarchar(max)  NOT NULL,
    [date_end] nvarchar(max)  NOT NULL,
    [group_id] int  NOT NULL,
    [leader_id] int  NOT NULL
);
GO

-- Creating table 'check_cuoc'
CREATE TABLE [dbo].[check_cuoc] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'entities_checker'
CREATE TABLE [dbo].[entities_checker] (
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [id] int  NOT NULL,
    [user_role_id] int  NOT NULL
);
GO

-- Creating table 'entities_driver'
CREATE TABLE [dbo].[entities_driver] (
    [id] int  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'principalchecker'
CREATE TABLE [dbo].[principalchecker] (
    [principal_id] int  NOT NULL,
    [checkers_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'entities'
ALTER TABLE [dbo].[entities]
ADD CONSTRAINT [PK_entities]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [PK_user_role]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'taxis1'
ALTER TABLE [dbo].[taxis1]
ADD CONSTRAINT [PK_taxis1]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'taxi_type'
ALTER TABLE [dbo].[taxi_type]
ADD CONSTRAINT [PK_taxi_type]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'price_range'
ALTER TABLE [dbo].[price_range]
ADD CONSTRAINT [PK_price_range]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'driver_percentange'
ALTER TABLE [dbo].[driver_percentange]
ADD CONSTRAINT [PK_driver_percentange]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'sumary_number'
ALTER TABLE [dbo].[sumary_number]
ADD CONSTRAINT [PK_sumary_number]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'day_income'
ALTER TABLE [dbo].[day_income]
ADD CONSTRAINT [PK_day_income]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'province_income'
ALTER TABLE [dbo].[province_income]
ADD CONSTRAINT [PK_province_income]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'subtraction_income'
ALTER TABLE [dbo].[subtraction_income]
ADD CONSTRAINT [PK_subtraction_income]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'repair_cost'
ALTER TABLE [dbo].[repair_cost]
ADD CONSTRAINT [PK_repair_cost]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'leaders'
ALTER TABLE [dbo].[leaders]
ADD CONSTRAINT [PK_leaders]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'groups'
ALTER TABLE [dbo].[groups]
ADD CONSTRAINT [PK_groups]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'taxi_relation_checker'
ALTER TABLE [dbo].[taxi_relation_checker]
ADD CONSTRAINT [PK_taxi_relation_checker]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'group_relation_leader'
ALTER TABLE [dbo].[group_relation_leader]
ADD CONSTRAINT [PK_group_relation_leader]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'check_cuoc'
ALTER TABLE [dbo].[check_cuoc]
ADD CONSTRAINT [PK_check_cuoc]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'entities_checker'
ALTER TABLE [dbo].[entities_checker]
ADD CONSTRAINT [PK_entities_checker]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'entities_driver'
ALTER TABLE [dbo].[entities_driver]
ADD CONSTRAINT [PK_entities_driver]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [principal_id], [checkers_id] in table 'principalchecker'
ALTER TABLE [dbo].[principalchecker]
ADD CONSTRAINT [PK_principalchecker]
    PRIMARY KEY CLUSTERED ([principal_id], [checkers_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [taxi_type_id] in table 'taxis1'
ALTER TABLE [dbo].[taxis1]
ADD CONSTRAINT [FK_taxi_typetaxi]
    FOREIGN KEY ([taxi_type_id])
    REFERENCES [dbo].[taxi_type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typetaxi'
CREATE INDEX [IX_FK_taxi_typetaxi]
ON [dbo].[taxis1]
    ([taxi_type_id]);
GO

-- Creating foreign key on [taxi_type_id] in table 'driver_percentange'
ALTER TABLE [dbo].[driver_percentange]
ADD CONSTRAINT [FK_taxi_typedriver_percentange]
    FOREIGN KEY ([taxi_type_id])
    REFERENCES [dbo].[taxi_type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typedriver_percentange'
CREATE INDEX [IX_FK_taxi_typedriver_percentange]
ON [dbo].[driver_percentange]
    ([taxi_type_id]);
GO

-- Creating foreign key on [price_id] in table 'driver_percentange'
ALTER TABLE [dbo].[driver_percentange]
ADD CONSTRAINT [FK_pricedriver_percentange]
    FOREIGN KEY ([price_id])
    REFERENCES [dbo].[price_range]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pricedriver_percentange'
CREATE INDEX [IX_FK_pricedriver_percentange]
ON [dbo].[driver_percentange]
    ([price_id]);
GO

-- Creating foreign key on [user_role_id] in table 'entities_checker'
ALTER TABLE [dbo].[entities_checker]
ADD CONSTRAINT [FK_user_rolechecker]
    FOREIGN KEY ([user_role_id])
    REFERENCES [dbo].[user_role]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_rolechecker'
CREATE INDEX [IX_FK_user_rolechecker]
ON [dbo].[entities_checker]
    ([user_role_id]);
GO

-- Creating foreign key on [taxi_id] in table 'entities_driver'
ALTER TABLE [dbo].[entities_driver]
ADD CONSTRAINT [FK_taxidriver]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxidriver'
CREATE INDEX [IX_FK_taxidriver]
ON [dbo].[entities_driver]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'sumary_number'
ALTER TABLE [dbo].[sumary_number]
ADD CONSTRAINT [FK_taxisumary_no]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisumary_no'
CREATE INDEX [IX_FK_taxisumary_no]
ON [dbo].[sumary_number]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'day_income'
ALTER TABLE [dbo].[day_income]
ADD CONSTRAINT [FK_taxiincome_per_day]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_per_day'
CREATE INDEX [IX_FK_taxiincome_per_day]
ON [dbo].[day_income]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'province_income'
ALTER TABLE [dbo].[province_income]
ADD CONSTRAINT [FK_taxiincome_provine]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxiincome_provine'
CREATE INDEX [IX_FK_taxiincome_provine]
ON [dbo].[province_income]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'subtraction_income'
ALTER TABLE [dbo].[subtraction_income]
ADD CONSTRAINT [FK_taxisubtraction_income]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxisubtraction_income'
CREATE INDEX [IX_FK_taxisubtraction_income]
ON [dbo].[subtraction_income]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'repair_cost'
ALTER TABLE [dbo].[repair_cost]
ADD CONSTRAINT [FK_taxirepair_cost]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxirepair_cost'
CREATE INDEX [IX_FK_taxirepair_cost]
ON [dbo].[repair_cost]
    ([taxi_id]);
GO

-- Creating foreign key on [user_role_id] in table 'leaders'
ALTER TABLE [dbo].[leaders]
ADD CONSTRAINT [FK_user_rolepricipal]
    FOREIGN KEY ([user_role_id])
    REFERENCES [dbo].[user_role]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_rolepricipal'
CREATE INDEX [IX_FK_user_rolepricipal]
ON [dbo].[leaders]
    ([user_role_id]);
GO

-- Creating foreign key on [principal_id] in table 'principalchecker'
ALTER TABLE [dbo].[principalchecker]
ADD CONSTRAINT [FK_principalchecker_principal]
    FOREIGN KEY ([principal_id])
    REFERENCES [dbo].[leaders]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [checkers_id] in table 'principalchecker'
ALTER TABLE [dbo].[principalchecker]
ADD CONSTRAINT [FK_principalchecker_checker]
    FOREIGN KEY ([checkers_id])
    REFERENCES [dbo].[entities_checker]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_principalchecker_checker'
CREATE INDEX [IX_FK_principalchecker_checker]
ON [dbo].[principalchecker]
    ([checkers_id]);
GO

-- Creating foreign key on [group_id] in table 'group_relation_leader'
ALTER TABLE [dbo].[group_relation_leader]
ADD CONSTRAINT [FK_groupgroup_relation_leader]
    FOREIGN KEY ([group_id])
    REFERENCES [dbo].[groups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_groupgroup_relation_leader'
CREATE INDEX [IX_FK_groupgroup_relation_leader]
ON [dbo].[group_relation_leader]
    ([group_id]);
GO

-- Creating foreign key on [leader_id] in table 'group_relation_leader'
ALTER TABLE [dbo].[group_relation_leader]
ADD CONSTRAINT [FK_leadergroup_relation_leader]
    FOREIGN KEY ([leader_id])
    REFERENCES [dbo].[leaders]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_leadergroup_relation_leader'
CREATE INDEX [IX_FK_leadergroup_relation_leader]
ON [dbo].[group_relation_leader]
    ([leader_id]);
GO

-- Creating foreign key on [taxi_id] in table 'taxi_relation_checker'
ALTER TABLE [dbo].[taxi_relation_checker]
ADD CONSTRAINT [FK_taxitaxi_relation_checker]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxitaxi_relation_checker'
CREATE INDEX [IX_FK_taxitaxi_relation_checker]
ON [dbo].[taxi_relation_checker]
    ([taxi_id]);
GO

-- Creating foreign key on [checker_id] in table 'taxi_relation_checker'
ALTER TABLE [dbo].[taxi_relation_checker]
ADD CONSTRAINT [FK_checkertaxi_relation_checker]
    FOREIGN KEY ([checker_id])
    REFERENCES [dbo].[entities_checker]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_checkertaxi_relation_checker'
CREATE INDEX [IX_FK_checkertaxi_relation_checker]
ON [dbo].[taxi_relation_checker]
    ([checker_id]);
GO

-- Creating foreign key on [taxi_id] in table 'check_cuoc'
ALTER TABLE [dbo].[check_cuoc]
ADD CONSTRAINT [FK_taxicheck_cuoc]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxis1]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxicheck_cuoc'
CREATE INDEX [IX_FK_taxicheck_cuoc]
ON [dbo].[check_cuoc]
    ([taxi_id]);
GO

-- Creating foreign key on [id] in table 'entities_checker'
ALTER TABLE [dbo].[entities_checker]
ADD CONSTRAINT [FK_checker_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entities]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'entities_driver'
ALTER TABLE [dbo].[entities_driver]
ADD CONSTRAINT [FK_driver_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entities]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------