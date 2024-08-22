INSERT INTO [dbo].[fuel] (Id, fuel_type, fuel_price)
VALUES 
(1, N'Petrol', 120.50),
(2, N'Diesel', 105.75),
(3, N'CNG', 70.25),
(4, N'Petrol', 123.40),
(5, N'Diesel', 108.90);

INSERT INTO [dbo].[vehical] (regNo, number_plate, fuel_type, license_renew_date, insurance_renew_date, model)
VALUES 
(1001, 'ABC123', 'Petrol', '2025-01-15', '2025-07-20', 'Toyota Corolla'),
(1002, 'XYZ789', 'Diesel', '2024-12-10', '2025-06-18', 'Ford F-150'),
(1003, 'LMN456', 'CNG', '2025-03-25', '2025-09-30', 'Honda Civic'),
(1004, 'PQR321', 'Petrol', '2025-05-10', '2025-11-15', 'Tesla Model 3'),
(1005, 'DEF654', 'Diesel', '2024-11-20', '2025-05-25', 'Chevrolet Tahoe');

INSERT INTO [dbo].[daily_vehical_records] (Id, date, regNo, last_filling, filling_millage, start_millage, route)
VALUES 
(1, '2024-08-20', 1001, 40.50, 10188, 10200, 'Route A to B'),
(2, '2024-08-20', 1002, 60.75, 20435, 20450, 'Route C to D'),
(3, '2024-08-21', 1003, 35.25, 15220, 15230, 'Route E to F'),
(4, '2024-08-21', 1004, 50.00, 11385, 11400, 'Route G to H'),
(5, '2024-08-22', 1005, 55.30, 17875, 17890, 'Route I to J');
