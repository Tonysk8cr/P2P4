
# Parcial 2 Anthony Villalobos Hidalgo Progra 4 UH 2025

Repositorio de github para el parcial 2 del curso de programación 4 de la Universidad Hispanoamericana del III cuatrimestre de 2025, profesor a cargo: Ing. Melber Dalorzo Cruz




## Set up inicial

Asegúrate de que los siguientes paquetes NuGet esten instalados y que sus versiones sean compatibles con .NET 8:
```bash

 -Microsoft.EntityFrameworkCore.SqlServer

```

## API URLs

En esta sección vamos a describir las rutas de las APIs

URLS:
main: 
http://APIBiciAnthony.somee.com

GET: 
http://APIBiciAnthony.somee.com/Bicis/List

POST: 
http://APIBiciAnthony.somee.com/Bicis/Save
{
  "codBarra": "Cl01dT4est",
  "modelo": "Cloud",
  "annio": 2025,
  "precioVenta": 10,
  "proveedor": "UH",
  "fechaRegistro": "2025-12-11T02:50:46.037Z",
  "estado": "A"
}

PUT:
http://APIBiciAnthony.somee.com/Bicis/Update
{
  "codBarra": "Cl01dT4est",
  "modelo": "Cloud",
  "annio": 2025,
  "precioVenta": 10,
  "proveedor": "UH",
  "fechaRegistro": "2025-12-11T02:50:46.037Z",
  "estado": "A"
}

GET por id:
http://APIBiciAnthony.somee.com/Bicis/Search
Key: pCodBarra value: string

Delete:
http://APIBiciAnthony.somee.com/Bicis/Delete
Key: tCodBarra value: string