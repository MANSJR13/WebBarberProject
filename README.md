# WebBarber

Sistema de gerenciamento para barbearia desenvolvido como projeto de estudo usando C#, ASP.NET Core MVC, Entity Framework Core e SQL Server.

---

## 🚧 Status do projeto

- Estado atual: Em desenvolvimento
- Alvo: .NET 8
- Framework web: ASP.NET Core MVC
- Repositório remoto: https://github.com/MANSJR13/WebBarberProject
- Branch principal: `main`
- Caminho local do repositório: `D:\WebBarber\WebBarber`

---

## 🛠️ Tecnologias

- .NET 8
- C#
- ASP.NET Core MVC (Controllers + Views)
- Razor (Views)
- Entity Framework Core
- SQL Server
- Git / GitHub

---

## 📂 Estrutura atual

``` text
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