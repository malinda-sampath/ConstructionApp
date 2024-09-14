INSERT INTO [dbo].[fuel] (Id, fuel_type, fuel_price)
VALUES 
(1, N'Petrol', 120.50),
(2, N'Diesel', 105.75),
(3, N'CNG', 70.25),
(4, N'Petrol', 123.40),
(5, N'Diesel', 108.90);

INSERT INTO [dbo].[vehicle] (regNo, number_plate, fuel_type, license_renew_date, insurance_renew_date, model)
VALUES 
(1234, 'ABC-1234', 'Petrol', '2024-12-31', '2024-11-30', 'Toyota Corolla'),
(5678, 'XYZ-5678', 'Diesel', '2025-03-15', '2024-12-31', 'Ford Ranger'),
(9101, 'LMN-9101', 'CNG', '2024-10-20', '2024-09-30', 'Honda Civic'),
(1122, 'PQR-1122', 'Petrol', '2024-07-25', '2024-06-30', 'Chevrolet Malibu'),
(3344, 'STU-3344', 'Diesel', '2025-01-10', '2024-11-15', 'Nissan Frontier');


INSERT INTO [dbo].[daily_vehicle_records] (Id, date, regNo, last_filling, filling_millage, start_millage, route)
VALUES 
(1, '2024-08-23', 1234, 45.00, 10200, 10250, 'Route A to C'),
(2, '2024-08-23', 5678, 62.30, 20450, 20470, 'Route D to E'),
(3, '2024-08-24', 9101, 38.75, 15230, 15260, 'Route F to G'),
(4, '2024-08-24', 1122, 52.10, 11400, 11430, 'Route H to I'),
(5, '2024-08-25', 3344, 57.45, 17890, 17920, 'Route J to K');

