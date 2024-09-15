-- Disable all foreign key constraints
EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';

-- Delete all data from tables
DELETE FROM [dbo].[daily_vehicle_records];
DELETE FROM [dbo].[vehicle];
DELETE FROM [dbo].[fuel];

-- Re-enable all foreign key constraints
EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL';
