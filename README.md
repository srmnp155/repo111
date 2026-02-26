# ProductSellingWebsite

An interactive product selling website built with ASP.NET Core MVC (.NET 7).

## Features

- Home page with featured products
- Product listing and details page
- Shopping cart functionality
- Responsive design with Bootstrap 5

## Requirements

- .NET 7 SDK (https://dotnet.microsoft.com/download)

## Getting Started

1. Clone the repository:
   `git clone <repo-url>`
2. Navigate to the project directory:
   `cd ProductSellingWebsite`
3. Build the project:
   `dotnet build`
4. Run the application:
   `dotnet run --project ProductSellingWebsite`
5. Open a browser and navigate to `https://localhost:5001` or `http://localhost:5000`.

## Docker

Build Docker image:
```
docker build -t productsellingwebsite .
```

Run container:
```
docker run -d -p 8080:80 --name productsellingwebsite productsellingwebsite
```

## Contributing

Feel free to submit issues or pull requests.

## License

MIT
