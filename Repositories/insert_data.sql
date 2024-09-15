INSERT INTO [dbo].[fuel] (Id, fuel_type, fuel_price)
VALUES 
(1, N'Petrol', 332.00),
(2, N'Diesel', 307.00);

INSERT INTO [dbo].[vehicle] (regNo, number_plate, fuel_type, license_renew_date, insurance_renew_date, model)
VALUES 
(9995, 'KQ-9995', 'Diesel', '2024-12-12', '2024-12-13', 'Mitshubishi Montero'),
(7979, 'LB-7979', 'Diesel', '2025-03-15', '2025-03-16', 'Isuzu ELF'),
(1931, 'DAH-1931', 'Diesel', '2024-10-20', '2024-10-21', 'TATA Yodha Smart'),
(6751, 'WS-6751', 'Petrol', '2025-09-03', '2025-09-04', 'BAJAJ Discover');


INSERT INTO [dbo].[daily_vehicle_records] (Id, date, regNo, last_filling, filling_millage, start_millage, route)
VALUES 
(1, '2024-08-23', 7979, 45.00, 10200, 10250, 'Route A to C'),
(2, '2024-08-23', 1931, 62.30, 20450, 20470, 'Route D to E');

