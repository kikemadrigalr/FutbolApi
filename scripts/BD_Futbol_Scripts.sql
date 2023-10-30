-- Crear la base de datos
CREATE DATABASE Futbol;

--Poner en uso la tabla Futbol
USE Futbol;

-- Crear la tabla Pais
CREATE TABLE Pais (
    PaisID INT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

--Crear tabla Liga
CREATE TABLE Liga (
	LigaID INT PRIMARY KEY,
	Nombre VARCHAR(255) NOT NULL,
	Temporada VARCHAR(20) NOT NULL,
	Equipos INT,
	PaisID INT
	FOREIGN KEY (PaisID) REFERENCES Pais(PaisID)
)

--Crear Tabla Club
CREATE TABLE Club (
    ClubID INT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    AnioFundacion VARCHAR(10),
	Presidente VARCHAR(255),
	Entrenador VARCHAR(255),
    Estadio VARCHAR(255),
    LigaID INT,
	PaisID INT
    FOREIGN KEY (PaisID) REFERENCES Pais(PaisID),
	FOREIGN KEY (LigaID) REFERENCES Liga(LigaID)
);

-- Crear tabla Jugador
CREATE TABLE Jugador (
	JugadorID INT PRIMARY KEY,
	Nombre VARCHAR(255) NOT NULL,
	Edad INT NOT NULL,
	ClubID INT NOT NULL,
	Posicion VARCHAR(255) NOT NULL,
	Numero INT
	FOREIGN KEY (ClubID) REFERENCES Club(ClubID)
);
