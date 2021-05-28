USE master
GO

-- Creating TeamworkSystemAdo database
IF EXISTS
(
    SELECT [name]
    FROM sys.databases
    WHERE [name] = N'TeamworkSystemAdo'
)
    DROP DATABASE TeamworkSystemAdo
GO

CREATE DATABASE TeamworkSystemAdo
GO

USE TeamworkSystemAdo
GO

-- Creating table Users
IF OBJECT_ID('[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users]
GO

CREATE TABLE [dbo].[Users]
(
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [Surname] NVARCHAR(50) NOT NULL,
	[Profession] NVARCHAR(50) NULL,
    [Specialization] NVARCHAR(50) NULL
)
GO

-- Creating table Friends
IF OBJECT_ID('[dbo].[Friends]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Friends]
GO

CREATE TABLE [dbo].[Friends]
(
    [FirstId] INT NOT NULL,
    [SecondId] INT NOT NULL,
    CONSTRAINT [PK_Friends] PRIMARY KEY ([FirstId], [SecondId]),
    CONSTRAINT [FK_Friends_FirstId] FOREIGN KEY ([FirstId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Friends_SecondId] FOREIGN KEY ([SecondId]) REFERENCES [dbo].[Users] ([Id])
)
GO

CREATE TRIGGER TR_UsersFriendsDeleteTrigger
ON [Users] FOR DELETE
AS
BEGIN

    DECLARE @DeletedId INT
    SELECT @DeletedId = Id FROM DELETED

    DELETE FROM Friends WHERE [SecondId] = @DeletedId

END
GO

-- Creating table Teams
IF OBJECT_ID('[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams]
GO

CREATE TABLE [dbo].[Teams]
(
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [LeaderId] INT NULL,
    [Specialization] NVARCHAR(50) NULL,
    [About] NTEXT NULL,
    CONSTRAINT [FK_Teams_LeaderId] FOREIGN KEY ([LeaderId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE SET NULL
)
GO

-- Creating table Projects
IF OBJECT_ID('[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects]
GO

CREATE TABLE [dbo].[Projects]
(
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [TeamId] INT NOT NULL,
    [Title] NVARCHAR(50) NOT NULL,
    [Type] NVARCHAR(50) NULL,
    [Url] NVARCHAR(50) NULL,
    [Description] NTEXT NULL,
    CONSTRAINT [FK_Projects_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Teams] ([Id]) ON DELETE CASCADE
)
GO

-- Creating table Tickets
IF OBJECT_ID('[dbo].[Tickets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tickets]
GO

CREATE TABLE [dbo].[Tickets]
(
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [ProjectId] INT NOT NULL,
    -- [AuthorId] INT NULL,
    [ExecutorId] INT NULL,
    [Title] NVARCHAR(50) NOT NULL,
    [Type] NVARCHAR(50) NULL,
    [Description] NTEXT NOT NULL,
    [Status] NVARCHAR(50) NOT NULL,
    [Priority] NVARCHAR(50) NOT NULL,
    [CreationTime] DATETIME DEFAULT(GETDATE()) NOT NULL,
    [Deadline] DATETIME NULL,
    CONSTRAINT [FK_Tickets_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_ExecutorId] FOREIGN KEY ([ExecutorId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE SET NULL
)
GO

-- Creating table Ratings
IF OBJECT_ID('[dbo].[Ratings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ratings]
GO

CREATE TABLE [dbo].[Ratings]
(
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [FromId] INT NOT NULL,
    [ToId] INT NOT NULL,
    [Social] INT NOT NULL,
    [Skills] INT NOT NULL,
    [Responsibility] INT NULL,
    [Punctuality] INT NULL,
    [Comment] NTEXT NULL,
    CONSTRAINT [AK_Ratings_FromId_ToId] UNIQUE ([FromId], [ToId]), 
    CONSTRAINT [FK_Ratings_FromId] FOREIGN KEY ([FromId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Ratings_ToId] FOREIGN KEY ([ToId]) REFERENCES [dbo].[Users] ([Id])
)
GO

CREATE TRIGGER TR_UsersRatingsDeleteTrigger
ON [Users] FOR DELETE
AS
BEGIN

    DECLARE @DeletedId INT
    SELECT @DeletedId = Id FROM DELETED

    DELETE FROM Ratings WHERE [ToId] = @DeletedId

END
GO

-- Creating table TeamsMembers
IF OBJECT_ID('[dbo].[TeamsMembers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamsMembers]
GO

CREATE TABLE [dbo].[TeamsMembers]
(
    [TeamId] INT NOT NULL,
    [UserId] INT NOT NULL,
    CONSTRAINT [PK_TeamsMembers_TeamId_UserId] PRIMARY KEY ([TeamId], [UserId]),
    CONSTRAINT [FK_TeamsMembers_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Teams] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TeamsMembers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
)
GO

-- Creating generic stored procedures

-- Creating stored procedure SP_GetAllFromTable
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GetAllFromTable'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GetAllFromTable
GO

CREATE PROCEDURE dbo.SP_GetAllFromTable
    @TableName NVARCHAR(50)
AS
BEGIN

    DECLARE @ActualTable NVARCHAR(50)
    SELECT @ActualTable = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @TableName

    DECLARE @Query AS NVARCHAR(MAX)
    SELECT @Query = 'SELECT * FROM ' + @ActualTable

    EXEC(@Query)

END
GO

-- Creating stored procedure SP_GetByIdFromTable
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GetByIdFromTable'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GetByIdFromTable
GO

CREATE PROCEDURE dbo.SP_GetByIdFromTable
    @TableName NVARCHAR(50),
    @Id INT
AS
BEGIN

    DECLARE @ActualTable NVARCHAR(50)
    SELECT @ActualTable = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @TableName

    DECLARE @Query AS NVARCHAR(MAX)
    SELECT @Query = 'SELECT * FROM ' + @ActualTable + ' WHERE [Id] = ' + STR(@Id)

    EXEC(@Query)

END
GO

-- Creating stored procedure SP_GenerateInsertQuery
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GenerateInsertQuery'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GenerateInsertQuery
GO

CREATE PROCEDURE dbo.SP_GenerateInsertQuery
    @TableName NVARCHAR(50),
    @ColumnsString NVARCHAR(MAX),
    @PropertiesString NVARCHAR(MAX)
AS
BEGIN

    DECLARE @ActualTable NVARCHAR(50)
    SELECT @ActualTable = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @TableName

    DECLARE @Query NVARCHAR(MAX)
    SELECT @Query = 'INSERT INTO ' + @ActualTable + ' (' + @ColumnsString + ') VALUES (' + @PropertiesString + ')'

    SELECT @Query

END
GO

-- Creating stored procedure SP_GenerateUpdateQuery
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GenerateUpdateQuery'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GenerateUpdateQuery
GO

CREATE PROCEDURE dbo.SP_GenerateUpdateQuery
    @TableName NVARCHAR(50),
    @ColumnsString NVARCHAR(MAX),
    @Id INT
AS
BEGIN

    DECLARE @ActualTable NVARCHAR(50)
    SELECT @ActualTable = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @TableName

    DECLARE @Query NVARCHAR(MAX)
    SELECT @Query = 'UPDATE ' + @ActualTable + ' SET ' + @ColumnsString + ' WHERE [Id] = ' + STR(@Id)

    SELECT @Query

END
GO

-- Creating stored procedure SP_DeleteByIdFromTable
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_DeleteByIdFromTable'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_DeleteByIdFromTable
GO

CREATE PROCEDURE dbo.SP_DeleteByIdFromTable
    @TableName NVARCHAR(50),
    @Id INT
AS
BEGIN

    DECLARE @ActualTable NVARCHAR(50)
    SELECT @ActualTable = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @TableName

    DECLARE @Query AS NVARCHAR(MAX)
    SELECT @Query = 'DELETE FROM ' + @ActualTable + ' WHERE [Id] = ' + STR(@Id)

    EXEC(@Query)

END
GO

IF EXISTS 
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GetUsers'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GetUsers
GO

CREATE PROCEDURE dbo.SP_GetUsers
AS
    SELECT * FROM [dbo].[Users]
GO

IF EXISTS 
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_GetUserById'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_GetUserById
GO

CREATE PROCEDURE dbo.SP_GetUserById
    @Id INT
AS
    SELECT * FROM [Users] WHERE [Users].[Id] = @Id
GO

IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_InsertUser'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.SP_InsertUser
GO

CREATE PROCEDURE dbo.SP_InsertUser
    @Name NVARCHAR(50),
    @Surname NVARCHAR(50),
    @Profession NVARCHAR(50),
    @Specialization NVARCHAR(50)
AS
    INSERT INTO [Users] VALUES(@Name, @Surname, @Profession, @Specialization)
GO

IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_UpdateUser'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_UpdateUser
GO

CREATE PROCEDURE dbo.SP_UpdateUser
    @Id INT,
    @Name NVARCHAR(50),
    @Surname NVARCHAR(50),
    @Profession NVARCHAR(50),
    @Specialization NVARCHAR(50)
AS
    UPDATE [dbo].[Users]
    SET
        [Name] = @Name,
        [Surname] = @Surname,
        [Profession] = @Profession,
        [Specialization] = @Specialization
    WHERE [Users].[Id] = @Id
GO

IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'SP_DeleteUser'
        AND ROUTINE_TYPE = N'PROCEDURE'
)
    DROP PROCEDURE dbo.SP_DeleteUser
GO

CREATE PROCEDURE dbo.SP_DeleteUser
    @Id INT
AS
    DELETE FROM [Users] WHERE [Users].[Id] = @Id
GO
