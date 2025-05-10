-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Mag 09, 2025 alle 18:34
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

--
-- Dump dei dati per la tabella `budget_mensili`
--

INSERT INTO `budget_mensili` (`mese`, `anno`, `importo`) VALUES
(1, 2025, 1500.00),
(2, 2025, 1500.00),
(3, 2025, 1500.00),
(4, 2025, 1500.00),
(5, 2025, 1500.00);

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
-- Dump dei dati per la tabella `gestore_spese`
--

INSERT INTO `gestore_spese` (`id`, `categoria`, `importo`, `data`) VALUES
(1, 'Uscite', 200.00, '2025-01-01'),
(2, 'Trasporti', 50.00, '2025-01-03'),
(3, 'Bollette', 250.00, '2025-01-09'),
(4, 'Visite', 200.00, '2025-01-14'),
(5, 'Farmacia', 20.00, '2025-01-17'),
(6, 'Mutuo', 500.00, '2025-01-18'),
(7, 'Bolli', 50.00, '2025-01-19'),
(8, 'Assicurazioni', 200.00, '2025-01-22'),
(9, 'Varie', 15.00, '2025-01-30'),
(10, 'Uscite', 200.00, '2025-02-01'),
(11, 'Trasporti', 50.00, '2025-02-03'),
(12, 'Bollette', 250.00, '2025-02-09'),
(13, 'Visite', 350.00, '2025-02-14'),
(14, 'Farmacia', 20.00, '2025-02-17'),
(15, 'Mutuo', 500.00, '2025-02-18'),
(16, 'Bolli', 50.00, '2025-02-19'),
(17, 'Assicurazioni', 200.00, '2025-02-22'),
(18, 'Varie', 35.00, '2025-02-28'),
(19, 'Uscite', 200.00, '2025-03-01'),
(20, 'Trasporti', 50.00, '2025-03-03'),
(21, 'Bollette', 250.00, '2025-03-09'),
(22, 'Visite', 280.00, '2025-03-14'),
(23, 'Farmacia', 20.00, '2025-03-17'),
(24, 'Mutuo', 500.00, '2025-03-18'),
(25, 'Bolli', 50.00, '2025-03-19'),
(26, 'Assicurazioni', 200.00, '2025-03-22'),
(27, 'Varie', 15.00, '2025-03-30'),
(28, 'Uscite', 200.00, '2025-04-01'),
(29, 'Trasporti', 50.00, '2025-04-03'),
(30, 'Bollette', 250.00, '2025-04-09'),
(31, 'Visite', 280.00, '2025-04-14'),
(32, 'Farmacia', 250.00, '2025-04-17'),
(33, 'Mutuo', 500.00, '2025-04-18'),
(34, 'Bolli', 50.00, '2025-04-19'),
(35, 'Assicurazioni', 200.00, '2025-04-22'),
(36, 'Varie', 50.00, '2025-04-30'),
(37, 'Uscite', 50.00, '2025-05-01');

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
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
