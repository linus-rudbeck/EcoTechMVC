### README

# EcoTech Solutions AB - Kontaktformulär

Detta projekt är en ASP.NET Core-webbapplikation som innehåller ett kontaktformulär. Formulärdatan sparas i en lokal MongoDB-databas.

## Innehållsförteckning

- [EcoTech Solutions AB - Kontaktformulär](#ecotech-solutions-ab---kontaktformulär)
  - [Innehållsförteckning](#innehållsförteckning)
  - [Förutsättningar](#förutsättningar)
  - [Installation](#installation)
  - [Konfiguration](#konfiguration)
  - [Kör applikationen](#kör-applikationen)

## Förutsättningar

Innan du börjar, se till att du har följande programvara installerad:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MongoDB](https://www.mongodb.com/try/download/community)

## Installation

1. Klona detta repo:

    ```bash
    git clone https://github.com/linus-rudbeck/EcoTechMVC.git
    cd EcoTechSolutionsAB
    ```

2. Installera nödvändiga NuGet-paket:

    ```bash
    dotnet restore
    ```

## Konfiguration

1. Öppna `appsettings.json` och kontrollera att MongoDB-anslutningssträngen och databasinformationen är korrekt:

    ```json
    {
      "MongoDB": {
        "ConnectionString": "mongodb://localhost:27017",
        "DatabaseName": "EcoTechSolutions",
        "CollectionName": "ContactForms"
      }
    }
    ```

2. Skapa en konfigurationsklass `MongoSettings.cs`:

    ```csharp
    public class MongoSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
    ```

## Kör applikationen

1. Bygg och kör applikationen:

    ```bash
    dotnet build
    dotnet run
    ```

2. Öppna din webbläsare och navigera till `https://localhost:{PORT}` där `PORT` är portnumret som visas i terminalen för att se applikationen.
