USE FUTBOL 

--Inserts Paises 

-- España
INSERT INTO Pais (Nombre) VALUES ('España');

-- Inglaterra
INSERT INTO Pais (Nombre) VALUES ('Inglaterra');

-- Italia
INSERT INTO Pais (Nombre) VALUES ('Italia');

-- Alemania
INSERT INTO Pais (Nombre) VALUES ('Alemania');

-- Francia
INSERT INTO Pais (Nombre) VALUES ('Francia');

-- Brasil
INSERT INTO Pais (Nombre) VALUES ('Brasil');

-- Argentina
INSERT INTO Pais (Nombre) VALUES ('Argentina');

-- Estados Unidos y Canadá
INSERT INTO Pais (Nombre) VALUES ('Estados Unidos');

-- Arabia Saudita
INSERT INTO Pais (Nombre) VALUES ('Arabia Saudita');


--Insert para Ligas
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('La Liga', '2023-2024', 20, 1)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Premier League', '2023-2024', 20, 2)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Serie A', '2023-2024', 20, 3)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Bundesliga', '2023-2024', 18, 4)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Ligue 1', '2023-2024', 20, 5)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Brasileirao Serie A', '2023-2024', 20, 6)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Argentine Primera División', '2023-2024', 26, 7)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Major League Soccer', '2023-2024', 28, 8)
INSERT INTO Liga (Nombre, Temporada, Equipos, PaisID) VALUES ('Liga Profesional Saudí', '2023-2024', 16, 9)

--INSERT CLUB
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Real Madrid', '1902', 'Florentino Pérez', 'Carlo Ancelotti', 'Santiago Bernabeu', 1, 1)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Manchester United', '1878', ' Joel Glazer', 'Erick Ten Hag', 'Old Trafford', 2, 2)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Juventus', '1897', 'Andrea Agnelli', 'Massimiliano Allegri', 'Estadio: Allianz Stadium', 3, 3	)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Bayern de Múnich', '1900', 'Herbert Hainer', 'Julian Nagelsmann', 'Allianz Arena', 4, 4)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Paris Saint-Germain', '1970', 'Nasser Al-Khelaifi', 'Mauricio Pochettino', 'Parc des Princes', 5, 5)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Flamengo', '1895', 'Rodolfo Landim', 'Renato Gaúcho', 'Maracanã', 6, 6)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Boca Juniors', '1905', 'Juan Román Riquelme', 'Sebastián Battaglia', 'La Bombonera', 7, 7)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Los Angeles Galaxy', '1994', 'Chris Klein', 'Greg Vanney', 'Dignity Health Sports Park', 8, 8)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('Al Nassr', '1955', 'Saud bin Turki', 'Mano Menezes', 'King Fahd International Stadium', 9, 9)
INSERT Club (Nombre, AnioFundacion, Presidente, Entrenador, Estadio, LigaID, PaisID) VALUES ('FC Barcelona', '1899', 'Joan Laporta', 'Xavi Hernández', 'Camp Nou', 1, 1)


--Insert Jugador
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Jude Bellingham', 20, 1, 'Mediocampista', 5)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Bruno Fernandez', 29, 2, 'Mediocampista', 8)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Dusan Vlahovic', 23, 3, 'Delantero', 9)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Harry Kane', 30, 4, 'Delantero', 9)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Kylian Mbappé', 23, 5, 'Delantero', 7)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Filipe Luis', 36, 6, 'Mediocampista', 16)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Edinson Cavani', 36, 7, 'Delantero', 10)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('David Bingham', 34, 8, 'Portero', 1)
INSERT Jugador (Nombre, Edad, ClubID, Posicion, Numero) VALUES ('Cristiano Ronaldo', 23, 9, 'Delantero', 7)


Select * from Pais
select * from Liga
select * from Club
select * from Jugador

-- Selects 
USE Futbol

-- Devuelve todos los jugadores, numero y posicion y el club en el que Juegan
SELECT Jugador.Nombre, Jugador.Posicion, Jugador.Numero, Club.Nombre
FROM Jugador
INNER JOIN Club ON Club.ClubID = Jugador.ClubID;

