CREATE TABLE [dbo].[vehicle] (
    [regNo]                INT          NOT NULL,
    [number_plate]         VARCHAR (10) NULL,
    [fuel_type]            VARCHAR (10) NULL,
    [license_renew_date]   DATE         NULL,
    [insurance_renew_date] DATE         NULL,
    [model]                VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([regNo] ASC)
);