Smart Office IAM API

Global Solution - O Futuro do Trabalho > Solução de Gestão de Identidades e Acessos (IAM) para escritórios inteligentes.

Integrantes do Grupo
- Kaio Vinicius Meireles Alves - RM553282
- Lucas Alves de Souza -  RM553956

Sobre o Projeto

Este projeto consiste no desenvolvimento de uma API RESTful utilizando a plataforma .NET Core. O objetivo é fornecer um serviço centralizado de gestão de usuários (Identity & Access Management) para um ambiente de Smart Office, permitindo o cadastro, controle e auditoria de acessos de colaboradores.

A solução atende aos requisitos da avaliação Global Solution, alinhando-se ao tema "O Futuro do Trabalho" e garantindo segurança e eficiência operacional.

Funcionalidades e Requisitos Atendidos

1. Boas Práticas REST (Nível 2 de Maturidade)

A API implementa os verbos HTTP de forma semântica e retorna os Status Codes adequados:

GET: Retorna dados (200 OK) ou erro se não encontrar (404 Not Found).

POST: Cria recursos e retorna o local do novo recurso (201 Created).

PUT: Atualiza recursos de forma idempotente (204 No Content).

DELETE: Remove recursos (204 No Content).

2. Versionamento da API

Utilizamos a estratégia de URI Versioning para garantir a evolução do software sem quebrar clientes antigos.

V1 (/api/v1/users): Focada nas operações essenciais de CRUD.

V2 (Roadmap): Planejada para incluir autenticação via token (JWT) e auditoria avançada.

3. Integração e Persistência

Entity Framework Core: Utilizado como ORM para mapeamento objeto-relacional.

SQL Server: Banco de dados relacional robusto para persistência segura das informações.

Migrations: Gerenciamento de esquema de banco de dados via código (Code-First).

4. Documentação

Swagger UI: Documentação interativa gerada automaticamente (disponível em /swagger).

Fluxo Arquitetural: Diagrama detalhando a comunicação entre Cliente, API e Banco de Dados.

Tecnologias Utilizadas

Linguagem: C# (.NET 8.0)

Framework: ASP.NET Core Web API

Banco de Dados: SQL Server 2022

ORM: Entity Framework Core

Documentação: Swashbuckle (Swagger)

IDE: Visual Studio Code

 Fluxo da Arquitetura

O diagrama abaixo ilustra o fluxo de dados da solução:

graph LR
    Client[ Cliente / Swagger UI] 
    API[ API .NET (SmartOffice)] 
    DB[( SQL Server)]

    style Client fill:#e1f5fe,stroke:#01579b,stroke-width:2px
    style API fill:#e8f5e9,stroke:#2e7d32,stroke-width:2px
    style DB fill:#fff3e0,stroke:#ef6c00,stroke-width:2px

    Client -- "1. Requisição HTTP (JSON)" --> API
    API -- "2. Processamento & Regras" --> API
    API -- "3. EF Core (Query/Save)" --> DB
    DB -- "4. Retorno dos Dados" --> API
    API -- "5. Resposta (200/201/204)" --> Client


(Obs: Caso o diagrama não renderize, verifique a imagem fluxo_arquitetura.png na raiz do repositório).

Como Rodar o Projeto

Pré-requisitos

.NET SDK 8.0 ou superior.

SQL Server (LocalDB ou Full) instalado e rodando.

Passo a Passo

Clone o Repositório:

git clone [https://github.com/SEU_USUARIO/GS_SmartOffice_Api.git](https://github.com/SEU_USUARIO/GS_SmartOffice_Api.git)
cd GS_SmartOffice_Api


Configure o Banco de Dados:
Verifique a Connection String no arquivo appsettings.json. Se estiver usando SQL Server local, certifique-se de que o servidor está correto (localhost ou (localdb)\mssqllocaldb).

Aplique as Migrations:
Abra o terminal na pasta do projeto e execute:

dotnet ef database update


Execute a Aplicação:

dotnet run


Acesse a Documentação:
Abra o navegador em: http://localhost:5500/swagger

📹Vídeo Demonstrativo

Confira a demonstração da API funcionando, incluindo testes no Swagger e validação no banco de dados:

https://youtu.be/S9A44do0hbo

FIAP - Global Solution 2025
