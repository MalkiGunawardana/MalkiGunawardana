-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 02:22 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `CategoryId` int(10) NOT NULL,
  `Label` varchar(20) NOT NULL,
  `Price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`CategoryId`, `Label`, `Price`) VALUES
(1, 'Single', 10000),
(2, 'Double', 15000),
(3, 'Family', 5000),
(4, 'Suit', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `GuestId` varchar(20) NOT NULL,
  `GuestFirstName` varchar(10) NOT NULL,
  `GuestLastName` varchar(10) NOT NULL,
  `GuestPhone` varchar(15) NOT NULL,
  `GuestCity` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES
('001', 'Aruni', 'Perera', '09878976', 'Kurunagala'),
('002', 'Nirmalee', 'Yapa', '8907896', 'Kandy'),
('003', 'Kaveesha', 'Ravihari', '787654443', 'Matara');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `ReserveId` int(10) NOT NULL,
  `GuestId` varchar(20) NOT NULL,
  `RoomNo` varchar(10) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`ReserveId`, `GuestId`, `RoomNo`, `DateIn`, `DateOut`) VALUES
(5, '001', '679', '2023-11-14', '2023-11-22'),
(6, '002', '675', '2023-11-16', '2023-11-24');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `RoomId` varchar(10) NOT NULL,
  `RoomType` int(5) NOT NULL,
  `RoomPhone` varchar(15) NOT NULL,
  `RoomStatus` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES
('233', 4, '1155', 'Free'),
('675', 1, '6789', 'Busy'),
('67699', 1, '8733', 'Busy'),
('679', 1, '9855', 'Busy'),
('720', 3, '8442', 'Free');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Username`, `Password`) VALUES
(0, 'Mal', 'Mal'),
(1, 'Admin', 'Admin'),
(2, 'Mal', 'Mal');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`GuestId`),
  ADD UNIQUE KEY `GuestId_4` (`GuestId`),
  ADD KEY `GuestId` (`GuestId`),
  ADD KEY `GuestId_2` (`GuestId`),
  ADD KEY `GuestId_3` (`GuestId`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ReserveId`),
  ADD UNIQUE KEY `GuestId` (`GuestId`),
  ADD UNIQUE KEY `RoomNo` (`RoomNo`),
  ADD KEY `RoomNo_2` (`RoomNo`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`RoomId`),
  ADD KEY `RoomId` (`RoomId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ReserveId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`RoomNo`) REFERENCES `room` (`RoomId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`GuestId`) REFERENCES `guest` (`GuestId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
