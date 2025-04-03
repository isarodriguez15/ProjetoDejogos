using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IUsuariosRepository
    {

        void Cadastrar(Usuarios usuariosNovo);
        void Deletar(Guid id);
        List<Usuarios> List(Guid id);
        void Atualizar(Guid id, Usuarios usuariosAtualizado);
    }
}
