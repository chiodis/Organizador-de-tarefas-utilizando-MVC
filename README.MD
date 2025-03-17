# Organizador de Tarefas

Este é um projeto de exemplo de um Organizador de Tarefas utilizando o padrão MVC (Model-View-Controller) em C# com Entity Framework Core.
Neste projeto eu fiz a view no nosso terminal e a cada operação que voce faz no terminal atraves do nosso menu, ela é alterada diretamente no banco de dados.

~ Certifique-se de conectar o banco corretamente de acordo com o que eu vou explicar abaixo para ter sucesso com as operações crud.


## Funcionalidades

- **Model**: Representa os dados e a lógica de negócios. No projeto, temos a classe `TarefaSimples` que representa uma tarefa.
- **View**: Responsável pela interface com o usuário. No projeto, temos a classe `TarefaView` que exibe o menu e interage com o usuário.
- **Controller**: Intermedia a comunicação entre a View e o Model. No projeto, temos a classe `TarefaController` que gerencia as operações de CRUD (Create, Read, Update, Delete) das tarefas.

## Estrutura do Projeto

OrganizadorDeTarefas
 Controllers        
 └── TarefaController.cs 
             Models │ 
                ├── OrganizadorContext.cs
                ├── TarefaSimples.cs 
                ├──TarefaBase.cs
                └──TarefaBase.cs
                   Views  
                    └── TarefaView.cs 
                            
                             ├── Program.cs 
                             ├── appsettings.json 
                             └── OrganizadorDeTarefas.csproj

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior
- SQL Server

## Configuração

1. Clone o repositório:

   ```sh
   git clone https://github.com/chiodis/Organizador-de-tarefas-utilizando-MVC.git
   cd Organizador-de-tarefas


2. Instale as dependencias:  <br>
    dotnet restore <br>
    dotnet build
<br>

3. Instale as ferramentas do Entity Framework Core:
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer<br>
   dotnet add package Microsoft.EntityFrameworkCore.Tools<br>
   dotnet add package Microsoft.EntityFrameworkCore.Desing<br>
   dotnet tool install --global dotnet-ef<br>
<br>

  */Caso o seu json nao de certo e fique dando erro justamente as configurações do program.cs gerado, voce pode rodar no seu terminal:
    dotnet add package Microsoft.Extensions.Configuration
    dotnet add package Microsoft.Extensions.Configuration.json
    /*
<br>
   

4. Configure sua conection string de acordo com o sgbd que voce queira usar, no meu caso usei SQL server, entao usei : <br>

appsettings.json<br>
    {<br>
  "ConnectionStrings": {<br>
    "ConexaoPadrao": "Server=localhost\\sqlexpress;Database=OrganizadorDeTarefas;Trusted_Connection=True;"<br>
  }<br>
}<br>
<br>

5. Adicione as migrações e atualize o banco de dados:<br>
    dotnet ef migrations add InitialCreate<br>
    dotnet ef database update<br>
    

6.Rode o Projeto utilizando:<br>
    dotnet run
