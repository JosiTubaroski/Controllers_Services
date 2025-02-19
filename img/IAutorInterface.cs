using WebAPI8_Video.Models;

namespace WebAPI8_Video.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();

        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);

        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);


    }
}
