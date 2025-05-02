-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Mag 02, 2025 alle 08:21
-- Versione del server: 8.2.0
-- Versione PHP: 8.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `guardian_of_the_money`
--
CREATE DATABASE IF NOT EXISTS `guardian_of_the_money` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `guardian_of_the_money`;

-- --------------------------------------------------------

--
-- Struttura della tabella `budget_mensili`
--

CREATE TABLE `budget_mensili` (
  `mese` int NOT NULL,
  `anno` int NOT NULL,
  `importo` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `gestore_spese`
--

CREATE TABLE `gestore_spese` (
  `id` int NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `importo` decimal(10,2) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `budget_mensili`
--
ALTER TABLE `budget_mensili`
  ADD UNIQUE KEY `mese` (`mese`,`anno`);

--
-- Indici per le tabelle `gestore_spese`
--
ALTER TABLE `gestore_spese`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `gestore_spese`
--
ALTER TABLE `gestore_spese`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
