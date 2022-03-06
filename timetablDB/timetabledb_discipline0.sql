-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: timetabledb
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `discipline`
--

DROP TABLE IF EXISTS `discipline`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discipline` (
  `id_discipline` int NOT NULL AUTO_INCREMENT,
  `name_discipline` varchar(100) NOT NULL,
  PRIMARY KEY (`id_discipline`),
  UNIQUE KEY `idlesson_UNIQUE` (`id_discipline`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discipline`
--

LOCK TABLES `discipline` WRITE;
/*!40000 ALTER TABLE `discipline` DISABLE KEYS */;
INSERT INTO `discipline` VALUES (1,'Надежность программного обеспечения'),(2,'Проектирование человеко-машинного интерфейса'),(3,'Сетевые операционные системы'),(4,'Командная разработка программных систем'),(5,'Управление программными проектами'),(6,'Математические модели в расчетах на ЭВМ'),(7,'Правовые основы железнодорожного транспорта'),(8,'Производство и ремонт подвижного состава.2'),(9,'Эксплуатация и техническое обслуживание подвижного состава.1'),(10,'Тормозные системы вагонов'),(11,'Производство и ремонт подвижного состава.1'),(12,'Теория тяги поездов'),(13,'Системы автоматизации производства и ремонта вагонов'),(14,'Организация обеспечения безопасности движения и автоматические тормоза'),(15,'Эксплуатация и техническое обслуживание подвижного состава.2'),(16,'Технология, механизация и автоматизация работ по техническому обслуживанию железнодорожного пути'),(17,'Управление организационно-технологической надежностью транспортного строительства'),(18,'Системы автоматизированного проектирования транспортных магистралей'),(19,'Правила технической эксплуатации железных дорог'),(20,'Строительство и реконструкция железных дорог'),(21,'Организация, планирование и управление строительством мостов и тоннелей '),(22,'Содержание и реконструкция мостов и тоннелей');
/*!40000 ALTER TABLE `discipline` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-26  1:45:24