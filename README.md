### 📌 AppInvestimento

API desenvolvida em **.NET (C#)** utilizando **Entity Framework Core** e **SQL Server**, seguindo boas práticas de arquitetura em camadas (Controller, Application, Domain, Infra.Data, Infra.IoC). O objetivo desta API é fornecer endpoints para fazer o controle de uma carteira de investimentos, permitindo a criação, atualização, busca e deleção (CRUD).

### 🚀 Tecnologias Utilizadas
- **.NET 6 (C#)**
- **Entity Framework Core** (ORM)
- **SQL Server** (Banco de Dados Relacional)
- **Swagger** (Documentação da API)
- **Dependency Injection (IoC)**
- **AutoMapper**

📂 Estrutura do Projeto <br>

src/ <br>
 ├── Project.API           → Controllers e Configurações da API <br>
 ├── Project.Application   → Casos de uso, DTOs, Services <br>
 ├── Project.Domain        → Entidades e Interfaces de Repositório <br>
 ├── Project.Infra.Data    → Contexto EF Core, Mapeamentos, Repositórios <br>
 ├── Project.Infra.IoC     → Configurações de Injeção de Dependência <br>
