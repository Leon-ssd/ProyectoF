StreamApp - API .NET 10 con PostgreSQL y Docker
API RESTful desarrollada en .NET 10 con persistencia en PostgreSQL 16, contenerizada con Docker Compose y publicada en Docker Hub.

Integrantes y tablas asignadas
Emanuel Rafael Kilibarda Rocha: Tabla Videos (VideosController con CRUD completo: POST, GET lista, GET por ID, PUT y DELETE).

Enlaces del proyecto
Imagen en Docker Hub: emanuelxd/stream-api:latest (URL: https://hub.docker.com/r/emanuelxd/stream-api)

Repositorio Git: Rama rama-emanuel

Requisitos previos
Docker y Docker Compose instalados.

Crear un archivo .env en la raiz tomando como base .env.example.

1. Ejecucion en modo construccion (contructor.yml)
Construye la imagen desde el codigo fuente y levanta la API junto a PostgreSQL ejecutando:

docker compose --env-file .env -f contructor.yml up -d --build
2. Ejecucion en modo despliegue (despliegue.yml)
Descarga la imagen publicada desde Docker Hub sin compilar codigo fuente ejecutando:

docker compose --env-file .env -f despliegue.yml up -d
3. Verificacion de endpoints
Swagger UI: http://localhost:8080/swagger

Endpoints: POST /api/Videos, GET /api/Videos, GET /api/Videos/{id}, PUT /api/Videos/{id}, DELETE /api/Videos/{id}

4. Apoyo de IA para preparar despliegue.yml
Consulta realizada: Consulte a una inteligencia artificial como adaptar el archivo de construccion (contructor.yml) hacia un archivo de despliegue independiente (despliegue.yml) que descargue directamente la imagen publica desde Docker Hub (emanuelxd/stream-api:latest) en lugar de compilar con build, manteniendo la red bridge, el volumen persistente de PostgreSQL y la lectura de variables de entorno desde .env (ademas de apoyar en la redaccion de esta documentacion).

Verificacion de la propuesta: Detuve los contenedores locales de construccion, ejecute docker compose --env-file .env -f despliegue.yml up -d, verifique con docker ps que la imagen en ejecucion fuera la descargada desde Docker Hub y probe los endpoints CRUD en Swagger UI comprobando respuestas HTTP 201 y 200.
