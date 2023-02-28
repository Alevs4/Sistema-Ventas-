CREATE DATABASE  IF NOT EXISTS `bd_inventario` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `bd_inventario`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_inventario
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categorias` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(100) NOT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Jugetes'),(2,'Confites'),(3,'Galletas'),(4,'Snacks'),(5,'Aseo'),(6,'Lápices'),(7,'Embutidos'),(8,'Helados'),(9,'Congelados');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compras`
--

DROP TABLE IF EXISTS `compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `compras` (
  `id_compra` int(11) NOT NULL AUTO_INCREMENT,
  `n_factura` varchar(100) NOT NULL,
  `rut_proveedor` varchar(10) NOT NULL,
  `fecha_compra` date NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_compra`),
  KEY `fk_proveedor_idx` (`rut_proveedor`),
  CONSTRAINT `fk_proveedor` FOREIGN KEY (`rut_proveedor`) REFERENCES `proveedores` (`rut_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compras`
--

LOCK TABLES `compras` WRITE;
/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
INSERT INTO `compras` VALUES (1,'453677','61602148-6','2018-12-21',110000),(2,'2','18629227-8','2018-12-27',500),(3,'987654321','18629227-8','2018-12-27',500),(4,'98765','61602148-6','2018-12-27',200500),(6,'89','61602148-6','2018-12-10',1400),(8,'444455654','61602148-6','2018-12-30',3500),(9,'888877655','61602148-6','2018-12-30',800);
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalle_compra` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_compra` int(11) NOT NULL,
  `n_factura` int(11) NOT NULL,
  `cod_prod` int(11) NOT NULL,
  `valor_unitario` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_compra_idx` (`id_compra`),
  KEY `fk_detalle_compra_idx` (`cod_prod`),
  CONSTRAINT `fk_compra` FOREIGN KEY (`id_compra`) REFERENCES `compras` (`id_compra`),
  CONSTRAINT `fk_detalle_compra` FOREIGN KEY (`cod_prod`) REFERENCES `productos` (`cod_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
INSERT INTO `detalle_compra` VALUES (1,1,453677,6,700,2,1400),(2,1,453677,7,220,1,220),(3,1,453677,8,200,6,1200),(4,3,987654321,6,500,1,500),(5,4,98765,2,200000,1,200000),(6,4,98765,6,500,1,500),(9,9,888877655,22,400,2,800);
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_lotes_perecibles`
--

DROP TABLE IF EXISTS `detalle_lotes_perecibles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalle_lotes_perecibles` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `cod_producto` int(11) NOT NULL,
  `id_lote` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_lote_perecibles_detalle_idx` (`id_lote`),
  KEY `fk_productos_lote_idx` (`cod_producto`),
  CONSTRAINT `fk_lote_perecibles_detalle` FOREIGN KEY (`id_lote`) REFERENCES `lotes_perecibles` (`id_lote`),
  CONSTRAINT `fk_productos_lote` FOREIGN KEY (`cod_producto`) REFERENCES `productos` (`cod_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_lotes_perecibles`
--

LOCK TABLES `detalle_lotes_perecibles` WRITE;
/*!40000 ALTER TABLE `detalle_lotes_perecibles` DISABLE KEYS */;
INSERT INTO `detalle_lotes_perecibles` VALUES (1,10,7),(2,7,7),(3,14,8),(4,15,9),(5,4,10),(6,17,11),(7,18,12),(8,6,12),(9,19,14),(10,23,15),(11,24,16),(12,22,17);
/*!40000 ALTER TABLE `detalle_lotes_perecibles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_venta`
--

DROP TABLE IF EXISTS `detalle_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalle_venta` (
  `id_detalle_venta` int(11) NOT NULL AUTO_INCREMENT,
  `n_factura` int(11) NOT NULL,
  `codigo_producto` int(11) NOT NULL,
  `valor_unitario` int(11) NOT NULL,
  `valor_compra` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_venta`),
  KEY `fk_detalle_ventas_idx` (`n_factura`),
  KEY `fk_productos_idx` (`codigo_producto`),
  CONSTRAINT `fk_detalle_venta` FOREIGN KEY (`n_factura`) REFERENCES `ventas` (`n_factura`),
  CONSTRAINT `fk_productos` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`cod_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_venta`
--

LOCK TABLES `detalle_venta` WRITE;
/*!40000 ALTER TABLE `detalle_venta` DISABLE KEYS */;
INSERT INTO `detalle_venta` VALUES (1,1,2,1390,0,1,1390),(2,2,5,4000,0,1,4000),(3,2,6,1590,0,1,1590),(4,2,4,10000,0,2,20000),(5,9,3,13900,0,1,13900),(6,9,6,1590,0,1,1590),(7,10,6,1590,0,1,1590),(8,10,7,550,0,1,550),(9,11,3,13900,0,1,13900),(10,11,6,1590,0,1,1590),(11,12,6,1590,0,1,1590),(12,12,7,550,0,1,550),(13,13,6,1590,0,1,1590),(14,13,7,550,0,1,550),(15,14,6,1590,0,1,1590),(16,14,7,550,0,1,550),(17,14,3,13900,0,1,13900),(18,14,4,67000,0,1,67000),(19,14,7,550,0,2,1100),(20,14,6,1590,0,2,3180),(21,15,7,550,0,1,550),(22,15,6,1590,0,1,1590),(23,16,3,13900,0,1,13900),(24,17,4,67000,0,4,268000),(25,18,7,550,0,2,1100),(26,21,6,1590,0,1,1590),(27,22,6,1590,0,1,1590),(28,23,6,1590,0,1,1590),(29,23,7,550,0,10,5500),(30,24,6,1590,0,10,15900),(31,27,10,1890,5,9450,3000),(32,27,7,550,1,550,200),(33,28,23,780,1,780,600),(34,28,22,520,1,520,400),(35,28,24,520,1,520,400),(36,28,21,5200,3,15600,12000),(37,29,7,550,200,1,550),(38,29,10,1890,600,1,1890),(39,30,7,550,200,1,550),(40,31,10,1890,600,1,1890),(41,32,10,1890,600,1,1890),(42,33,4,67000,4000,1,67000),(43,34,4,67000,8000,2,134000),(44,35,10,1890,600,1,1890),(45,36,10,1890,600,1,1890),(46,36,16,120,30,1,120),(47,37,6,1590,500,1,1590),(48,38,6,1590,500,1,1590),(49,39,6,1590,2500,5,7950),(50,40,7,550,400,2,1100),(51,40,16,120,30,1,120),(52,41,5,11000,5000,1,11000),(53,41,8,500,200,1,500),(54,42,6,1590,500,1,1590),(55,43,6,1590,1000,2,3180),(56,43,5,11000,5000,1,11000);
/*!40000 ALTER TABLE `detalle_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lotes_perecibles`
--

DROP TABLE IF EXISTS `lotes_perecibles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lotes_perecibles` (
  `id_lote` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_ingreso` date DEFAULT NULL,
  `fecha_vencimiento` date DEFAULT NULL,
  PRIMARY KEY (`id_lote`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lotes_perecibles`
--

LOCK TABLES `lotes_perecibles` WRITE;
/*!40000 ALTER TABLE `lotes_perecibles` DISABLE KEYS */;
INSERT INTO `lotes_perecibles` VALUES (1,'2018-11-23','2018-12-11'),(2,'2018-11-29','2018-12-25'),(3,'2018-10-05','2018-11-05'),(4,'2018-12-11','2018-12-16'),(7,'2018-12-09','2018-12-17'),(8,'2018-12-20','2018-12-22'),(9,'2018-12-20','2018-12-22'),(10,'2018-12-20','2018-12-22'),(11,'2018-12-20','2018-12-29'),(12,'2018-12-27','2018-12-28'),(13,'2018-12-27','2018-12-27'),(14,'2018-12-30','2018-12-30'),(15,'2018-12-30','2018-12-30'),(16,'2018-12-30','2018-12-30'),(17,'2018-12-30','2019-01-06');
/*!40000 ALTER TABLE `lotes_perecibles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marcas`
--

DROP TABLE IF EXISTS `marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marcas` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `marca` varchar(50) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcas`
--

LOCK TABLES `marcas` WRITE;
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` VALUES (1,'Savory'),(2,'Ambrosoli'),(3,'Fruna'),(4,'P&G'),(5,'CCU'),(6,'Coca Cola'),(7,'MCkay'),(8,'Nestle'),(9,'Colun'),(10,'PF'),(11,'Generico');
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `productos` (
  `id_prod` int(11) NOT NULL AUTO_INCREMENT,
  `cod_prod` int(11) NOT NULL,
  `barrasopcional` varchar(100) DEFAULT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` int(11) NOT NULL,
  `precio_compra` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `id_marca` int(11) NOT NULL,
  PRIMARY KEY (`id_prod`,`cod_prod`),
  KEY `fk_prod_cat_idx` (`id_categoria`),
  KEY `fk_prod_marcas_idx` (`id_marca`),
  KEY `idx_productos_cod_prod` (`cod_prod`),
  CONSTRAINT `fk_prod_cat` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`),
  CONSTRAINT `fk_prod_marcas` FOREIGN KEY (`id_marca`) REFERENCES `marcas` (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,2,'7791969029807','Telefono Celular Motorola XT5','Telefono celular color negro, señal 4 G',11,369000,200000,5,7),(2,3,'0C21J053397144','Cargador Xbox 360','xbox 360',110,13900,10000,7,1),(3,4,'7501056346164','Celular Nokia','',97,67000,4000,9,11),(5,5,'48736522','Jamón Acaramelado','Jamon',48,11000,5000,6,10),(7,6,'7501006707687','Head and Shoulders','Shampo anticaspa',31,1590,500,2,11),(8,7,'66463727637262','Helado Sabor Chocolate','Helado 1LT casata',1,550,200,8,1),(9,8,'7807210610202','Cartonero Artel','Cartonero color amarillo básico',9,500,200,6,11),(11,10,'7801620005191','Gatorade  Cool Blue','Bebida de fantasia',0,1890,600,4,6),(12,11,'111111','hola','eee',23,333,100,4,2),(13,12,'2222222','ASLJDKASL','FD',11,222,50,4,3),(14,13,'7802820500011','Nectar','asdsad',10,10000,5000,4,6),(15,14,'','Maravilla','Maravilla normal',100,100,50,4,11),(16,15,'222222222','Chicle','Chicle',100,100,50,4,3),(18,16,'','Lápiz genérico','Lapiz pasta',48,120,30,6,11),(19,17,'Sin código de barras','Caja','Caja',12,30,10,9,11),(20,18,'987654','Cualquier cosa','Lol',3,780,600,4,1),(21,19,'7909189005024','Avon Care','',10,1950,1500,5,11),(22,20,'7506078052062','Tanax','',10,3120,2400,5,11),(23,21,'7506078948075','Bio','',19,5200,4000,5,10),(24,22,'4005900036759','Nivea Men Invisible','',51,520,400,5,4),(25,23,'7802820600100','Agua mineral','',20,780,600,3,5),(26,24,'7805300052062','Tanax','',41,520,400,5,4);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor_producto`
--

DROP TABLE IF EXISTS `proveedor_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveedor_producto` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `rut_proveedor` varchar(10) NOT NULL,
  `cod_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_proveedor`),
  KEY `fk_proveedores_idx` (`rut_proveedor`) /*!80000 INVISIBLE */,
  KEY `fk_productos_detalle_idx` (`cod_producto`),
  CONSTRAINT `fk_productos_detalle` FOREIGN KEY (`cod_producto`) REFERENCES `productos` (`cod_prod`),
  CONSTRAINT `fk_proveedores` FOREIGN KEY (`rut_proveedor`) REFERENCES `proveedores` (`rut_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor_producto`
--

LOCK TABLES `proveedor_producto` WRITE;
/*!40000 ALTER TABLE `proveedor_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveedores` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `rut_proveedor` varchar(10) NOT NULL,
  `razon_social` varchar(100) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `ciudad` varchar(45) NOT NULL,
  `giro` varchar(100) NOT NULL,
  PRIMARY KEY (`id_proveedor`),
  KEY `rut_proveedor` (`rut_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'61602148-6','Hospital Santa Cruz','Av. Errazuriz 900','72 2337100','xxxx@hsc.cl','Santa Cruz','Salud'),(2,'18629227-8','Fabian','Hospital','93748236','fab@gmail.com','Santa Cruz','Informaticos'),(5,'12184333-1','Juani','salkdjas','0000','888uu','hhh','buhu'),(6,'9452007-K','ghj','hgf','432','wed','s','wed');
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `rut_usuario` varchar(10) NOT NULL,
  `usuario` varchar(100) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `perfil` varchar(45) NOT NULL,
  PRIMARY KEY (`id_usuario`,`rut_usuario`),
  KEY `fk_rut_usuario` (`rut_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'12184333-1','Juana Pereira Quiñones','Juany','1234','Normal'),(2,'18629227-8','Fabian Ignacio','Fabi','1234','Administrador'),(3,'11742852-4','Ricardo Sánchez Córdova','Ricky','1111','Normal');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ventas` (
  `id_venta` int(11) NOT NULL AUTO_INCREMENT,
  `n_factura` int(11) NOT NULL,
  `fecha_venta` date NOT NULL,
  `total` int(11) NOT NULL,
  `condiciones` varchar(100) NOT NULL,
  `rut_usuario` varchar(10) NOT NULL,
  PRIMARY KEY (`id_venta`,`n_factura`),
  KEY `fk_detalle_ventas_idx` (`n_factura`),
  KEY `fk_rut_usuario_idx` (`rut_usuario`),
  CONSTRAINT `fk_rut_usuario` FOREIGN KEY (`rut_usuario`) REFERENCES `usuarios` (`rut_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (1,1,'2018-11-06',1390,'Efectivo','12184333-1'),(2,2,'2018-11-06',4000,'Efectivo','12184333-1'),(3,3,'2018-12-06',111900,'Efectivo','12184333-1'),(4,4,'2018-12-07',101180,'Efectivo','12184333-1'),(5,5,'2018-12-10',22000,'','12184333-1'),(6,6,'2018-12-11',2583000,'','12184333-1'),(7,7,'2018-12-12',68590,'Efectivo','12184333-1'),(8,8,'2018-12-12',15490,'Efectivo','12184333-1'),(9,9,'2018-12-12',15490,'Efectivo','12184333-1'),(10,10,'2018-12-12',2140,'Efectivo','12184333-1'),(11,11,'2018-12-12',15490,'Efectivo','12184333-1'),(12,12,'2018-12-12',2140,'Efectivo','12184333-1'),(13,13,'2018-12-12',2140,'Efectivo','12184333-1'),(14,14,'2018-12-12',2140,'Efectivo','12184333-1'),(15,14,'2018-12-12',85180,'Efectivo','12184333-1'),(16,15,'2018-12-12',2140,'Efectivo','12184333-1'),(17,16,'2018-12-12',13900,'Efectivo','12184333-1'),(18,17,'2018-12-13',268000,'Efectivo','12184333-1'),(19,18,'2018-12-13',1100,'Efectivo','12184333-1'),(22,19,'2018-12-18',5000,'Efectivo','18629227-8'),(24,20,'2018-12-18',5000,'Efectivo','18629227-8'),(25,21,'2018-12-18',1590,'Efectivo','18629227-8'),(26,22,'2018-12-20',1590,'Efectivo','18629227-8'),(27,23,'2018-12-25',7090,'Efectivo','18629227-8'),(28,24,'2018-12-25',15900,'Efectivo','18629227-8'),(29,25,'2018-12-26',10000,'Efectivo','18629227-8'),(30,26,'2018-12-26',10000,'Efectivo','18629227-8'),(31,27,'2018-12-26',10000,'Efectivo','18629227-8'),(32,28,'2018-12-30',17420,'Efectivo','18629227-8'),(33,29,'2019-01-02',2440,'Efectivo','18629227-8'),(34,30,'2019-01-02',550,'Efectivo','18629227-8'),(35,31,'2019-01-02',1890,'Efectivo','18629227-8'),(36,32,'2019-01-02',1890,'Efectivo','18629227-8'),(37,33,'2019-01-02',67000,'Efectivo','18629227-8'),(38,34,'2019-01-02',134000,'Efectivo','18629227-8'),(39,35,'2019-01-02',1890,'Efectivo','18629227-8'),(40,36,'2019-01-02',2010,'Efectivo','18629227-8'),(41,37,'2019-01-02',1590,'Efectivo','18629227-8'),(42,38,'2019-01-02',1590,'Efectivo','18629227-8'),(43,39,'2019-01-02',7950,'Efectivo','18629227-8'),(44,40,'2019-01-05',1220,'Efectivo','18629227-8'),(45,41,'2019-01-05',11500,'Efectivo','18629227-8'),(46,42,'2019-01-05',1590,'Efectivo','18629227-8'),(47,43,'2019-01-05',14180,'Efectivo','18629227-8');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bd_inventario'
--

--
-- Dumping routines for database 'bd_inventario'
--
/*!50003 DROP PROCEDURE IF EXISTS `SP_ACTUALIZAR_STOCK_RESTAR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci*/ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ACTUALIZAR_STOCK_RESTAR`(

IN vCodigoProd INT,
IN vStock INT

)
BEGIN

UPDATE PRODUCTOS SET cantidad= cantidad - vStock
WHERE cod_prod=vCodigoProd;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ACTUALIZAR_STOCK_SUMAR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ACTUALIZAR_STOCK_SUMAR`(

IN vCodigoProd INT,
IN vStock INT

)
BEGIN

UPDATE PRODUCTOS SET cantidad= cantidad + vStock
WHERE cod_prod=vCodigoProd;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_AGREGAR_CATEGORIA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AGREGAR_CATEGORIA`(

IN vNuevaCategoria VARCHAR(100)

)
BEGIN

INSERT INTO CATEGORIAS(categoria) Values(vNuevaCategoria);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_AGREGAR_MARCA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci*/ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AGREGAR_MARCA`(

IN vMarcaAgregar VARCHAR(100)

)
BEGIN

INSERT INTO MARCAS(marca) values(vMarcaAgregar);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_AGREGAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AGREGAR_PRODUCTO`(

IN vCodigo varchar(100),
IN vBarras varchar(100),
IN vNombre varchar(100),
IN vDescripcion varchar(100),
IN vCantidad INT(11),
IN vPrecio INT(11),
IN vPrecioCompra INT(11),
IN vCategoria INT(11),
IN vMarca INT(11)

)
BEGIN
INSERT INTO PRODUCTOS(cod_prod, barrasopcional, nombre, descripcion, cantidad, precio, precio_compra, id_categoria, id_marca) 
VALUES(vCodigo, vBarras, vNombre, vDescripcion, vCantidad, vPrecio, vPrecioCompra, vCategoria, vMarca);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_AGREGAR_PROVEEDORES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AGREGAR_PROVEEDORES`(

IN vRut VARCHAR(10),
IN vRazon_Social VARCHAR(100),
IN vDireccion VARCHAR(100),
IN vTelefono VARCHAR(45),
IN vEmail VARCHAR(45),
IN vCiudad VARCHAR(45),
IN vGiro VARCHAR(100)

)
BEGIN

INSERT INTO PROVEEDORES(rut_proveedor,razon_social,direccion,telefono,email,ciudad,giro)
VALUES(vRut,vRazon_Social,vDireccion,vTelefono,vEmail,vCiudad,vGiro);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_AGREGAR_USUARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AGREGAR_USUARIO`(

IN vRut VARCHAR(10),
IN vNombre VARCHAR(100),
IN vUser VARCHAR(45),
IN vPass VARCHAR(45),
IN vPerfil VARCHAR(45)

)
BEGIN

INSERT INTO USUARIOS(rut_usuario,usuario,user_name,clave,perfil)
VALUES(vRut,vNombre,vUser,vPass,vPerfil);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_COMPRA_POR_FECHA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_COMPRA_POR_FECHA`(

IN vFecha DATE

)
BEGIN

SELECT	compras.n_factura as 'Nº de Factura',
		compras.fecha_compra as 'Fecha de Compra',
        /*compras.total as 'Total de la venta',*/
        CONCAT('$ ', compras.total) as 'Total',
		proveedores.razon_social as 'Proveedor',
        proveedores.rut_proveedor as 'Rut Proveedor'
		       
FROM COMPRAS inner join PROVEEDORES
ON COMPRAS.rut_proveedor=PROVEEDORES.rut_proveedor
WHERE COMPRAS.fecha_compra=vFecha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_COMPRA_POR_NUM_FACTURA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_COMPRA_POR_NUM_FACTURA`(

IN vNumFactura INT

)
BEGIN

SELECT	compras.n_factura as 'Nº de Factura',
		compras.fecha_compra as 'Fecha de Compra',
        /*compras.total as 'Total de la venta',*/
        CONCAT('$ ', compras.total) as 'Total',
		proveedores.razon_social as 'Proveedor',
        proveedores.rut_proveedor as 'Rut Proveedor'
		       
FROM COMPRAS inner join PROVEEDORES
ON COMPRAS.rut_proveedor=PROVEEDORES.rut_proveedor
WHERE COMPRAS.n_factura=vNumFactura;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_COMPRA_POR_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_COMPRA_POR_PROVEEDOR`(

IN vProveedor VARCHAR(100)

)
BEGIN


SELECT	compras.n_factura as 'Nº de Factura',
		compras.fecha_compra as 'Fecha de Compra',
        /*compras.total as 'Total de la venta',*/
        CONCAT('$ ', compras.total) as 'Total',
		proveedores.razon_social as 'Proveedor',
        proveedores.rut_proveedor as 'Rut Proveedor'
FROM COMPRAS inner join PROVEEDORES
ON COMPRAS.rut_proveedor=PROVEEDORES.rut_proveedor
WHERE PROVEEDORES.razon_social LIKE CONCAT('%', vProveedor , '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_POR_CODIGO_BARRAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_POR_CODIGO_BARRAS`(

IN vCodigoBarrasBuscar VARCHAR(100)

)
BEGIN

SELECT 	productos.cod_prod as 'Código de Producto',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.descripcion as 'Descripción',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        categorias.categoria as 'Categoria',
        marcas.marca as 'Marca'
FROM PRODUCTOS inner join CATEGORIAS
ON productos.id_categoria=categorias.id_categoria inner join MARCAS
ON productos.id_marca=marcas.id_marca
WHERE productos.barrasopcional LIKE vCodigoBarrasBuscar;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_POR_CODIGO_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_POR_CODIGO_PRODUCTO`(

IN vCodProdBuscar INTEGER

)
BEGIN

SELECT 	productos.cod_prod as 'Código de Producto',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.descripcion as 'Descripción',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        categorias.categoria as 'Categoria',
        marcas.marca as 'Marca'
FROM PRODUCTOS inner join CATEGORIAS
ON productos.id_categoria=categorias.id_categoria inner join MARCAS
ON productos.id_marca=marcas.id_marca
WHERE productos.cod_prod LIKE vCodProdBuscar;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_PRODUCTO_PARA_VENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_PRODUCTO_PARA_VENTA`(


IN vBuscarNombre VARCHAR(100)

)
BEGIN
SELECT 	productos.cod_prod as 'Código de Producto',
		productos.nombre as 'Producto'
        
FROM PRODUCTOS WHERE productos.nombre LIKE CONCAT('%', vBuscarNombre , '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_PRODUCTO_POR_NOMBRE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_PRODUCTO_POR_NOMBRE`(

IN vBuscarNombre VARCHAR(100)

)
BEGIN
SELECT 	productos.cod_prod as 'Código de Producto',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.descripcion as 'Descripción',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        categorias.categoria as 'Categoria',
        marcas.marca as 'Marca'
FROM PRODUCTOS inner join CATEGORIAS
ON productos.id_categoria=categorias.id_categoria inner join MARCAS
ON productos.id_marca=marcas.id_marca
WHERE productos.nombre LIKE CONCAT('%', vBuscarNombre , '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_PROVEEDOR_POR_RUT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_PROVEEDOR_POR_RUT`(

IN vRut VARCHAR(10)
)
BEGIN

SELECT  * 
		
FROM PROVEEDORES WHERE rut_proveedor=vRut;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_USUARIO_POR_RUT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_USUARIO_POR_RUT`(

IN vRut VARCHAR(10)

)
BEGIN

SELECT * FROM USUARIOS 
WHERE rut_usuario=vRut;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_VENTA_POR_FECHA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_VENTA_POR_FECHA`(

IN vFecha DATE

)
BEGIN

SELECT 	ventas.n_factura as 'Nº de Boleta',
		ventas.fecha_venta as 'Fecha de Venta',
        ventas.total as 'Total de la venta',
        ventas.condiciones as 'Método de pago'
FROM VENTAS
WHERE ventas.fecha_venta=vFecha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_VENTA_POR_NUM_BOLETA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_VENTA_POR_NUM_BOLETA`(

IN vNumBoleta INT

)
BEGIN

SELECT	ventas.n_factura as 'Nº de Boleta',
		ventas.fecha_venta as 'Fecha de Venta',
        ventas.total as 'Total de la venta',
        ventas.condiciones as 'Método de pago'
FROM ventas
WHERE 	ventas.n_factura=vNumBoleta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_BUSCAR_VENTA_POR_TOTAL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_BUSCAR_VENTA_POR_TOTAL`(

IN vTotal INT

)
BEGIN

SELECT	ventas.n_factura as 'Nº de Boleta',
		ventas.fecha_venta as 'Fecha de Venta',
        ventas.total as 'Total de la venta',
        ventas.condiciones as 'Método de pago'
FROM ventas
WHERE 	ventas.total=vTotal;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_DATOS_PRODUCTO_DESDE_BOTON` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_DATOS_PRODUCTO_DESDE_BOTON`(

IN vCodBarras VARCHAR(100)

)
BEGIN

SELECT 	

		productos.cod_prod as 'Código de Producto',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        productos.descripcion as 'Descripcion',
        productos.precio_compra as 'Precio Compra',
        categorias.categoria as 'Categoría',
        marcas.marca as 'Marca'
        
FROM PRODUCTOS inner join CATEGORIAS
ON productos.id_categoria=categorias.id_categoria inner join MARCAS
ON productos.id_marca=marcas.id_marca
WHERE productos.barrasopcional = vCodBarras;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_DATOS_PRODUCTO_DESDE_DGV` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_DATOS_PRODUCTO_DESDE_DGV`(

IN vCodProd INT

)
BEGIN

SELECT 	productos.cod_prod as 'Código de Producto',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.descripcion as 'Descripcion',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        productos.precio_compra as 'Precio Compra',
        categorias.categoria as 'Categoría',
        marcas.marca as 'Marca'
FROM PRODUCTOS inner join CATEGORIAS
ON productos.id_categoria=categorias.id_categoria inner join MARCAS
ON productos.id_marca=marcas.id_marca
WHERE productos.cod_prod = vCodProd;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_DETALLE_DE_COMPRA_REALIZADA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_DETALLE_DE_COMPRA_REALIZADA`(

IN vCodigoCompra INT

)
BEGIN

SELECT 	productos.nombre as 'Producto',
		marcas.marca as 'Marca',
        categorias.categoria as 'Categoría',
		detalle_compra.cantidad 'Cantidad Comprada',
		detalle_compra.valor_unitario as 'Total de compra'
        FROM productos inner join detalle_compra
ON productos.cod_prod=detalle_compra.cod_prod inner join compras
ON compras.n_factura=detalle_compra.n_factura inner join marcas
ON productos.id_marca=marcas.id_marca inner join categorias
ON productos.id_categoria=categorias.id_categoria
WHERE compras.n_factura=vCodigoCompra;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_DETALLE_DE_VENTA_REALIZADA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_DETALLE_DE_VENTA_REALIZADA`(

IN vCodigoVenta INT

)
BEGIN

SELECT 	productos.nombre as 'Producto',
		productos.precio as 'Precio Unitario',
		detalle_venta.cantidad 'Cantidad Vendida',
		detalle_venta.total as 'Total por producto'
        FROM productos inner join detalle_venta
ON productos.cod_prod=detalle_venta.codigo_producto inner join ventas
ON ventas.n_factura=detalle_venta.n_factura
WHERE ventas.n_factura=vCodigoVenta;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_PRODUCTOS_DE_LOTE_SELECCIONADO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_PRODUCTOS_DE_LOTE_SELECCIONADO`(

IN vCod_Lote INT

)
BEGIN
SELECT * FROM DETALLE_LOTES_PERECIBLES
WHERE id_lote=vCod_Lote;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_PROVEEDORES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_PROVEEDORES`()
BEGIN
SELECT * FROM PROVEEDORES;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CARGAR_USUARIOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CARGAR_USUARIOS`()
BEGIN
SELECT * FROM USUARIOS;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CATEGORIAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CATEGORIAS`()
BEGIN

SELECT categoria 
FROM CATEGORIAS;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CONSULTAR_CATEGORIAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CONSULTAR_CATEGORIAS`(

IN vCategoriaConsultar VARCHAR(100)

)
BEGIN
SELECT categoria FROM CATEGORIAS WHERE categoria=vCategoriaConsultar;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CONSULTAR_MARCAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CONSULTAR_MARCAS`(

IN vMarcaConsultar VARCHAR(100)

)
BEGIN

SELECT marca FROM MARCAS WHERE marca=vMarcaConsultar;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CUENTA_VENTAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CUENTA_VENTAS`(

IN vFecha DATE

)
BEGIN
SELECT 	count(ventas.id_venta) as 'Ventas'

FROM VENTAS
WHERE ventas.fecha_venta=vFecha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_CUENTA_VENTAS_RANGO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CUENTA_VENTAS_RANGO`(

IN vFecha DATE,
IN vFechaFin DATE

)
BEGIN
SELECT 	count(ventas.id_venta) as 'Ventas'

FROM VENTAS
WHERE ventas.fecha_venta between vFecha and vFechaFin;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_EDITAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDITAR_PRODUCTO`(

IN vCod_prod INT,
IN vbarrasOpcional VARCHAR(100),
IN vNombre VARCHAR(100),
IN vDescripcion VARCHAR(100),
IN vCantidad INT,
IN vPrecio INT,
IN vCategoria INT,
IN vMarca INT

)
BEGIN

UPDATE PRODUCTOS SET barrasopcional=vBarrasOpcional, 
nombre=vNombre, descripcion=vDescripcion, cantidad=vCantidad, 
precio=vPrecio, id_categoria=vCategoria, id_marca=vMarca

WHERE cod_prod=vCod_prod;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ELIMINAR_CATEGORIA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ELIMINAR_CATEGORIA`(

IN vCategoria VARCHAR(100)

)
BEGIN
DELETE FROM CATEGORIAS WHERE CATEGORIA=vCategoria;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ELIMINAR_MARCA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ELIMINAR_MARCA`(

IN vMarca VARCHAR(100)

)
BEGIN


DELETE FROM MARCAS WHERE MARCA=vMarca;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ELIMINAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ELIMINAR_PRODUCTO`(

IN vCod_Prod INTEGER

)
BEGIN

DELETE FROM PRODUCTOS
WHERE cod_prod=vCod_Prod;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ELIMINAR_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ELIMINAR_PROVEEDOR`(

IN vRut VARCHAR(10)

)
BEGIN

DELETE FROM PROVEEDORES WHERE rut_proveedor=vRut;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_ELIMINAR_USUARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ELIMINAR_USUARIO`(

IN vRut VARCHAR(10)

)
BEGIN

DELETE FROM USUARIOS WHERE rut_usuario=vRut;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_GUARDAR_COMPRA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GUARDAR_COMPRA`(

IN vN_factura VARCHAR(100),
IN vRut varchar(10),
IN vFecha DATE,
IN vTotal INT

)
BEGIN

INSERT INTO COMPRAS(n_factura, rut_proveedor, fecha_compra, total)
VALUES(vN_factura,vRut,vFecha,vTotal);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_GUARDAR_DETALLE_COMPRA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GUARDAR_DETALLE_COMPRA`(

IN vCodigoCompra INT,
IN vNfactura VARCHAR(100),
IN vCodigoProducto INT,
IN vPrecioUnitario INT,
IN vCantidad INT,
IN vTotal int

)
BEGIN
INSERT INTO detalle_compra(id_compra,n_factura,cod_prod,valor_unitario,cantidad,total)
values(vCodigoCompra,vNfactura,vCodigoProducto,vPrecioUnitario,vCantidad,vTotal);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE`(

IN vCod_Producto INT,
IN vCod_Lote INT

)
BEGIN

INSERT INTO DETALLE_LOTES_PERECIBLES(cod_producto,id_lote)
VALUES(vCod_Producto,vCod_Lote);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_GUARDAR_DETALLE_VENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GUARDAR_DETALLE_VENTA`(

IN vCodigoVenta INT,
IN vCodigoProducto INT,
IN vPrecioUnitario INT,
IN vValorCompUnit INT,
IN vCantidad INT,
IN vTotal int

)
BEGIN
INSERT INTO detalle_venta(n_factura,codigo_producto,valor_unitario,valor_compra,cantidad,total)
values(vCodigoVenta,vCodigoProducto,vPrecioUnitario,vValorCompUnit,vCantidad,vTotal);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_GUARDAR_VENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GUARDAR_VENTA`(

IN vN_factura INT,
IN vFecha DATE,
IN vTotal INT,
IN vCondiciones varchar(100),
IN vRut varchar(10)
)
BEGIN

INSERT INTO VENTAS(n_factura, fecha_venta, total, condiciones,rut_usuario)
VALUES(vN_factura,vFecha,vTotal,vCondiciones,vRut);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LISTAR_CATEGORIAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTAR_CATEGORIAS`()
BEGIN
SELECT * FROM CATEGORIAS;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LISTAR_COMPRAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTAR_COMPRAS`()
BEGIN
SELECT 	COMPRAS.n_factura as 'N° de Factura',
		COMPRAS.fecha_compra as 'Fecha de Compra',
		/*ventas.total as 'Total',*/
        CONCAT('$ ', COMPRAS.total) as 'Total',
        proveedores.razon_social as 'Proveedor',
        proveedores.rut_proveedor as 'Rut Proveedor'
        
FROM COMPRAS inner join proveedores
ON PROVEEDORES.rut_proveedor=COMPRAS.rut_proveedor
ORDER BY COMPRAS.id_compra desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LISTAR_LOTES_POR_VENCER` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTAR_LOTES_POR_VENCER`()
BEGIN
SELECT 	
		id_lote as 'Nº Lote',
		fecha_ingreso as 'Fecha de Ingreso',
		fecha_vencimiento as 'Fecha de Vencimiento'
FROM lotes_perecibles
WHERE lotes_perecibles.fecha_vencimiento >= curdate()
ORDER BY lotes_perecibles.fecha_vencimiento asc
limit 100;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LISTAR_PRODUCTOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTAR_PRODUCTOS`()
BEGIN
SELECT 	productos.cod_prod as 'Código Interno',
		productos.barrasopcional as 'Código de Barras',
		productos.nombre as 'Producto',
        productos.descripcion as 'Descripción',
        productos.cantidad as 'Cantidad en Stock',
        productos.precio as 'Precio',
        marcas.marca as 'Marca',
        categorias.categoria as 'Categoría'
FROM PRODUCTOS inner join MARCAS
ON PRODUCTOS.id_marca=MARCAS.id_marca inner join Categorias
ON PRODUCTOS.id_categoria=CATEGORIAS.id_categoria;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LISTAR_VENTAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTAR_VENTAS`()
BEGIN

SELECT 	ventas.n_factura as 'N° de Boleta',
		ventas.fecha_venta as 'Fecha de Venta',
		/*ventas.total as 'Total',*/
        CONCAT('$ ', ventas.total) as 'Total',
        ventas.condiciones as 'Medio de pago',
        usuarios.usuario as 'Vendedor'
FROM VENTAS inner join usuarios
ON USUARIOS.rut_usuario=VENTAS.rut_usuario
ORDER BY ventas.n_factura desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_LOGIN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LOGIN`(

IN vUser VARCHAR(100),
IN vPass VARCHAR(100)

)
BEGIN

SELECT  *
FROM USUARIOS
WHERE usuarios.user_name=vUser and usuarios.clave=vPass;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_MARCAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_MARCAS`()
BEGIN

SELECT marca
FROM MARCAS;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_MODIFICAR_CATEGORIA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_MODIFICAR_CATEGORIA`(

IN vCategoria VARCHAR(100),
IN vCatModificada VARCHAR(100)

)
BEGIN

UPDATE CATEGORIAS SET CATEGORIA=vCatModificada
WHERE CATEGORIA=vCategoria;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_MODIFICAR_MARCA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_MODIFICAR_MARCA`(

IN vMarca VARCHAR(100),
IN vMarcaModificada VARCHAR(100)

)
BEGIN

UPDATE MARCAS SET MARCA=vMarcaModificada
WHERE MARCA=vMarca;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_MODIFICA_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_MODIFICA_PROVEEDOR`(

IN vRut VARCHAR(10),
IN vRazon_Social VARCHAR(100),
IN vDireccion VARCHAR(100),
IN vTelefono VARCHAR(45),
IN vEmail VARCHAR(45),
IN vCiudad VARCHAR(45),
IN vGiro VARCHAR(100)
)
BEGIN

UPDATE PROVEEDORES SET 
			rut_proveedor=vRut, 
			razon_social=vRazon_social, 
            direccion=vDireccion, 
            telefono=vTelefono, 
            email=vEmail,
            ciudad=vCiudad,
            giro=vGiro
            
WHERE rut_proveedor=vRut;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_MODIFICA_USUARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_MODIFICA_USUARIO`(

IN vRut VARCHAR(10),
IN vNombre VARCHAR(100),
IN vUser VARCHAR(45),
IN vClave VARCHAR(45),
IN vPerfil VARCHAR(45)

)
BEGIN

UPDATE USUARIOS SET rut_usuario=vRut, usuario=vNombre, user_name=vUser, clave=vClave, perfil=vPerfil
WHERE rut_usuario=vRut;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_OBTENER_CODIGO_LOTE_SIGUIENTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_OBTENER_CODIGO_LOTE_SIGUIENTE`()
BEGIN

SELECT MAX(id_lote)
FROM LOTES_PERECIBLES;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_OBTENER_CODIGO_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_OBTENER_CODIGO_PRODUCTO`()
BEGIN
SELECT MAX(productos.cod_prod)
FROM PRODUCTOS;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_OBTENER_NUMERO_COMPRA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_OBTENER_NUMERO_COMPRA`()
BEGIN
SELECT MAX(compras.id_compra)
FROM COMPRAS;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_OBTENER_NUMERO_FACTURA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_OBTENER_NUMERO_FACTURA`()
BEGIN
SELECT MAX(n_factura) 
FROM VENTAS;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_PROVEEDORES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PROVEEDORES`()
BEGIN

SELECT rut_proveedor, razon_social
FROM PROVEEDORES;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_REPORTE_DIARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_REPORTE_DIARIO`(

IN vFecha DATE

)
BEGIN

SELECT 	sum(detalle_venta.valor_compra) as 'Costo', 
		sum(ventas.total) 'Total'

FROM VENTAS inner join DETALLE_VENTA
ON VENTAS.n_factura=DETALLE_VENTA.n_factura
WHERE ventas.fecha_venta=vFecha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_REPORTE_RANGO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_REPORTE_RANGO`(

IN vFechaInicio DATE,
IN vFechaFin DATE

)
BEGIN

SELECT 	sum(detalle_venta.valor_compra) as 'Costo', 
		sum(ventas.total) 'Total'
        

FROM VENTAS inner join DETALLE_VENTA
ON VENTAS.n_factura=DETALLE_VENTA.n_factura
WHERE ventas.fecha_venta between vFechaInicio and vFechaFin; 

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_USUARIOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_USUARIOS`()
BEGIN
Select * FROM usuarios;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SP_VENCIMIENTO_LOTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VENCIMIENTO_LOTE`(

IN vFecha_Ingreso DATE,
IN vFecha_Vencimiento DATE	

)
BEGIN

INSERT INTO LOTES_PERECIBLES(fecha_ingreso,fecha_vencimiento)
VALUES(vFecha_Ingreso,vFecha_Vencimiento);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-05 20:07:48
