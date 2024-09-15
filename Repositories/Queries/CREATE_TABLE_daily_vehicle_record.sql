CREATE TABLE [dbo].[daily_vehicle_records] (
    [Id]              INT             NOT NULL,
    [date]            DATE            NOT NULL,
    [regNo]           INT             NOT NULL,
    [last_filling]    DECIMAL (18, 2) NULL,
    [filling_millage] DECIMAL (18)    NULL,
    [start_millage]   DECIMAL (18)    NULL,
    [route]           VARCHAR (100)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);