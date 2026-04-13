## 🎫 Gestão de Chamados em C#

Projeto desenvolvido com o objetivo de praticar conceitos fundamentais de **C#** e do framework **ASP.NET Core**, construindo uma API RESTful para simular um sistema de Help Desk.

### 📌 Sobre o projeto

Permite o gerenciamento completo do ciclo de vida de chamados de suporte técnico (tickets). O sistema oferece operações de abertura, acompanhamento, atualização de status e exclusão de chamados.

O foco principal do projeto é a estruturação de uma aplicação web utilizando a arquitetura **MVC (Model-View-Controller)**, a persistência de dados através do **Entity Framework Core** e a aplicação de regras de negócio em rotas HTTP.


### 🚀 Funcionalidades

- Abertura de chamados
- Listagem geral
- Busca por chamado em específico (ID)
- Atualização e Resolução
- Exclusão


### 🧠 Conceitos aplicados

- Linguagem C# e ecossistema .NET
- Construção de APIs RESTful (Verbos **GET, POST, PUT, DELETE**)
- Padrão de Arquitetura MVC (``Models`` e ``Controllers``)
- Mapeamento Objeto-Relacional (ORM) com Entity Framework Core
- Injeção de Dependência (Dependency Injection)
- Persistência com Banco de Dados em Memória (``InMemoryDatabase``)
- Aplicação de ``Enums`` para forte tipagem e controle de status
- Documentação interativa e testes de rotas com Swagger


### 🗂️ Estrutura do projeto

```text
help-desk/
 ├── Controllers/
 │    └── ChamadosController.cs
 │
 ├── Data/
 │    └── AppDbContext.cs
 │
 ├── Models/
 │    └── Chamado.cs
 │
 ├── Program.cs
 └── help-desk.csproj
```

### ▶️ Como executar o projeto  
🔹 Clonando o Repositório
   ```sh
   git clone https://github.com/lucasherrerods/help-desk
   ```
🔹 Acesse a pasta do projeto e execute
   ```sh
   cd help-desk
   dotnet run
   ```
🔹 Testando a API  
Abra o seu navegador e acesse a interface do Swagger gerada pelo terminal (``http://localhost:5172/swagger``) para interagir com os endpoints.
