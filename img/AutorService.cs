using Microsoft.EntityFrameworkCore;
using WebAPI8_Video.Data;
using WebAPI8_Video.Models;

namespace WebAPI8_Video.Services.Autor
{
    public class AutorService : IAutorInterface
    {
        private readonly AppDbContex _context;
        public AutorService(AppDbContex context) 
        {
            _context = context;
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                var autores = await _context.Autores.ToListAsync();

                resposta.Dados = autores;
                resposta.Mensagem = "Todos os autores foram coletados!";

                return resposta;

            }catch (Exception ex) 
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
            
        }


    }
}
