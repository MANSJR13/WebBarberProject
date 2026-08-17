# WebBarber



Sistema de gerenciamento para barbearia desenvolvido como projeto de estudo utilizando **C#**, **ASP.NET Core MVC**, **Entity Framework Core** e **SQL Server**.

O objetivo do projeto é simular um sistema real de gerenciamento de uma barbearia, permitindo praticar desenvolvimento web, orientação a objetos, banco de dados, CRUD, relacionamentos, regras de negócio e boas práticas de desenvolvimento.

---

## 🚧 Status do projeto

**Em desenvolvimento**

Atualmente o projeto possui a estrutura inicial do ASP.NET Core MVC, módulo de clientes em desenvolvimento, conexão com SQL Server, Entity Framework Core, migrations e Repository Pattern.

---

## 🛠️ Tecnologias

- C#
- ASP.NET Core MVC
- Razor
- Entity Framework Core
- SQL Server
- Git
- GitHub

---

## 📂 Estrutura atual

```text
WebBarber
│
├── Controllers
│   ├── ClientesController.cs
│   └── HomeController.cs
│
├── Data
│   └── BancoContext.cs
│
├── Migrations
│   ├── Migration de criação da tabela de Clientes
│   └── BancoContextModelSnapshot.cs
│
├── Models
│   ├── ClientesModel.cs
│   └── ErrorViewModel.cs
│
├── Repositorio
│   ├── ClientesRepositorio.cs
│   └── IClientesRepositorio.cs
│
├── Views
│   ├── Clientes
│   │   ├── ApagarConfirmar.cshtml
│   │   ├── Criar.cshtml
│   │   ├── Editar.cshtml
│   │   └── Index.cshtml
│   │
│   ├── Home
│   │   └── Index.cshtml
│   │
│   └── Shared
│       ├── _Layout.cshtml
│       ├── _ValidationScriptsPartial.cshtml
│       └── Error.cshtml
│
├── wwwroot
├── appsettings.json
├── Program.cs
└── README.md