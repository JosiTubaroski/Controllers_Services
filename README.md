# Repository Pattern / Controllers / Services


<div> 
<p><a href="https://github.com/JosiTubaroski/WEB-API-com-.NET-8-e-SQL-Server">Home</a></p>
</div> 

## Repository Pattern

O Repository Pattern é um <b>conceito</b> de design de software usado para <b>abstrair a camada de acesso a dados</b>, proporcionando uma maneira mais organizada e desacoplada de interagir com o banco de dados.

### 🔹 Como surgiu?

O padrão <b>Repository</b> vem do conceito <b>Domain-Driven Design (DDD)</b>, criado por <b>Eric Evans.</b>. A idéia central é evitar que a lógica de negócios interaja diretamente com a camada de persistência (banco de dados), promovendo um código mais modular e fácil de manter.

### 🔹 Como é utilizado no .NET 8?

No <b>.NET 8</b>, o <b>Repository Pattern</b> é amplamente utilizado em conjunto com o <b>Entity Framework Core (EF Core)</b> para gerenciar operações com o banco de dados.

### 🏛 1. Repository Pattern (Padrão de Repositório)

### 👉 O que é?

 O Repository Pattern é um padrão de arquitetura que tem o objetivo de criar uma camada de abstração entre a aplicação e o banco de dados. Ele centraliza o acesso aos dados, evitando que a lógica de negócios interaja diretamente com a camada de persistência.

 #### 📌 Principais características:

 - ✅ Encapsula a lógica de acesso ao banco de dados
 - ✅ Separa a lógica de negócios do acesso a dados
 - ✅ Facilita a troca de tecnologias de persistência (por exemplo, mudar do Entity Framework para Dapper)
 - ✅ Melhora a testabilidade, pois permite o uso de mocks

<p>✅ O Repository Pattern é uma arquitetura em relação a dados, pois ele define uma camada de abstração entre a aplicação e o banco de dados, organizando como os dados são acessados e manipulados.</p>

<p>✅ O MVC é uma arquitetura para a aplicação como um todo, pois organiza a estrutura do software separando a lógica de negócios (Model), a interface com o usuário (View) e o controle do fluxo de dados (Controller).</p>

#### 📌 Resumo prático:

- Repository Pattern → Organização da persistência de dados
- MVC → Organização da estrutura geral da aplicação

 Os dois podem ser usados juntos! O MVC define a estrutura geral da aplicação, e dentro do Model, podemos usar o Repository Pattern para lidar com os dados de forma desacoplada.

### Continuando com o código

- Criar a pasta Services

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/01_Pasta_Services.png"/>



