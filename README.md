<div> 
<p><a href="https://github.com/JosiTubaroski/WEB-API-com-.NET-8-e-SQL-Server">Home</a></p>
</div> 


### Qual a finalidade do Services em .NET8?

No .NET 8, os Services são classes usadas para organizar a lógica de negócios da aplicação, separando responsabilidades e facilitando a manutenção do código. Eles geralmente contêm regras de negócio e interagem com Repositórios (Repository Pattern) para acessar os dados.

A principal finalidade dos Services é criar uma camada intermediária entre os Controllers (ou endpoints da API) e os Repositórios ou outras fontes de dados.

### Principais finalidades dos Services no .NET 8

✔ Separação de responsabilidades – Evita que os Controllers fiquem sobrecarregados com lógica de negócio.
✔ Reutilização de código – A mesma lógica pode ser utilizada em diferentes partes da aplicação.
✔ Facilidade de teste (Testabilidade) – Como os Services são separados, fica mais fácil criar testes unitários sem depender de Controllers ou do banco de dados diretamente.
✔ Facilidade na manutenção e escalabilidade – Mantém o código modular e organizado.


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
