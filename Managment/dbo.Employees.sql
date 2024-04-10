CREATE TABLE [dbo].[Employees] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [IdNumber]    NVARCHAR (MAX) NOT NULL ,
    [FirstName]   NVARCHAR (MAX) NOT NULL ,
    [LastName]    NVARCHAR (MAX) NOT NULL ,
    [Status]      INT            NOT NULL  ,
    [Gender]      INT            NOT NULL ,
    [Address]     NVARCHAR (MAX) NOT NULL ,
    [DateOfStart] DATETIME2 (7)  NOT NULL ,
    [DateOfBirth] DATETIME2 (7)  NOT NULL ,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);

