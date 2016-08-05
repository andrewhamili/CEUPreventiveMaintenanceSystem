-- MySQL dump 10.13  Distrib 5.6.24, for Win32 (x86)
--
-- Host: localhost    Database: ceumiadprevmaintenance
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `equipmentlist`
--

DROP TABLE IF EXISTS `equipmentlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipmentlist` (
  `equipmentnumber` text,
  `equipmentname` text,
  `equipmentmodel` text,
  `equipmentserial` text,
  `equipmentlocation` text,
  `equipmentdatepurchase` date DEFAULT NULL,
  `equipmentprice` decimal(10,2) DEFAULT NULL,
  `equipmentbranch` text,
  `dateadded` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipmentlist`
--

LOCK TABLES `equipmentlist` WRITE;
/*!40000 ALTER TABLE `equipmentlist` DISABLE KEYS */;
INSERT INTO `equipmentlist` VALUES ('1','LAPTOP','Asus Vivobook X202E-ct010h','20090000032847','TLTD Main','2013-03-22',21000.00,'Manila','2016-07-02'),('2','LAPTOP','Asus Vivobook X202E-ct010h','20090000032848','TLTD Main','2013-03-22',2100.00,'Manila','2016-07-02');
/*!40000 ALTER TABLE `equipmentlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `systemlog`
--

DROP TABLE IF EXISTS `systemlog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `systemlog` (
  `logdate` date DEFAULT NULL,
  `logaction` text,
  `deviceserial` text,
  `changes` text,
  `username` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `systemlog`
--

LOCK TABLES `systemlog` WRITE;
/*!40000 ALTER TABLE `systemlog` DISABLE KEYS */;
INSERT INTO `systemlog` VALUES ('2016-07-02','ADD','20090000032847','NONE','pass@ceu.edu.ph'),('2016-07-02','ADD','20090000032849','NONE','pass@ceu.edu.ph'),('2016-07-02','EDIT','20090000032849',',SERIAL,PRICE','pass@ceu.edu.ph'),('2016-07-02','EDIT','20090000032849',',SERIAL','pass@ceu.edu.ph'),('2016-07-02','EDIT','20090000032848',',SERIAL','pass@ceu.edu.ph'),('2016-07-02','EDIT','20090000032848',',LOCATION','pass@ceu.edu.ph'),('2016-07-02','EDIT','20090000032848',',LOCATION','tsmijares@ceu.edu.ph');
/*!40000 ALTER TABLE `systemlog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlist`
--

DROP TABLE IF EXISTS `userlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userlist` (
  `fname` text,
  `mname` text,
  `lname` text,
  `username` text,
  `password` text,
  `usertype` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlist`
--

LOCK TABLES `userlist` WRITE;
/*!40000 ALTER TABLE `userlist` DISABLE KEYS */;
INSERT INTO `userlist` VALUES ('Kail Andrew','Rivera','Hamili','hamili1302815@ceu.edu.ph','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','Administrator'),('System','','Developers','pass@ceu.edu.ph','2e3fce77cf8c4c7478a96d207c1c39715892cac84a18cbec9b634f4bc22b390b48cd30a4df2e7ebbaee65c346a662c5be2d12441322f7a4bac821a382c4af091','Administrator'),('Mary Grace','Lancion','Gacosta','gacosta1400465@ceu.edu.ph','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','Staff'),('Joanna','Lim','Pabustan','jolipa@ceu.edu.ph','e54ee7e285fbb0275279143abc4c554e5314e7b417ecac83a5984a964facbaad68866a2841c3e83ddf125a2985566261c4014f9f960ec60253aebcda9513a9b4','Staff'),('Teresita','S','Mijares','tsmijares@ceu.edu.ph','ac853632a12ae128158fab24ce3a5472962826b026f1f43564a89d92af549ca77be6587381b637237387294dcbee069f8b3868fb2d2eae16c2f12a3412240fe5','Administrator');
/*!40000 ALTER TABLE `userlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-02 18:52:55
