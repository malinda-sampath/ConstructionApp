-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 15, 2024 at 07:29 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `construction_app`
--

-- --------------------------------------------------------

--
-- Table structure for table `daily_vehicle_records`
--

CREATE TABLE `daily_vehicle_records` (
  `Id` int(11) NOT NULL,
  `date` date NOT NULL,
  `regNo` int(11) NOT NULL,
  `last_filling` decimal(18,2) DEFAULT NULL,
  `filling_millage` decimal(18,0) DEFAULT NULL,
  `start_millage` decimal(18,0) DEFAULT NULL,
  `route` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `daily_vehicle_records`
--

INSERT INTO `daily_vehicle_records` (`Id`, `date`, `regNo`, `last_filling`, `filling_millage`, `start_millage`, `route`) VALUES
(1, '2024-08-23', 7979, 45.00, 10200, 10250, 'Route A to C'),
(2, '2024-08-23', 1931, 62.30, 20450, 20470, 'Route D to E');

-- --------------------------------------------------------

--
-- Table structure for table `fuel`
--

CREATE TABLE `fuel` (
  `Id` int(11) NOT NULL,
  `fuel_type` char(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `fuel_price` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fuel`
--

INSERT INTO `fuel` (`Id`, `fuel_type`, `fuel_price`) VALUES
(1, 'Petrol', 332.00),
(2, 'Diesel', 307.00);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `date_registered` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

CREATE TABLE `vehicle` (
  `regNo` int(11) NOT NULL,
  `number_plate` varchar(10) DEFAULT NULL,
  `fuel_type` varchar(10) DEFAULT NULL,
  `license_renew_date` date DEFAULT NULL,
  `insurance_renew_date` date DEFAULT NULL,
  `model` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`regNo`, `number_plate`, `fuel_type`, `license_renew_date`, `insurance_renew_date`, `model`) VALUES
(1931, 'DAH-1931', 'Diesel', '2024-10-20', '2024-10-21', 'TATA Yodha Smart'),
(6751, 'WS-6751', 'Petrol', '2025-09-03', '2025-09-04', 'BAJAJ Discover'),
(7979, 'LB-7979', 'Diesel', '2025-03-15', '2025-03-16', 'Isuzu ELF'),
(9995, 'KQ-9995', 'Diesel', '2024-12-12', '2024-12-13', 'Mitsubishi Montero');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `daily_vehicle_records`
--
ALTER TABLE `daily_vehicle_records`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `fuel`
--
ALTER TABLE `fuel`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`regNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
