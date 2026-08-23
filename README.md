# WebBarber

Sistema de gerenciamento para barbearia desenvolvido como projeto de estudo utilizando **C#**, **ASP.NET Core MVC**, **Entity Framework Core** e **SQL Server**.

O objetivo do projeto é simular um sistema real de gerenciamento de uma barbearia, permitindo praticar desenvolvimento web, orientação a objetos, banco de dados, CRUD, validações, regras de negócio, Repository Pattern, Entity Framework Core e boas práticas de desenvolvimento.

---

## 🚧 Status do projeto

**Em desenvolvimento**

O projeto possui atualmente a estrutura base do ASP.NET Core MVC, conexão com SQL Server, Entity Framework Core, migrations e Repository Pattern.

Os módulos de **Clientes** e **Serviços** estão em desenvolvimento.

### Funcionalidades atuais

- Estrutura ASP.NET Core MVC
- Conexão com SQL Server
- Entity Framework Core
- Migrations
- Repository Pattern
- Cadastro de clientes
- Edição de clientes
- Exclusão de clientes
- Validação de dados
- Estrutura inicial do cadastro de serviços

---

## 🛠️ Tecnologias

- C#
- .NET 8
- ASP.NET Core MVC
- Razor
- Entity Framework Core
- SQL Server
- HTML5
- CSS3
- Bootstrap
- Git
- GitHub

---

## 📂 Estrutura atual

```text
WebBarber
│
├── Controllers
│   ├── ClientesController.cs
│   ├── ServicosController.cs
│   └── HomeController.cs
│
├── Data
│   └── BancoContext.cs
│
├── Migrations
│   ├── Migrations relacionadas a Clientes
│   ├── Migrations relacionadas a Serviços
│   └── BancoContextModelSnapshot.cs
│
├── Models
│   ├── ClientesModel.cs
│   ├── ServicosModel.cs
│   ├── ErrorViewModel.cs
│   └── Enums
│       └── StatusServico.cs
│
├── Repositorio
│   ├── ClientesRepositorio.cs
│   ├── IClientesRepositorio.cs
│   ├── ServicosRepositorio.cs
│   └── IServicosRepositorio.cs
│
├── Views
│   ├── Clientes
│   │   ├── ApagarConfirmar.cshtml
│   │   ├── Criar.cshtml
│   │   ├── Editar.cshtml
│   │   └── Index.cshtml
│   │
│   ├── Servicos
│   │   ├── Criar.cshtml
│   │   ├── Editar.cshtml
│   │   ├── Inativar.cshtml
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
│
├── appsettings.json
├── Program.cs
└── README.md