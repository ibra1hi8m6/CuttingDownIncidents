# Cutting Down Incidents

![.NET Version](https://img.shields.io/badge/.NET-9-512BD4?logo=dotnet)
![Angular Version](https://img.shields.io/badge/Angular-19-DD0031?logo=angular)
![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927?logo=microsoft-sql-server)

## 📝 Project Description

A comprehensive incident management system featuring:
- **Backend API**: Robust .NET 9 service layer
- **Web Interface**: Modern Angular 19 application
- **Admin Tools**: .NET 9 console utilities

## 📂 Project Structure

      ```mermaid
         graph TD
          A[Root Directory] --> B[CuttingDownIncidents/]
          A --> C[FrontendWETask/]
          A --> D[ConsoleAppWETask/]
          B -->|ASP.NET Core 9| E[Backend API]
          C -->|Angular 19| F[Web Interface]
          D -->|.NET 9| G[Console Utilities]

## 🛠 Technology Stack

| Component       | Technology          |
|-----------------|---------------------|
| **Backend**     | ASP.NET Core 9      |
| **Frontend**    | Angular 19          |
| **CLI Tools**   | .NET 9 Console      |
| **Database**    | SQL Server          |

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (LTS version recommended)
- Angular CLI (`npm install -g @angular/cli`)
- IDE (VS Code or Visual Studio)

### Installation & Running

1. **Backend API**
   ```bash
   cd CuttingDownIncidents
   dotnet restore
   dotnet run
   # API available at https://localhost:5001


 

2. **Frontend Components**
   ```bash
   cd FrontendWETask
   npm install
   ng serve --open
   # Opens http://localhost:4200


3. **Console Utilities**
   ```bash
   cd ConsoleAppWETask
   dotnet restore
   dotnet run
