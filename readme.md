# Modelo Club Futbol

## Listado de Entidades

### Club

- club_id **(PK)**
- nombre
- anio_fundacion
- presidente
- entrenador
- estadio
- liga_id **(FK)**
- pais **(FK)**  

### Jugador

- jugador_id **(PK)**
- nombre
- edad
- club **(FK)**
- posicion
- numero

### Liga

- liga_id **(PK)**
- nombre
- pais **(FK)**
- temporada
- equipos

### Pais

- pais_id **(PK)**
- nombre

## Relaciones

1. Un **club** _tiene_ muchos  **jugadores**. (_1 : N_)
1. Un **club** _compite_ en una **liga**. (_N : 1_)
1. Un **club** _pertenece_ a un **país**. (_N : 1_)
1. Una **liga** _pertenece_ a un **pais**. (_1 : 1_)
1. Un **jugador** _participan_ en una **liga**. (_N : 1_)

En la carpeta scripts que se encuentra en la raiz del proyecto se encuentran 2 archivos

1. BD_Futbol_Scripts.sql
1. BD_FUTBOL_Inserts.sql

- El archivo scripts contiene las instrucciones para la creacion de la base de datos y la creacion de las tablas del modelo

- El archivo Iserts contiene las instrucciones inserts para el llenado de las tablas y otras consultas relacionadas.

Ambos estan desarrollados utilizando el motor de base de datos _Sql Server_ por lo tanto se recomienda su uso

Para poner en marcha el Proyecto del APi clone el proyecto en su entorno local

Cambie los parametros de conexion de la base de datos para que ejecute la conexion a su servidor de base de datos. Los mismos se encuentran en el archivo appsettings en la seccion:
```

 "ConnectionStrings": {
    "CadenaSql" : "Server=TuServer\\SQLEXPRESS; Database=Futbol; User Id=TuUser; Password=XXXXXX; Trusted_Connection=True;TrustServerCertificate=True;"
  }

```

Para ejecutar el proyecto y manipular el codigo se recomienda el uso de Visual Studio y el sdk de .Net 6