# Repository Patterns


<div> 
<p><a href="https://github.com/JosiTubaroski/WEB-API-com-.NET-8-e-SQL-Server">Home</a></p>
</div> 

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

- Dentro da Pasta Services, criar a pasta Autor

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/02_Pasta_Autor.png"/>

- Criar a classe AutorService.cs

 <img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/03_AutorService.png"/> 

- Criar a Interface IAutorInface.cs

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/04_InterfaceAutor.png"/>

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/05_Menu_Interface.png"/>

https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/AutorService.cs

# 🔍 Detalhamento do Código (AutorService)

O código faz parte de uma camada de serviços de uma API em .NET 8. Ele gerencia operações relacionadas aos autores em um banco de dados.

Ele usa:

- Entity Framework Core (EF Core) para interação com o banco de dados.
- AppDbContex como o contexto do banco de dados.
- ResponseModel<T> como um modelo de resposta genérico.
- Métodos para buscar e listar autores.

# 🏗 Estrutura e Explicação

### 🔹 1. Namespaces e Dependências

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/06_Importacao_Bibliotecas.png"/>

Aqui, importamos:

- Microsoft.EntityFrameworkCore: Para usar EF Core e manipular o banco de dados.
- WebAPI8_Video.Data: Acesso ao contexto do banco (AppDbContex).
- WebAPI8_Video.Models: Modelos que representam as entidades do banco.

### 🔹 2. Declaração da Classe AutorService

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/07_Public_AutorService.png"/>

- AutorService implementa a interface IAutorInterface, garantindo que a classe siga um contrato de métodos a serem implementados.

### 🔹 3. Construtor com Injeção de Dependência

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/08_Construtor_Dependencia.png"/>

- _context é uma instância de AppDbContex, que representa o banco de dados.
- Injeção de dependência: O context é passado no construtor para permitir operações no banco sem precisar instanciá-lo diretamente.

### 🔹 4. Métodos da Classe

#### 🛑 BuscarAutorPorId(int idAutor)

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/09_P_Metodo.png"/>

- Está apenas declarado, sem implementação.
- Quando chamado, lança uma exceção (NotImplementedException).
- Deve futuramente buscar um autor pelo idAutor.

#### 🛑 BuscarAutorPorIdLivro(int idLivro)

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/10_S_Metodo.png"/>

- Também não está implementado ainda.
- Deve futuramente buscar um autor com base no ID do livro.

#### ✅ ListarAutores()
