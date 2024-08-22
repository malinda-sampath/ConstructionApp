-- Disable all foreign key constraints
EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';

-- Delete all data from tables
DELETE FROM [dbo].[daily_vehical_records];
DELETE FROM [dbo].[vehical];
DELETE FROM [dbo].[fuel];

-- Re-enable all foreign key constraints
EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL';
