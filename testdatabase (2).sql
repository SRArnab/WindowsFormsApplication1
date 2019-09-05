-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 02, 2019 at 03:45 AM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testdatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE `equipments` (
  `itemname` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `damaged` int(100) NOT NULL,
  `date` date NOT NULL DEFAULT '0000-00-00',
  `roomno` varchar(100) NOT NULL,
  `facultyid` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `equipments`
--

INSERT INTO `equipments` (`itemname`, `type`, `quantity`, `damaged`, `date`, `roomno`, `facultyid`) VALUES
('Resistors', '1k-ohm', 7, 0, '2019-09-03', 'EL-11', '4545-45646');

-- --------------------------------------------------------

--
-- Table structure for table `tools`
--

CREATE TABLE `tools` (
  `id` int(100) NOT NULL,
  `itemname` varchar(100) NOT NULL,
  `itemtype` varchar(200) NOT NULL,
  `quantity` int(100) NOT NULL,
  `damaged` int(100) NOT NULL,
  `Remaining` int(11) AS (quantity-damaged) VIRTUAL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tools`
--

INSERT INTO `tools` (`id`, `itemname`, `itemtype`, `quantity`, `damaged`, `Remaining`) VALUES
(1, 'Resistors', '10-ohm', 500, 50, 450),
(2, 'Capacitors', '1-C', 500, 28, 472),
(3, 'Diodes', 'p-n', 80, 0, 80),
(4, 'LED', 'light', 80, 0, 80),
(5, 'Jumper', 'wire', 15, 0, 15),
(6, 'Resistors', '1k-ohm', 800, 20, 780),
(7, 'Resistors', '2k-ohm', 800, 20, 780),
(8, 'Diodes', 'Zenner', 700, 0, 700);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tools`
--
ALTER TABLE `tools`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tools`
--
ALTER TABLE `tools`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
