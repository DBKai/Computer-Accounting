-- Дамп структуры базы данных it
CREATE DATABASE IF NOT EXISTS `it`;
USE `it`;


-- Дамп структуры для таблица it.accountable
CREATE TABLE IF NOT EXISTS `accountable` (
  `id_acc` smallint(6) NOT NULL AUTO_INCREMENT,
  `acc_name` char(255) DEFAULT NULL,
  PRIMARY KEY (`id_acc`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8 COMMENT='Ответственные';

-- Дамп структуры для таблица it.equipment
CREATE TABLE IF NOT EXISTS `equipment` (
  `id_equip` smallint(6) NOT NULL AUTO_INCREMENT,
  `equip_name` char(255) DEFAULT NULL,
  PRIMARY KEY (`id_equip`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8 COMMENT='Материальная ценность';

-- Дамп структуры для таблица it.event
CREATE TABLE IF NOT EXISTS `event` (
  `id_event` smallint(6) NOT NULL AUTO_INCREMENT,
  `event_name` char(255) DEFAULT NULL,
  PRIMARY KEY (`id_event`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COMMENT='Событие';

-- Дамп структуры для таблица it.subdivision
CREATE TABLE IF NOT EXISTS `subdivision` (
  `id_subdiv` smallint(6) NOT NULL AUTO_INCREMENT,
  `subdiv_name` char(255) DEFAULT NULL,
  PRIMARY KEY (`id_subdiv`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8 COMMENT='Подразделение/цех/отдел';

-- Дамп структуры для таблица it.card
CREATE TABLE IF NOT EXISTS `card` (
  `id_card` smallint(6) NOT NULL AUTO_INCREMENT COMMENT 'Код карточки',
  `inv` char(50) DEFAULT NULL COMMENT 'Инвентарный номер',
  `equip_id` smallint(6) DEFAULT NULL COMMENT 'ИД Материальной ценности',
  `cost` float DEFAULT NULL COMMENT 'Балансовая стоимость',
  `delivery_date` date DEFAULT NULL COMMENT 'Дата установки',
  `writeoff_date` date DEFAULT NULL COMMENT 'Дата списания',
  PRIMARY KEY (`id_card`),
  KEY `FK_card_equipment` (`equip_id`),
  CONSTRAINT `FK_card_equipment` FOREIGN KEY (`equip_id`) REFERENCES `equipment` (`id_equip`)
) ENGINE=InnoDB AUTO_INCREMENT=614 DEFAULT CHARSET=utf8 COMMENT='Карточки с материальными ценностями';

-- Дамп структуры для таблица it.movement
CREATE TABLE IF NOT EXISTS `movement` (
  `id_move` smallint(6) NOT NULL AUTO_INCREMENT,
  `card_id` smallint(6) DEFAULT NULL COMMENT 'Код карточки',
  `dt_move` date DEFAULT NULL COMMENT 'Дата движения',
  `from_move_id` smallint(6) DEFAULT NULL COMMENT 'Откуда движение',
  `for_move_id` smallint(6) DEFAULT NULL COMMENT 'Куда движение',
  `acc_id` smallint(6) DEFAULT NULL COMMENT 'Код ответственного',
  `event_id` smallint(6) DEFAULT NULL COMMENT 'Код события',
  PRIMARY KEY (`id_move`),
  KEY `from_m` (`from_move_id`),
  KEY `for_m` (`for_move_id`),
  KEY `acc_id` (`acc_id`),
  KEY `event_id` (`event_id`),
  KEY `card_id` (`card_id`),
  CONSTRAINT `FK_movement_subdivision2` FOREIGN KEY (`for_move_id`) REFERENCES `subdivision` (`id_subdiv`),
  CONSTRAINT `FK_movement_accountable` FOREIGN KEY (`acc_id`) REFERENCES `accountable` (`id_acc`),
  CONSTRAINT `FK_movement_card` FOREIGN KEY (`card_id`) REFERENCES `card` (`id_card`),
  CONSTRAINT `FK_movement_event` FOREIGN KEY (`event_id`) REFERENCES `event` (`id_event`),
  CONSTRAINT `FK_movement_subdivision` FOREIGN KEY (`from_move_id`) REFERENCES `subdivision` (`id_subdiv`)
) ENGINE=InnoDB AUTO_INCREMENT=1267 DEFAULT CHARSET=utf8 COMMENT='Движение материальной ценности по подразделениям';