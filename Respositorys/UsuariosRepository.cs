using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Respositorys
{
    public class UsuariosRepository : IUsuariosRepository
    {
        //Herdar da Interface
        //Implementar os metodos da Interface
        //Criar a variavel que puxa informacoes do Context  

        private readonly ProjetoJogosContext _context;

        public UsuariosRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuarios usuarios)
        {
            try
            {
                //Tentar cadastrar:
                
            }
            catch (Exception)
            {
                //Se der erro, entra aqui
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> List(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
