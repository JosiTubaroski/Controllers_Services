<div> 
<p><a href="https://github.com/JosiTubaroski/WEB-API-com-.NET-8-e-SQL-Server">Home</a></p>
</div> 

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/01_Fx_Controller_Interface_Service_2.jpg"/>

### Qual a finalidade do Services em .NET8?

No .NET 8, os Services são classes usadas para organizar a lógica de negócios da aplicação, separando responsabilidades e facilitando a manutenção do código. Eles geralmente contêm regras de negócio e interagem com Repositórios (Repository Pattern) para acessar os dados.

A principal finalidade dos Services é criar uma camada intermediária entre os Controllers (ou endpoints da API) e os Repositórios ou outras fontes de dados.

### Principais finalidades dos Services no .NET 8

<p>✔ Separação de responsabilidades – Evita que os Controllers fiquem sobrecarregados com lógica de negócio.</p>
<p>✔ Reutilização de código – A mesma lógica pode ser utilizada em diferentes partes da aplicação.</p>
<p>✔ Facilidade de teste (Testabilidade) – Como os Services são separados, fica mais fácil criar testes unitários sem depender de Controllers ou do banco de dados diretamente.</p>
<p>✔ Facilidade na manutenção e escalabilidade – Mantém o código modular e organizado.</p>


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

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/11_Lista_Autores.png"/>

#### 🔹 Explicação:

1. Criação do objeto resposta:

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/12_Criar_Objeto_Resposta.png"/>

- ResponseModel<T> é um modelo genérico que encapsula o retorno (dados, status, mensagens).

2. Busca todos os autores no banco de dados:

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/13_BuscaAutores.png"/>

- ToListAsync() retorna todos os registros da tabela Autores de forma assíncrona.

3. Atribui os dados ao modelo de resposta:

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/14_RespostaAutores.png"/>

- resposta.Dados recebe a lista de autores.
- resposta.Mensagem informa que os dados foram recuperados com sucesso.

4. Tratamento de erros:

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/15_Tratamento_Erro.png"/>
   
- Se ocorrer um erro, captura a exceção e adiciona a mensagem no ResponseModel.

# Resumo Final

- ✅ AutorService é um serviço responsável pela manipulação de autores no banco de dados.
- ✅ Usa Entity Framework Core para acessar os dados.
- ✅ Lista todos os autores
- ✅ Retorna um modelo de resposta genérico (ResponseModel<T>) para padronizar as respostas.

# IAutorInterface.cs

https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/IAutorInterface.cs

### 🔹 O que esse código faz?

Ele define <b>uma interface chamada</b> IAutorInterface. Essa interface declara três métodos assíncronos relacionados a manipulação de <b>Autores.</b>

### 🔹 Explicação linha por linha

- 1️⃣ using WebAPI8_Video.Models;

Essa linha importa o namespace WebAPI8_Video.Models, que contém classes de modelos (provavelmente AutorModel e ResponseModel).

- 2️⃣ namespace WebAPI8_Video.Services.Autor

Define um <b>namespace</b> para organizar o código. Aqui, ele indica que esse código faz parte do módulo de <b>Serviços de Autor</b> dentro do projeto <b>WebAPI8_Video.</b>

- 3️⃣ public interface IAutorInterface

Declara uma <b>interface</b> chamada IAutorInterface.

- ✅ Interfaces definem contratos que as classes devem seguir.
- ✅ Essa interface será implementada por um Service que executará a lógica.

- 4️⃣ Métodos da Interface

  Agora, vamos ver os <b>métodos</b> que essa interface exige que uma classe implementadora defina.

   Task<ResponseModel<List<AutorModel>>> ListarAutores();

### 🔹 Conclusão

- ✅ Esse código define um contrato (IAutorInterface) que uma classe de serviço deve seguir para lidar com <b>Autores.</b>
- ✅ Ele organiza a API de forma <b>modular, reutilizável e testável.</b>
- ✅ Usa um <b>ResponseModel</b> para padronizar as respostas da API.

## Criando a Comunicação entre IAutorInterface e a AutorService dentro do arquivo Program.cs

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/01_Comunicacao_Services_Interface.png"/>

### Criando a ResponseModel.cs, que é a nossa Resposta Modelo.

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/02_Response_Model.png"/>

#### Detalhes do código.

https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/ResponseModel.cs

Esse código define uma <b>classe genérica</b> chamada ResponseModel<T> dentro do namespace WebAPI8_Video.Models. Essa classe é usada para estruturar respostas padronizadas em uma API. Vamos detalhar parte por parte:

### 1️⃣ Namespace e Importação

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/03_Inicio_Response.png"/>

- O namespace WebAPI8_Video.Models indica que essa classe pertence ao conjunto de modelos do projeto.
- A linha using WebAPI8_Video.Migrations; sugere que esse projeto contém migrations (alterações estruturais no banco de dados), mas essa importação não está sendo usada dentro dessa classe específica.

### 2️⃣ Definição da Classe Genérica

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/04_PublicClass_Response.png"/>

- ResponseModel<T> é uma <b>classe genérica</b>, onde <T> representa um <b>tipo genérico.</b>
- Isso significa que ResponseModel pode ser usada para diferentes tipos de dados, como ResponseModel<string>, ResponseModel<int>, ou até mesmo ResponseModel<Usuario>.

 ### 3️⃣ Propriedades da Classe

 <img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/04_Propriedade_Response.png"/>

 - Dados: Armazena a informação principal da resposta. O tipo é genérico (T?), então pode conter qualquer tipo de dado.
 - O ? (nullable) indica que Dados pode ser null.

 <img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/05_String_Response.png"/>

 - Mensagem: Campo usado para armazenar uma mensagem descritiva da resposta, como "Operação realizada com sucesso" ou "Erro ao processar requisição".
 - O valor padrão é string vazia (string.Empty).

  <img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/06_Response_True.png"/>

  - Status: Representa o sucesso (true) ou falha (false) da operação.
  - O valor padrão é true, assumindo que a maioria das respostas serão bem-sucedidas.

 ### 4️⃣ Exemplo de Uso

Vamos supor que essa classe seja usada em uma API para responder a uma requisição de login.

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/07_Response_Sucesso.png"/>

## Conclusão

A classe ResponseModel<T> é uma estrutura de resposta padronizada que melhora a <b>organização e legibilidade</b> da API. Ela permite que diferentes endpoints retornem respostas uniformes, tornando o consumo de API mais previsível e consistente.

# Agora vamos criar a nossa Controllers

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/20250226_Criando_Controller.png"/>

### O Controler será do tipo API

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/Controlers/02_Controler_API.png"/>

### Criando a AutorController.cs

<img src="https://github.com/JosiTubaroski/Controllers_Services/blob/main/img/Controlers/03_Criando_Autor_Controler.png"/>




 



