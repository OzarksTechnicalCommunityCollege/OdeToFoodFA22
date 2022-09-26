USE [OdeToFood]
GO

/****** Object: Table [dbo].[Restaurants] Script Date: 9/26/2022 4:09:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Restaurants] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (80)  NOT NULL,
    [Location] NVARCHAR (255) NOT NULL,
    [Cuisine]  INT            NOT NULL
);
