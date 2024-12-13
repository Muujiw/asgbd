-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 13 déc. 2024 à 15:42
-- Version du serveur :  5.7.23
-- Version de PHP :  7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `asg_database`
--

-- --------------------------------------------------------

--
-- Structure de la table `formations`
--

DROP TABLE IF EXISTS `formations`;
CREATE TABLE IF NOT EXISTS `formations` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nom_formation` varchar(100) NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL,
  `domaine_formation` varchar(100) NOT NULL,
  `formateur_id` bigint(20) UNSIGNED NOT NULL,
  `nombre_max_participants` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `formateur_id` (`formateur_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `inscriptions`
--

DROP TABLE IF EXISTS `inscriptions`;
CREATE TABLE IF NOT EXISTS `inscriptions` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) UNSIGNED NOT NULL,
  `formation_id` bigint(20) UNSIGNED NOT NULL,
  `date_inscription` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`user_id`,`formation_id`),
  KEY `formation_id` (`formation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `services`
--

DROP TABLE IF EXISTS `services`;
CREATE TABLE IF NOT EXISTS `services` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nom_service` varchar(100) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `code_postal` varchar(10) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `date_embauche` date NOT NULL,
  `domaine_assurance` varchar(100) NOT NULL,
  `service_id` bigint(20) UNSIGNED NOT NULL,
  `remember_token` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `role` text,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`),
  KEY `service_id` (`service_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `email_verified_at`, `password`, `adresse`, `code_postal`, `ville`, `date_embauche`, `domaine_assurance`, `service_id`, `remember_token`, `created_at`, `updated_at`, `role`) VALUES
(3, 'dfzf', 'feg@gmail.com', NULL, '$2a$11$Sel3pBqORLlSPluwAxRFa.ytgHVrkMKwvldEK9VksGLNN2FtJcPMK', 'rue de rue', '589', 'PAris 2', '2005-12-01', 'Assurance', 1, NULL, NULL, NULL, 'user'),
(2, 'John Doe', 'johndoe@example.com', '2024-11-29 13:57:37', '$2a$11$rtccSxAaDGUTe3FfeR6xye1pLGLH0TmeAuO35gR.e9yukb42SVjt2', '123 Rue Exemple', '75', 'Paris', '2024-11-01', 'Assurance Vie', 1, NULL, '2024-11-29 13:57:37', '2024-11-29 13:57:37', 'admin'),
(4, 'fde', 'gre@hmail.com', NULL, '$2a$11$RcnBOk.F5qkuQzm/A61oP.cVIjPCzOk7bGAwrpEDXzPuffLCOgyHu', '5 rue', '45', 'Deux', '2021-11-01', 'Assurance de', 1, NULL, NULL, NULL, 'user'),
(5, 'efzd', 'gelp@gmail.com', NULL, '$2a$11$ggeg3VdAr1CczjcE6hq/NeJrvHc8iQg4M/eIoLEGCedvViFEPhPr6', 'rue de rue', '789', 'Roubaix', '2024-05-02', 'Assurance vie', 1, NULL, NULL, NULL, 'user'),
(6, 'rge', 'teh@hmai.com', NULL, '$2a$11$iXKSDaYethujzhakA5jNRe5kuMpGXyBOWt4pgm1qViEcChUcPdetO', '5 rue de rue', '99220', 'Lille', '2021-02-05', 'Assurance vie', 1, NULL, NULL, NULL, 'user'),
(7, 'tfrjrtfj', 'trjh@hmail.co', NULL, '$2a$11$yUVO4PT6xI04kNdiH8M3T.ecO23d9U8V7EYqW/7iQBeNeyQ7.VJnW', '58 rtt', '5546', 'Bordeaux', '2001-09-02', 'Assurance vie', 1, NULL, NULL, NULL, 'user');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
