CREATE DATABASE IF NOT EXISTS UsersDb;
USE UsersDb;

CREATE TABLE IF NOT EXISTS Usuario (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nome VARCHAR(50) NOT NULL,
	matricula VARCHAR(10) NOT NULL
);

INSERT INTO Usuario (nome, matricula) VALUES ('Francisco Airton Araújo Júnior', '2023010960');
INSERT INTO Usuario (nome, matricula) VALUES ('Jorge Pereira de Oliveira', '2023011027');
INSERT INTO Usuario (nome, matricula) VALUES ('Rafael Guimarães Januário', '2023010600');
