CREATE SCHEMA `default_schema` ;
create user DBUser@'%' identified by 'user';
GRANT ALL PRIVILEGES ON default_schema.* TO 'DBUser'@'%';

-- Tables:

CREATE TABLE `default_schema`.`patienten` (
  `idPatient` INT NOT NULL,
  `plz` VARCHAR(5) NULL,
  `strasse` VARCHAR(255) NULL,
  `hausnummer` VARCHAR(10) NULL,
  `name` VARCHAR(45) NULL,
  `vorname` VARCHAR(45) NULL,
  `geburtstag` DATE NULL,
  `geschlecht` VARCHAR(45) NULL,
  `telefon` VARCHAR(45) NULL,
  `naechsterBesuch` DATETIME NULL,
  `letzterBekannterStatus` VARCHAR(45) NULL,
  PRIMARY KEY (`idPatienten`));
CREATE TABLE `default_schema`.`patientenbesuch` (
  `idPatientenbesuch` INT NOT NULL,
  `idPatient` INT NULL,
  `einlieferungsZeitpunkt` DATETIME NULL,
  `einlieferungsStatus` VARCHAR(45) NULL,
  `grundDesBesuches` VARCHAR(45) NULL,
  `abreiseZeitpunkt` DATETIME NULL,
  PRIMARY KEY (`idPatientenbesuch`));
  CREATE TABLE `default_schema`.`behandlungsliste` (
  `idBehandlungsliste` INT NOT NULL,
  `idPatientenBesuch` INT NULL,
  `behandlungsort` VARCHAR(45) NULL,
  `behanlungsbeschreibung` VARCHAR(45) NULL,
  `medikamentenID` INT NULL,
  `benutzungProTag` DOUBLE NULL,
  `dauerInTage` INT NULL,
  `anzahlErhalteneMedikamente` INT NULL,
  PRIMARY KEY (`idBehandlungsliste`));
  CREATE TABLE `default_schema`.`medikamentenliste` (
  `idMedikamentenListe` INT NOT NULL,
  `bezeichnung` VARCHAR(45) NULL,
  `kostenProVerschreibung` DOUBLE NULL,
  `anzahlMaximaleBenutzung` INT NULL,
  PRIMARY KEY (`idMedikamentenListe`));
CREATE TABLE `default_schema`.`symptomliste` (
  `idSymptome` INT NOT NULL,
  `idPatientenBesuch` INT NULL,
  `bezeichnung` VARCHAR(45) NULL,
  PRIMARY KEY (`idSymptome`));
CREATE TABLE `default_schema`.`allergienliste` (
  `idAllergie` INT NOT NULL,
  `idPatient` INT NULL,
  `bezeichnung` VARCHAR(255) NULL,
  PRIMARY KEY (`idAllergie`));
CREATE TABLE `default_schema`.`vorerkrankungsliste` (
  `idVorerkrankungs` INT NOT NULL,
  `idPatient` INT NULL,
  `bezeichnung` VARCHAR(255) NULL,
  PRIMARY KEY (`idVorerkrankungs`));