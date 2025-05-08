# ChatPusher 💬 - Application de Chat Instantané

[![.NET](https://img.shields.io/badge/.NET-7.0-blue)](https://dotnet.microsoft.com/)
[![SignalR](https://img.shields.io/badge/SignalR-5.0-green)](https://dotnet.microsoft.com/apps/aspnet/signalr)

Une application de messagerie instantanée en temps réel développée avec ASP.NET MVC, SignalR et Entity Framework Core.
 

## Fonctionnalités Clés 🚀
- **Messagerie en temps réel** avec SignalR
- Authentification utilisateur avec **ASP.NET Identity**
- Création de **salles de discussion privées/publiques**
- Historique des messages persisté en base de données
- Notifications en temps réel
- Indicateur "En train d'écrire"
- Partage de fichiers (images, documents)
- Interface responsive compatible mobile

## Stack Technologique 💻
- **Backend**: ASP.NET MVC Core 7
- **Realtime**: SignalR
- **Base de Données**: SQL Server (Entity Framework Core)
- **Frontend**: Bootstrap 3, jQuery
- **Authentification**: ASP.NET Core Identity 

## Installation 🔧

### Prérequis
- .NET SDK 
- SQL Server 2019+
- Visual Studio 2019+

### Configuration
```bash
# Cloner le dépôt
git clone https://github.com/vignyl/ChatPusher.git

# Restaurer les packages NuGet
dotnet restore

# Configurer la chaîne de connexion dans appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ChatterBox;Trusted_Connection=True;"
  }
}

# Appliquer les migrations
dotnet ef database update
