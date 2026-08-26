# TrabajoPractico_API-REST
README - TP API REST
Descripción

API REST desarrollada en C# con ASP.NET Core para gestionar mascotas.
El proyecto utiliza una clase abstracta Mascota y dos clases derivadas: Perro y Gato.

La API permite realizar operaciones GET, POST, PUT y DELETE sobre las mascotas.

Estructura

La clase Mascota es abstracta y contiene las propiedades comunes:

Id
Nombre
Edad

Las clases hijas agregan sus propias propiedades:

Perro: Raza
Gato: Color

Las mascotas se almacenan temporalmente en una lista estática en memoria.

Endpoints
Obtener todas las mascotas

GET

/ Mascota

Ejemplo:

GET /Mascota

Devuelve todas las mascotas registradas.

Obtener una mascota por ID

GET

/Mascota/{id}

Ejemplo:

GET /Mascota/1

Devuelve la mascota correspondiente al ID indicado.

Si no existe:

Mascota no encontrada
Obtener mascotas mayores a una edad

GET

/Mascota/mayores-a/{edad}

Ejemplo:

GET /Mascota/mayores-a/5

Devuelve las mascotas cuya edad sea mayor a la indicada.

Obtener mascotas por tipo

GET

/Mascota/tipo/{tipo}

Ejemplos:

GET /Mascota/tipo/perro
GET /Mascota/tipo/gato

Permite obtener únicamente perros o gatos.

Crear un perro

POST

/Mascota/perros

Body:

{
  "id": 5,
  "nombre": "Toby",
  "edad": 4,
  "raza": "Caniche"
}

Crea un nuevo objeto Perro y lo agrega a la lista.

Crear un gato

POST

/Mascota/gatos

Body:

{
  "id": 6,
  "nombre": "Simba",
  "edad": 2,
  "color": "Blanco"
}

Crea un nuevo objeto Gato y lo agrega a la lista.

Actualizar un perro

PUT

/Mascota/perro/{id}

Ejemplo:

PUT /Mascota/perro/1

Body:

{
  "nombre": "Firulais",
  "edad": 6,
  "raza": "Golden Retriever"
}

Busca un perro por su ID y modifica sus propiedades.

Actualizar un gato

PUT

/Mascota/gato/{id}

Ejemplo:

PUT /Mascota/gato/2

Body:

{
  "nombre": "Luna",
  "edad": 4,
  "color": "Gris"
}

Busca un gato por su ID y modifica sus propiedades.

Eliminar una mascota

DELETE

/Mascota/{id}

Ejemplo:

DELETE /Mascota/3

Elimina la mascota cuyo ID coincida con el indicado.

Datos iniciales

La API comienza con las siguientes mascotas:

Perro
Id: 1
Nombre: Firulas
Edad: 5
Raza: Labrador

Gato
Id: 2
Nombre: Luna
Edad: 3
Color: Naranja

Perro
Id: 3
Nombre: Rocky
Edad: 8
Raza: Salchicha

Gato
Id: 4
Nombre: Michi
Edad: 10
Color: Negro
Tecnologías utilizadas
C#
ASP.NET Core
API REST
Visual Studio
Swagger para probar los endpoints
Funcionamiento

La API utiliza una lista en memoria:

private static readonly List<Mascota> mascotas = new();

Al ser Mascota una clase abstracta, la lista puede contener objetos de sus clases derivadas Perro y Gato.

Para diferenciar los tipos se utiliza:

m is Perro

y:

m is Gato

Esto permite realizar operaciones específicas dependiendo del tipo de mascota.