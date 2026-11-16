# StreamApp (.NET 10 Web API + PostgreSQL + Docker)

Aplicación Web API en .NET 10 conectada a una base de datos PostgreSQL y contenerizada mediante Docker.

## Requisitos previos
- Docker y Docker Compose
- .NET 10 SDK (opcional si deseas desarrollo local sin Docker)

## Instrucciones de ejecución con Docker

1. Copia el archivo de entorno de ejemplo:
   ```bash
   cp .env.example .env
   ```

2. Levanta los contenedores usando el archivo `contructor.yml`:
   ```bash
   docker compose -f contructor.yml up --build
   ```

3. Accede a Swagger UI en tu navegador:
   `http://localhost:8080/swagger`
