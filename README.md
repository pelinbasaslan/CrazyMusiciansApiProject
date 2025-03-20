# Crazy Musicians API Project

## Overview
The **Crazy Musicians API Project** is a simple RESTful API built with **ASP.NET Core** that manages a list of fictional musicians. Each musician has an ID, name, profession, and a fun trait. The API allows users to retrieve, search, add, update, and delete musicians.

## Features
- **GET /api/CrazyMusicians** → Returns all musicians.
- **GET /api/CrazyMusicians/{id}** → Returns a specific musician by ID.
- **GET /api/CrazyMusicians/search?name=xyz** → Searches for musicians by name.
- **POST /api/CrazyMusicians** → Adds a new musician.
- **PUT /api/CrazyMusicians/{id}** → Updates an existing musician.
- **DELETE /api/CrazyMusicians/{id}** → Deletes a musician.

## Technologies Used
- **ASP.NET Core**
- **C#**
- **Entity Framework Core (In-Memory List for Data Storage)**
- **Swagger (for API documentation and testing)**

## Installation and Setup
1. **Clone the repository:**
   ```sh
   git clone https://github.com/pelinbasaslan/CrazyMusiciansApiProject.git
   ```
2. **Navigate to the project directory:**
   ```sh
   cd CrazyMusiciansApiProject
   ```
3. **Run the project:**
   ```sh
   dotnet run
   ```

## API Endpoints

### Get All Musicians
```http
GET /api/CrazyMusicians
```
**Response:**
```json
[
  {
    "id": 1,
    "name": "Ahmet Çalgı",
    "profession": "Famous Instrument Player",
    "funTrait": "Always plays the wrong note, but it's so much fun"
  }
]
```

### Get a Musician by ID
```http
GET /api/CrazyMusicians/{id}
```
**Response:**
```json
{
  "id": 2,
  "name": "Zeynep Melodi",
  "profession": "Popular Melody Writer",
  "funTrait": "Her songs are misunderstood but very popular"
}
```

### Search for Musicians by Name
```http
GET /api/CrazyMusicians/search?name=Zeynep
```
**Response:**
```json
[
  {
    "id": 2,
    "name": "Zeynep Melodi",
    "profession": "Popular Melody Writer",
    "funTrait": "Her songs are misunderstood but very popular"
  }
]
```

### Add a New Musician
```http
POST /api/CrazyMusicians
```
**Request Body:**
```json
{
  "name": "New Musician",
  "profession": "Guitarist",
  "funTrait": "Loves playing solos randomly"
}
```
**Response:**
```json
{
  "id": 11,
  "name": "New Musician",
  "profession": "Guitarist",
  "funTrait": "Loves playing solos randomly"
}
```

### Update a Musician
```http
PUT /api/CrazyMusicians/{id}
```
**Request Body:**
```json
{
  "name": "Updated Name",
  "profession": "Updated Profession"
}
```
**Response:**
- `204 No Content` (Successful update)

### Delete a Musician
```http
DELETE /api/CrazyMusicians/{id}
```
**Response:**
- `204 No Content` (Successful deletion)

## Testing with Swagger
After running the project, open your browser and navigate to:
```
http://localhost:<port>/swagger/index.html
```
This will provide an interactive UI to test API endpoints.

## Author
[Pelin Başaslan](https://github.com/pelinbasaslan)

