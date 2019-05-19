-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-05-2019 a las 01:56:14
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ventasdirectas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `NO` int(11) NOT NULL,
  `USUARIO` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `ACCION` text COLLATE utf8_unicode_ci NOT NULL,
  `IP` text COLLATE utf8_unicode_ci NOT NULL,
  `FECHA_HORA` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`NO`, `USUARIO`, `ACCION`, `IP`, `FECHA_HORA`) VALUES
(1, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:12:18 a. m.'),
(2, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:15:09 a. m.'),
(3, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:15:21 a. m.'),
(4, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:22:53 a. m.'),
(5, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:23:04 a. m.'),
(6, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:24:12 a. m.'),
(7, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:25:15 a. m.'),
(8, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:26:16 a. m.'),
(9, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:26:17 a. m.'),
(10, 'Randy', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:26:24 a. m.'),
(11, 'Randy', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:26:26 a. m.'),
(12, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:29:04 a. m.'),
(13, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:29:33 a. m.'),
(14, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:42:14 a. m.'),
(15, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:42:40 a. m.'),
(16, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:57:43 a. m.'),
(17, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:57:53 a. m.'),
(18, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:58:16 a. m.'),
(19, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:58:30 a. m.'),
(20, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:59:33 a. m.'),
(21, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 12:59:53 a. m.'),
(22, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:01:34 a. m.'),
(23, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:01:51 a. m.'),
(24, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:13:23 a. m.'),
(25, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:15:03 a. m.'),
(26, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:15:37 a. m.'),
(27, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:16:00 a. m.'),
(28, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:16:15 a. m.'),
(29, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:29:49 a. m.'),
(30, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:30:44 a. m.'),
(31, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:34:15 a. m.'),
(32, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 1:34:23 a. m.'),
(33, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:43:59 p. m.'),
(34, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:44:21 p. m.'),
(35, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:45:10 p. m.'),
(36, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:45:34 p. m.'),
(37, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:46:14 p. m.'),
(38, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:46:32 p. m.'),
(39, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:48:07 p. m.'),
(40, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:48:23 p. m.'),
(41, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:51:55 p. m.'),
(42, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:52:14 p. m.'),
(43, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:53:39 p. m.'),
(44, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:53:49 p. m.'),
(45, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:54:33 p. m.'),
(46, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:55:52 p. m.'),
(47, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:59:06 p. m.'),
(48, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '18/05/2019 11:59:38 p. m.'),
(49, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:10:18 a. m.'),
(50, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:10:28 a. m.'),
(51, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:11:26 a. m.'),
(52, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:12:38 a. m.'),
(53, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:14:16 a. m.'),
(54, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:20:19 a. m.'),
(55, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:54:44 a. m.'),
(56, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:55:18 a. m.'),
(57, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:58:53 a. m.'),
(58, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 12:59:06 a. m.'),
(59, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:00:25 a. m.'),
(60, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:01:39 a. m.'),
(61, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:02:13 a. m.'),
(62, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:03:49 a. m.'),
(63, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:05:01 a. m.'),
(64, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:05:21 a. m.'),
(65, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:05:56 a. m.'),
(66, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:06:28 a. m.'),
(67, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:06:39 a. m.'),
(68, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:07:34 a. m.'),
(69, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:08:10 a. m.'),
(70, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:17:38 a. m.'),
(71, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:20:16 a. m.'),
(72, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:20:52 a. m.'),
(73, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:21:10 a. m.'),
(74, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:21:28 a. m.'),
(75, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:21:39 a. m.'),
(76, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:22:05 a. m.'),
(77, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:22:32 a. m.'),
(78, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:19:38 a. m.'),
(79, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:19:45 a. m.'),
(80, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:21:48 a. m.'),
(81, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:21:54 a. m.'),
(82, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:23:43 a. m.'),
(83, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:23:49 a. m.'),
(84, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:26:04 a. m.'),
(85, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:26:30 a. m.'),
(86, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:28:34 a. m.'),
(87, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:28:42 a. m.'),
(88, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:30:21 a. m.'),
(89, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:31:04 a. m.'),
(90, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:49:21 a. m.'),
(91, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:02:56 a. m.'),
(92, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:03:14 a. m.'),
(93, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:04:47 a. m.'),
(94, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:08:45 a. m.'),
(95, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:11:52 a. m.'),
(96, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:16:46 a. m.'),
(97, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:17:32 a. m.'),
(98, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:18:27 a. m.'),
(99, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:22:32 a. m.'),
(100, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:22:53 a. m.'),
(101, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:23:07 a. m.'),
(102, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:23:49 a. m.'),
(103, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:24:04 a. m.'),
(104, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:30:53 a. m.'),
(105, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:33:45 a. m.'),
(106, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:41:51 a. m.'),
(107, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:47:08 a. m.'),
(108, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:48:06 a. m.'),
(109, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:55:33 a. m.'),
(110, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:57:32 a. m.'),
(111, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:17:46 p. m.'),
(112, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:17:53 p. m.'),
(113, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:19:04 p. m.'),
(114, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:19:52 p. m.'),
(115, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:26:42 p. m.'),
(116, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:26:56 p. m.'),
(117, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:29:19 p. m.'),
(118, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:29:34 p. m.'),
(119, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:30:34 p. m.'),
(120, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:31:50 p. m.'),
(121, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:32:16 p. m.'),
(122, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:37:19 p. m.'),
(123, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 1:39:16 p. m.'),
(124, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:02:37 p. m.'),
(125, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:21:21 p. m.'),
(126, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:21:31 p. m.'),
(127, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:21:57 p. m.'),
(128, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:22:59 p. m.'),
(129, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:23:27 p. m.'),
(130, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:24:15 p. m.'),
(131, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:24:52 p. m.'),
(132, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:27:16 p. m.'),
(133, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:27:44 p. m.'),
(134, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:29:26 p. m.'),
(135, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:30:18 p. m.'),
(136, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:31:24 p. m.'),
(137, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:52:42 p. m.'),
(138, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:53:29 p. m.'),
(139, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:56:45 p. m.'),
(140, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:56:52 p. m.'),
(141, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:57:17 p. m.'),
(142, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:57:24 p. m.'),
(143, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:59:03 p. m.'),
(144, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:59:16 p. m.'),
(145, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 2:59:46 p. m.'),
(146, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:00:00 p. m.'),
(147, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:06:34 p. m.'),
(148, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:07:03 p. m.'),
(149, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:07:30 p. m.'),
(150, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:07:55 p. m.'),
(151, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:09:00 p. m.'),
(152, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:09:11 p. m.'),
(153, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:09:27 p. m.'),
(154, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:10:16 p. m.'),
(155, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:11:05 p. m.'),
(156, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:12:18 p. m.'),
(157, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 3:16:08 p. m.'),
(158, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:01:41 p. m.'),
(159, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:02:23 p. m.'),
(160, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:03:12 p. m.'),
(161, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:04:22 p. m.'),
(162, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:04:59 p. m.'),
(163, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:14:09 p. m.'),
(164, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:15:14 p. m.'),
(165, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:15:52 p. m.'),
(166, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:16:20 p. m.'),
(167, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:16:52 p. m.'),
(168, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:17:30 p. m.'),
(169, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:17:48 p. m.'),
(170, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:23:32 p. m.'),
(171, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:25:07 p. m.'),
(172, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:26:29 p. m.'),
(173, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:27:44 p. m.'),
(174, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:29:07 p. m.'),
(175, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:29:59 p. m.'),
(176, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:30:54 p. m.'),
(177, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:33:49 p. m.'),
(178, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:35:10 p. m.'),
(179, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:41:24 p. m.'),
(180, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:42:09 p. m.'),
(181, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:49:26 p. m.'),
(182, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:49:43 p. m.'),
(183, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:50:14 p. m.'),
(184, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:50:23 p. m.'),
(185, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:52:17 p. m.'),
(186, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:52:27 p. m.'),
(187, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:54:26 p. m.'),
(188, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 4:54:45 p. m.'),
(189, 'Gustavo', 'LOG IN', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 5:37:55 p. m.'),
(190, 'Gustavo', 'LOG OUT', '\nfe80::548:68:63ba:dc35%11\nfe80::bd74:d5b6:1520:c945%10\n192.168.56.1\n192.168.1.5', '19/05/2019 5:38:12 p. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `codigo` int(5) NOT NULL,
  `sucursal` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` text COLLATE utf8_unicode_ci NOT NULL,
  `encargado` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `estado` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `bodega`
--

INSERT INTO `bodega` (`codigo`, `sucursal`, `telefono`, `direccion`, `encargado`, `estado`) VALUES
(1, 'Central', '23156854', '3-25, zona 1', 'Gabriel Montes', 'Activa'),
(2, 'Sucursal Norte', '231564554', '21-96, zona 6 ', 'Jose Blanco', 'Activa'),
(3, 'Sucursal Sur', '21356845', '35-85, zona 3', 'Ruben Bachez', 'Activa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `codigo` int(5) NOT NULL,
  `nombre_completo` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` text COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Nit` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`codigo`, `nombre_completo`, `telefono`, `direccion`, `email`, `Nit`) VALUES
(1, 'Randy Choc', '231658685', '3-56, zona 3', 'randy@psa.com', '8951-5'),
(2, 'Juan Gamez', '21356488', '3-23, zona 10', 'juan@psa.com', '5616548-5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras`
--

CREATE TABLE `compras` (
  `codigo` int(5) NOT NULL,
  `sucursal` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `proveedor` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `compras`
--

INSERT INTO `compras` (`codigo`, `sucursal`, `proveedor`, `fecha`) VALUES
(1, 'Sucursal Norte', 'Brocs', '2019-05-08'),
(2, 'Sucursal Sur', 'Manhattan', '2019-05-30'),
(3, 'Central', 'Steren', '2019-05-08'),
(5, 'Sucursal Norte', 'Brocs', '2019-05-20');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas_salidas`
--

CREATE TABLE `entradas_salidas` (
  `codigo` int(11) NOT NULL,
  `Producto` int(11) NOT NULL,
  `Bodega` int(11) NOT NULL,
  `fecha` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Concepto` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Documento` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `entradas_salidas`
--

INSERT INTO `entradas_salidas` (`codigo`, `Producto`, `Bodega`, `fecha`, `Cantidad`, `Concepto`, `Documento`) VALUES
(1, 1, 1, '2019-05-09', 100, '', '3 Central Steren'),
(2, 2, 2, '2019-05-11', 100, '', '2 Sucursal Sur Manhattan'),
(3, 2, 3, '2019-05-04', 10, 'Ventas', '2'),
(4, 2, 1, '2019-05-19', 15, 'Compras', '3'),
(5, 1, 2, '2019-05-19', 100, 'Compras', '2'),
(6, 1, 2, '2019-05-19', 10, 'Ventas', '2'),
(7, 1, 3, '2019-05-15', 10, 'Ventas', '4');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `existencias`
--

CREATE TABLE `existencias` (
  `codigo` int(11) NOT NULL,
  `codigo_producto` int(11) NOT NULL,
  `codigo_bodega` int(11) NOT NULL,
  `Cantidad` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `existencias`
--

INSERT INTO `existencias` (`codigo`, `codigo_producto`, `codigo_bodega`, `Cantidad`) VALUES
(1, 1, 2, 50),
(2, 2, 1, 22),
(3, 1, 3, 20),
(5, 2, 2, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `codigo` int(5) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `presentacion` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `precio` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`codigo`, `nombre`, `presentacion`, `precio`) VALUES
(1, 'Teclado Bluetooth', '14 Pulgadas', 100),
(2, 'Mouse Pad', '10 Pulgadas', 60),
(3, 'Cargador Samsung', '9mAh, Color blanco', 75);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `codigo` int(5) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` text COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `nit` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`codigo`, `nombre`, `telefono`, `direccion`, `email`, `nit`) VALUES
(1, 'Manhattan', '68458645', '3-98, zona 9', 'Manhattan@tech.com', '684531-5'),
(2, 'Brocs', '845316516', '23-96, zon 14', 'brocs@tech.com', '894651-7'),
(3, 'Steren', '222665458', '32-85, zona 10', 'steren@tech.com', '2351655-6');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursales`
--

CREATE TABLE `sucursales` (
  `codigo` int(5) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` text COLLATE utf8_unicode_ci NOT NULL,
  `encargado` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `estado` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `sucursales`
--

INSERT INTO `sucursales` (`codigo`, `nombre`, `telefono`, `direccion`, `encargado`, `estado`) VALUES
(1, 'Central', '2132516', '3-26, zona 1', 'Edgar Casasola', 'Activa'),
(2, 'Sucursal Norte', '2315686451', '3-46, zona 6', 'Gustavo perez', 'Activa'),
(3, 'Sucursal Sur', '2315648', '22-98, zona 3', 'Ligia Abril', 'Activa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Usuario` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Password` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Nivel` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Usuario`, `Password`, `Nivel`) VALUES
('Gustavo', 'b4288d9c0ec0a1841b3b3728321e7088', 0),
('Randy', '2823f4797102ce1a1aec05359cc16dd9', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `codigo` int(5) NOT NULL,
  `sucursal` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `cod_cliente` int(5) NOT NULL,
  `fecha` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`codigo`, `sucursal`, `cod_cliente`, `fecha`) VALUES
(1, 'Central', 1, '2019-05-09'),
(2, 'Central', 2, '2019-05-07'),
(4, 'Sucursal Norte', 1, '2019-05-04'),
(5, 'Sucursal Sur', 2, '2019-05-04');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`NO`);

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `sucursal` (`sucursal`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `sucursal` (`sucursal`),
  ADD KEY `cod_proveedor` (`proveedor`);

--
-- Indices de la tabla `entradas_salidas`
--
ALTER TABLE `entradas_salidas`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `codigo_producto` (`codigo_producto`),
  ADD KEY `cod_bodega` (`codigo_bodega`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `sucursales`
--
ALTER TABLE `sucursales`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Usuario`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `sucursal` (`sucursal`),
  ADD KEY `cod_cliente` (`cod_cliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `NO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=191;

--
-- AUTO_INCREMENT de la tabla `bodega`
--
ALTER TABLE `bodega`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `compras`
--
ALTER TABLE `compras`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `entradas_salidas`
--
ALTER TABLE `entradas_salidas`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `existencias`
--
ALTER TABLE `existencias`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `sucursales`
--
ALTER TABLE `sucursales`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;