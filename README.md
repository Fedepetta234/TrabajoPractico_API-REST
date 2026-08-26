Trabajo Práctico – API REST
Descripción

API REST desarrollada en C# y ASP.NET Core Web API para gestionar mascotas mediante operaciones CRUD. El proyecto aplica herencia utilizando una clase abstracta Mascota y dos clases derivadas: Perro y Gato.

Mascota contiene los atributos comunes Id, Nombre y Edad. Perro agrega Raza y Gato agrega Color.

Los datos se almacenan en una lista en memoria y la aplicación inicia con cuatro mascotas: Firulais, Luna, Rocky y Michi.

Endpoints
GET /Mascota → Obtiene todas las mascotas.
GET /Mascota/{id} → Obtiene una mascota por su Id.
POST /Mascota/perro → Registra un nuevo perro.
POST /Mascota/gato → Registra un nuevo gato.
PUT /Mascota/perro/{id} → Modifica un perro existente.
PUT /Mascota/gato/{id} → Modifica un gato existente.
DELETE /Mascota/{id} → Elimina una mascota.
GET /Mascota/mayores-a/{edad} → Obtiene mascotas mayores a la edad indicada.
GET /Mascota/tipo/{tipo} → Obtiene mascotas según su tipo (perro o gato).
Tecnologías
C#
ASP.NET Core Web API
.NET
Swagger
Git / GitHub

La información se mantiene únicamente en memoria, por lo que los cambios se pierden al reiniciar la aplicación.
