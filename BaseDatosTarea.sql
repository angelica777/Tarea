-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.19 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bd_tarea
CREATE DATABASE IF NOT EXISTS `bd_tarea` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_tarea`;

-- Volcando estructura para procedimiento bd_tarea.editar_tarea
DELIMITER //
CREATE PROCEDURE `editar_tarea`(
	IN `pnombre` VARCHAR(50),
	IN `pdescrip` VARCHAR(50),
	IN `ppriori` SET('Alta','Media', 'Baja'),
	IN `pestado` SET('completa','incompleta')
)
BEGIN
   
UPDATE tarea SET
nombre=pnombre,
descripcion=pdescrip,
prioridad=ppriori,
estado=pestado
   WHERE nombre=pnombre;  
END//
DELIMITER ;

-- Volcando estructura para tabla bd_tarea.persona
CREATE TABLE IF NOT EXISTS `persona` (
  `idPersona` int NOT NULL AUTO_INCREMENT,
  `nombres` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla bd_tarea.persona: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` (`idPersona`, `nombres`) VALUES
	(1, 'Juan');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;

-- Volcando estructura para procedimiento bd_tarea.registrar_tarea
DELIMITER //
CREATE PROCEDURE `registrar_tarea`(
	IN `nombre` VARCHAR(50),
	IN `descripcion` VARCHAR(50),
	IN `prioridad` SET('Alto','Medio','Bajo'),
	IN `estado` SET('completo','incompleta'),
	IN `responsable` INT
)
BEGIN
    INSERT INTO tarea VALUES(DEFAULT,nombre,descripcion,prioridad,'incompleta', responsable);
END//
DELIMITER ;

-- Volcando estructura para tabla bd_tarea.tarea
CREATE TABLE IF NOT EXISTS `tarea` (
  `idTarea` int NOT NULL AUTO_INCREMENT,
  `nombreTarea` varchar(50) DEFAULT '',
  `Descripcion` varchar(50) DEFAULT '',
  `Prioridad` set('Alta',' Media','Baja') NOT NULL DEFAULT '',
  `estado` set('completada','incompleta') NOT NULL DEFAULT '',
  `fk_responsable` int DEFAULT NULL,
  PRIMARY KEY (`idTarea`),
  KEY `FK_tarea_persona` (`fk_responsable`),
  CONSTRAINT `FK_tarea_persona` FOREIGN KEY (`fk_responsable`) REFERENCES `persona` (`idPersona`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla bd_tarea.tarea: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `tarea` DISABLE KEYS */;
INSERT INTO `tarea` (`idTarea`, `nombreTarea`, `Descripcion`, `Prioridad`, `estado`, `fk_responsable`) VALUES
	(1, 'Prueba', 'ASD', 'Alta', 'incompleta', NULL),
	(2, 'Prueba 02', 'ASD', 'Baja', 'incompleta', NULL);
/*!40000 ALTER TABLE `tarea` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
