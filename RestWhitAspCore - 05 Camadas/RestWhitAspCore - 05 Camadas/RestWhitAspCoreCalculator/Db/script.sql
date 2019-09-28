CREATE TABLE `persons`(
	`Id` INT(10) UNSIGNED NULL DEFAULT NULL,
	`FirstName` VARCHAR(50) NULL DEFAULT NULL,
	`LastName` VARCHAR(50) NULL DEFAULT NULL,
	`Adress` VARCHAR(50) NULL DEFAULT NULL,
	`Gender` VARCHAR(50) NULL DEFAULT NULL		
);

ALTER TABLE persons CHANGE ID ID INT(10) AUTO_INCREMENT PRIMARY KEY;


{
    "id": 1,
    "firstName": "Igor",
    "lastName": "Oliveira",
    "address": "Belo Horizonte - MG - Brasil",
    "gender": "Male"
}