
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/26/2014 20:12:08
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
    ALTER TABLE [dbo].[taxis1] DROP CONSTRAINT [FK_taxi_typetaxi];
GO
IF OBJECT_ID(N'[dbo].[FK_taxi_typedriver_percentange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[driver_percentange] DROP CONSTRAINT [FK_taxi_typedriver_percentange];
GO
IF OBJECT_ID(N'[dbo].[FK_pricedriver_percentange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[driver_percentange] DROP CONSTRAINT [FK_pricedriver_percentange];
GO
IF OBJECT_ID(N'[dbo].[FK_user_rolechecker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_rolechecker];
GO
IF OBJECT_ID(N'[dbo].[FK_taxidriver]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_driver] DROP CONSTRAINT [FK_taxidriver];
GO
IF OBJECT_ID(N'[dbo].[FK_taxisumary_no]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sumary_number] DROP CONSTRAINT [FK_taxisumary_no];
GO
IF OBJECT_ID(N'[dbo].[FK_taxiincome_per_day]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[day_income] DROP CONSTRAINT [FK_taxiincome_per_day];
GO
IF OBJECT_ID(N'[dbo].[FK_taxiincome_provine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[province_income] DROP CONSTRAINT [FK_taxiincome_provine];
GO
IF OBJECT_ID(N'[dbo].[FK_taxisubtraction_income]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[subtraction_income] DROP CONSTRAINT [FK_taxisubtraction_income];
GO
IF OBJECT_ID(N'[dbo].[FK_taxirepair_cost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[repair_cost] DROP CONSTRAINT [FK_taxirepair_cost];
GO
IF OBJECT_ID(N'[dbo].[FK_user_role_leader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_role_leader];
GO
IF OBJECT_ID(N'[dbo].[FK_principalchecker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_checker] DROP CONSTRAINT [FK_principalchecker];
GO
IF OBJECT_ID(N'[dbo].[FK_taxicheck_cuoc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[check_cuoc] DROP CONSTRAINT [FK_taxicheck_cuoc];
GO
IF OBJECT_ID(N'[dbo].[FK_groupleader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[groups] DROP CONSTRAINT [FK_groupleader];
GO
IF OBJECT_ID(N'[dbo].[FK_checkertaxi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[taxis1] DROP CONSTRAINT [FK_checkertaxi];
GO
IF OBJECT_ID(N'[dbo].[FK_groupCollection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[collections] DROP CONSTRAINT [FK_groupCollection];
GO
IF OBJECT_ID(N'[dbo].[FK_user_rolemoderator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_rolemoderator];
GO
IF OBJECT_ID(N'[dbo].[FK_user_roleadministrator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_roleadministrator];
GO
IF OBJECT_ID(N'[dbo].[FK_checker_inherits_entity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_checker] DROP CONSTRAINT [FK_checker_inherits_entity];
GO
IF OBJECT_ID(N'[dbo].[FK_driver_inherits_entity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_driver] DROP CONSTRAINT [FK_driver_inherits_entity];
GO
IF OBJECT_ID(N'[dbo].[FK_moderator_inherits_entity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_moderator] DROP CONSTRAINT [FK_moderator_inherits_entity];
GO
IF OBJECT_ID(N'[dbo].[FK_administrator_inherits_entity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[entities_administrator] DROP CONSTRAINT [FK_administrator_inherits_entity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[entities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[entities];
GO
IF OBJECT_ID(N'[dbo].[user_role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user_role];
GO
IF OBJECT_ID(N'[dbo].[taxis1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[taxis1];
GO
IF OBJECT_ID(N'[dbo].[taxi_type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[taxi_type];
GO
IF OBJECT_ID(N'[dbo].[price_range]', 'U') IS NOT NULL
    DROP TABLE [dbo].[price_range];
GO
IF OBJECT_ID(N'[dbo].[driver_percentange]', 'U') IS NOT NULL
    DROP TABLE [dbo].[driver_percentange];
GO
IF OBJECT_ID(N'[dbo].[sumary_number]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sumary_number];
GO
IF OBJECT_ID(N'[dbo].[day_income]', 'U') IS NOT NULL
    DROP TABLE [dbo].[day_income];
GO
IF OBJECT_ID(N'[dbo].[province_income]', 'U') IS NOT NULL
    DROP TABLE [dbo].[province_income];
GO
IF OBJECT_ID(N'[dbo].[subtraction_income]', 'U') IS NOT NULL
    DROP TABLE [dbo].[subtraction_income];
GO
IF OBJECT_ID(N'[dbo].[repair_cost]', 'U') IS NOT NULL
    DROP TABLE [dbo].[repair_cost];
GO
IF OBJECT_ID(N'[dbo].[leaders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[leaders];
GO
IF OBJECT_ID(N'[dbo].[groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[groups];
GO
IF OBJECT_ID(N'[dbo].[check_cuoc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[check_cuoc];
GO
IF OBJECT_ID(N'[dbo].[collections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[collections];
GO
IF OBJECT_ID(N'[dbo].[entities_checker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[entities_checker];
GO
IF OBJECT_ID(N'[dbo].[entities_driver]', 'U') IS NOT NULL
    DROP TABLE [dbo].[entities_driver];
GO
IF OBJECT_ID(N'[dbo].[entities_moderator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[entities_moderator];
GO
IF OBJECT_ID(N'[dbo].[entities_administrator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[entities_administrator];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'entity'
CREATE TABLE [dbo].[entity] (
    [id] int IDENTITY(1,1) NOT NULL,
    [firstname] nvarchar(max)  NOT NULL,
    [lastname] nvarchar(max)  NOT NULL,
    [birthday] datetime  NULL,
    [gender] bit  NOT NULL,
    [email] nvarchar(max)  NULL,
    [businessphone] nvarchar(max)  NOT NULL,
    [date_join] datetime  NULL
);
GO

-- Creating table 'user_role'
CREATE TABLE [dbo].[user_role] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [permission] nvarchar(max)  NOT NULL,
    [checker_id] int  NOT NULL,
    [leader_id] int  NOT NULL,
    [moderator_id] int  NOT NULL,
    [administrator_id] int  NOT NULL
);
GO

-- Creating table 'taxi'
CREATE TABLE [dbo].[taxi] (
    [id] int IDENTITY(1,1) NOT NULL,
    [number_car] nvarchar(max)  NOT NULL,
    [date_join] datetime  NULL,
    [model] nvarchar(max)  NULL,
    [taxi_type_id] smallint  NOT NULL,
    [checkers_id] int  NOT NULL
);
GO

-- Creating table 'taxi_type'
CREATE TABLE [dbo].[taxi_type] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [symbol] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'price_range'
CREATE TABLE [dbo].[price_range] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [start] int  NOT NULL,
    [end] int  NOT NULL
);
GO

-- Creating table 'driver_percentange'
CREATE TABLE [dbo].[driver_percentange] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [percent] int  NOT NULL,
    [taxi_type_id] smallint  NOT NULL,
    [price_range_id] smallint  NOT NULL
);
GO

-- Creating table 'sumary_number'
CREATE TABLE [dbo].[sumary_number] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [total] int  NOT NULL,
    [km] int  NOT NULL,
    [cuoc] nvarchar(max)  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'day_income'
CREATE TABLE [dbo].[day_income] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [sumary_money] int  NOT NULL,
    [driver_income] int  NOT NULL,
    [company_income] int  NOT NULL,
    [tl_income] int  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'province_income'
CREATE TABLE [dbo].[province_income] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [cuoc_income] int  NOT NULL,
    [over_income] int  NOT NULL,
    [price_income] int  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'subtraction_income'
CREATE TABLE [dbo].[subtraction_income] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [taximet] int  NOT NULL,
    [cuopco] nvarchar(max)  NOT NULL,
    [another] nvarchar(max)  NOT NULL,
    [thuxe] nvarchar(max)  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'repair_cost'
CREATE TABLE [dbo].[repair_cost] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [created] datetime  NOT NULL,
    [date_in] datetime  NOT NULL,
    [date_out] datetime  NOT NULL,
    [taxi_id] int  NULL
);
GO

-- Creating table 'leader'
CREATE TABLE [dbo].[leader] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'group'
CREATE TABLE [dbo].[group] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL,
    [leader_id] int  NOT NULL
);
GO

-- Creating table 'check_cuoc'
CREATE TABLE [dbo].[check_cuoc] (
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
    [sum_money] int  NOT NULL,
    [driver] nvarchar(max)  NOT NULL,
    [sum_km] int  NOT NULL,
    [sum_cuoc] int  NOT NULL,
    [created] datetime  NOT NULL,
    [group_id] int  NOT NULL
);
GO

-- Creating table 'entity_checker'
CREATE TABLE [dbo].[entity_checker] (
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [id] int  NOT NULL,
    [leader_id] int  NOT NULL
);
GO

-- Creating table 'entity_driver'
CREATE TABLE [dbo].[entity_driver] (
    [id] int  NOT NULL,
    [taxi_id] int  NOT NULL
);
GO

-- Creating table 'entity_moderator'
CREATE TABLE [dbo].[entity_moderator] (
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [id] int  NOT NULL
);
GO

-- Creating table 'entity_administrator'
CREATE TABLE [dbo].[entity_administrator] (
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'entity'
ALTER TABLE [dbo].[entity]
ADD CONSTRAINT [PK_entity]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [PK_user_role]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'taxi'
ALTER TABLE [dbo].[taxi]
ADD CONSTRAINT [PK_taxi]
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

-- Creating primary key on [id] in table 'day_income'
ALTER TABLE [dbo].[day_income]
ADD CONSTRAINT [PK_day_income]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'province_income'
ALTER TABLE [dbo].[province_income]
ADD CONSTRAINT [PK_province_income]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'subtraction_income'
ALTER TABLE [dbo].[subtraction_income]
ADD CONSTRAINT [PK_subtraction_income]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'repair_cost'
ALTER TABLE [dbo].[repair_cost]
ADD CONSTRAINT [PK_repair_cost]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'leader'
ALTER TABLE [dbo].[leader]
ADD CONSTRAINT [PK_leader]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'group'
ALTER TABLE [dbo].[group]
ADD CONSTRAINT [PK_group]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'check_cuoc'
ALTER TABLE [dbo].[check_cuoc]
ADD CONSTRAINT [PK_check_cuoc]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'collections'
ALTER TABLE [dbo].[collections]
ADD CONSTRAINT [PK_collections]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'entity_checker'
ALTER TABLE [dbo].[entity_checker]
ADD CONSTRAINT [PK_entity_checker]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'entity_driver'
ALTER TABLE [dbo].[entity_driver]
ADD CONSTRAINT [PK_entity_driver]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'entity_moderator'
ALTER TABLE [dbo].[entity_moderator]
ADD CONSTRAINT [PK_entity_moderator]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'entity_administrator'
ALTER TABLE [dbo].[entity_administrator]
ADD CONSTRAINT [PK_entity_administrator]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [taxi_type_id] in table 'taxi'
ALTER TABLE [dbo].[taxi]
ADD CONSTRAINT [FK_taxi_typetaxi]
    FOREIGN KEY ([taxi_type_id])
    REFERENCES [dbo].[taxi_type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxi_typetaxi'
CREATE INDEX [IX_FK_taxi_typetaxi]
ON [dbo].[taxi]
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

-- Creating foreign key on [price_range_id] in table 'driver_percentange'
ALTER TABLE [dbo].[driver_percentange]
ADD CONSTRAINT [FK_pricedriver_percentange]
    FOREIGN KEY ([price_range_id])
    REFERENCES [dbo].[price_range]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pricedriver_percentange'
CREATE INDEX [IX_FK_pricedriver_percentange]
ON [dbo].[driver_percentange]
    ([price_range_id]);
GO

-- Creating foreign key on [checker_id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [FK_user_rolechecker]
    FOREIGN KEY ([checker_id])
    REFERENCES [dbo].[entity_checker]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_rolechecker'
CREATE INDEX [IX_FK_user_rolechecker]
ON [dbo].[user_role]
    ([checker_id]);
GO

-- Creating foreign key on [taxi_id] in table 'entity_driver'
ALTER TABLE [dbo].[entity_driver]
ADD CONSTRAINT [FK_taxidriver]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxi]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxidriver'
CREATE INDEX [IX_FK_taxidriver]
ON [dbo].[entity_driver]
    ([taxi_id]);
GO

-- Creating foreign key on [taxi_id] in table 'sumary_number'
ALTER TABLE [dbo].[sumary_number]
ADD CONSTRAINT [FK_taxisumary_no]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxi]
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
    REFERENCES [dbo].[taxi]
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
    REFERENCES [dbo].[taxi]
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
    REFERENCES [dbo].[taxi]
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
    REFERENCES [dbo].[taxi]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxirepair_cost'
CREATE INDEX [IX_FK_taxirepair_cost]
ON [dbo].[repair_cost]
    ([taxi_id]);
GO

-- Creating foreign key on [leader_id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [FK_user_role_leader]
    FOREIGN KEY ([leader_id])
    REFERENCES [dbo].[leader]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_role_leader'
CREATE INDEX [IX_FK_user_role_leader]
ON [dbo].[user_role]
    ([leader_id]);
GO

-- Creating foreign key on [leader_id] in table 'entity_checker'
ALTER TABLE [dbo].[entity_checker]
ADD CONSTRAINT [FK_principalchecker]
    FOREIGN KEY ([leader_id])
    REFERENCES [dbo].[leader]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_principalchecker'
CREATE INDEX [IX_FK_principalchecker]
ON [dbo].[entity_checker]
    ([leader_id]);
GO

-- Creating foreign key on [taxi_id] in table 'check_cuoc'
ALTER TABLE [dbo].[check_cuoc]
ADD CONSTRAINT [FK_taxicheck_cuoc]
    FOREIGN KEY ([taxi_id])
    REFERENCES [dbo].[taxi]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_taxicheck_cuoc'
CREATE INDEX [IX_FK_taxicheck_cuoc]
ON [dbo].[check_cuoc]
    ([taxi_id]);
GO

-- Creating foreign key on [leader_id] in table 'group'
ALTER TABLE [dbo].[group]
ADD CONSTRAINT [FK_groupleader]
    FOREIGN KEY ([leader_id])
    REFERENCES [dbo].[leader]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_groupleader'
CREATE INDEX [IX_FK_groupleader]
ON [dbo].[group]
    ([leader_id]);
GO

-- Creating foreign key on [checkers_id] in table 'taxi'
ALTER TABLE [dbo].[taxi]
ADD CONSTRAINT [FK_checkertaxi]
    FOREIGN KEY ([checkers_id])
    REFERENCES [dbo].[entity_checker]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_checkertaxi'
CREATE INDEX [IX_FK_checkertaxi]
ON [dbo].[taxi]
    ([checkers_id]);
GO

-- Creating foreign key on [group_id] in table 'collections'
ALTER TABLE [dbo].[collections]
ADD CONSTRAINT [FK_groupCollection]
    FOREIGN KEY ([group_id])
    REFERENCES [dbo].[group]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_groupCollection'
CREATE INDEX [IX_FK_groupCollection]
ON [dbo].[collections]
    ([group_id]);
GO

-- Creating foreign key on [moderator_id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [FK_user_rolemoderator]
    FOREIGN KEY ([moderator_id])
    REFERENCES [dbo].[entity_moderator]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_rolemoderator'
CREATE INDEX [IX_FK_user_rolemoderator]
ON [dbo].[user_role]
    ([moderator_id]);
GO

-- Creating foreign key on [administrator_id] in table 'user_role'
ALTER TABLE [dbo].[user_role]
ADD CONSTRAINT [FK_user_roleadministrator]
    FOREIGN KEY ([administrator_id])
    REFERENCES [dbo].[entity_administrator]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_user_roleadministrator'
CREATE INDEX [IX_FK_user_roleadministrator]
ON [dbo].[user_role]
    ([administrator_id]);
GO

-- Creating foreign key on [id] in table 'entity_checker'
ALTER TABLE [dbo].[entity_checker]
ADD CONSTRAINT [FK_checker_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entity]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'entity_driver'
ALTER TABLE [dbo].[entity_driver]
ADD CONSTRAINT [FK_driver_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entity]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'entity_moderator'
ALTER TABLE [dbo].[entity_moderator]
ADD CONSTRAINT [FK_moderator_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entity]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'entity_administrator'
ALTER TABLE [dbo].[entity_administrator]
ADD CONSTRAINT [FK_administrator_inherits_entity]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[entity]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------