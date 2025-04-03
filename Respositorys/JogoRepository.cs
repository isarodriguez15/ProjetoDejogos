using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Respositorys
{
    public class JogoRepository : IJogoRepository
    {
        //Herdar da Interface
        //Implementar os metodos da Interface
        //Criar a variavel que puxa informacoes do Context  

        private readonly ProjetoJogosContext _context;


        public JogoRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();

                _context.Jogos.Add(jogoNovo);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Jogo jogoNovo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Jogo> List(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
