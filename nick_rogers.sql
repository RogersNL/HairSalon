-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Jul 13, 2018 at 11:14 PM
-- Server version: 5.6.34-log
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nick_rogers`
--
CREATE DATABASE IF NOT EXISTS `nick_rogers` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `nick_rogers`;

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Stylist_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`Id`, `Name`, `Stylist_Id`) VALUES
(1, 'Luffy', 1),
(2, 'Zoro', 1),
(3, 'Sasuke', 3),
(5, 'Nico Robin', 1),
(6, 'Nami', 1),
(7, 'Brook', 1),
(8, 'Sanji', 1),
(9, 'Chopper', 1),
(10, 'Frankie', 1),
(11, 'Sakura', 3),
(12, 'Kakashi', 3),
(13, 'All Might', 5),
(14, 'Gon Freecs', 4),
(15, 'Killua', 4),
(16, 'Todoroki', 5),
(17, 'Deku', 5),
(18, 'Iida', 5),
(19, 'Bakugo', 5),
(20, 'Kurapika', 4),
(21, 'Natsu Dragon', 7);

-- --------------------------------------------------------

--
-- Table structure for table `stylists`
--

CREATE TABLE `stylists` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stylists`
--

INSERT INTO `stylists` (`Id`, `Name`) VALUES
(1, 'One Piece'),
(3, 'Naruto'),
(4, 'HunterXHunter'),
(5, 'My Hero Academia'),
(7, 'Fairy Tail');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `stylists`
--
ALTER TABLE `stylists`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `stylists`
--
ALTER TABLE `stylists`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
