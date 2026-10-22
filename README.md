# ASP.NET Core API Versioning

A simple ASP.NET Core Web API project demonstrating how to implement API versioning while maintaining backward compatibility with existing clients.

The project provides two versions of a Products API. Both versions run within the same application, but each returns a different response structure.

## Technologies Used

- C# / .NET 10
- ASP.NET Core Web API
- Asp.Versioning.Mvc
- Asp.Versioning.Mvc.ApiExplorer
- Postman for API testing
- Git & GitHub

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/mogamal1111/ApiVersioningDemo.git
cd ApiVersioningDemo
```

### 2. Restore Dependencies

Make sure the .NET 10 SDK is installed, then run:

```bash
dotnet restore
```

### 3. Run the Application

```bash
dotnet run
```

The application will start on the configured local port. With the included launch settings, the HTTP endpoint is:

`http://localhost:5120`

## API Endpoints

### Version 1

**GET** `/api/v1/products`

Returns product information using the original response structure.

Example response:

```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 25000
  },
  {
    "id": 2,
    "name": "Mouse",
    "price": 500
  }
]
```

### Version 2

**GET** `/api/v2/products`

Returns the same product information with an additional `categoryName` property.

Example response:

```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 25000,
    "categoryName": "Electronics"
  },
  {
    "id": 2,
    "name": "Mouse",
    "price": 500,
    "categoryName": "Accessories"
  }
]
```

## How API Versioning Works

This project uses **URL Path Versioning**, where the requested API version is included directly in the URL.

For example:

- `/api/v1/products` routes to the V1 ProductsController.
- `/api/v2/products` routes to the V2 ProductsController.

Each controller declares its supported version using the `ApiVersion` attribute.

API versioning is configured in `Program.cs` using `UrlSegmentApiVersionReader`.

This allows existing clients to continue using V1 while newer clients use V2 without changing the original response contract.

## Testing with Postman

1. Start the application using `dotnet run`.
2. Open Postman and create a new HTTP request.
3. Select the `GET` method.
4. Enter `http://localhost:5120/api/v1/products`.
5. Click **Send** and verify the response returns `200 OK`.
6. Change the URL to `/api/v2/products` and send the request again.
7. Verify that V2 includes `categoryName`, while V1 does not.

You can also request `/api/v3/products` to verify how the application handles an unsupported API version.

## Key Takeaways

- Multiple API versions can coexist in the same ASP.NET Core application.
- Existing clients can continue using older versions without breaking changes.
- URL-based versioning makes the requested version explicit.
- Each version can expose a different response contract.
- Postman can be used to verify the behavior of each endpoint.
  

## Author

**Mohamed Gamal**

Machine Learning & Deep Learning Engineer

GitHub: https://github.com/mogamal1111

LinkedIn: https://www.linkedin.com/in/mohamed-gamal-85795735b
