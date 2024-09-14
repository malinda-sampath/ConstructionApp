CREATE TABLE [dbo].[fuel] (
    [Id]         INT             NOT NULL,
    [fuel_type]  NCHAR (10)      NULL,
    [fuel_price] DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);