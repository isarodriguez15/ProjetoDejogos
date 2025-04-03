using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogoRepository 
    {
        //1. Cadastrar();
        //2. Listar();
        //3. Deletar();
        //4. Atualizar();

        void Cadastrar(Jogo jogoNovo);
        void Deletar(Guid id);
        List<Jogo>List(Guid id);
        void Atualizar(Guid id, Jogo jogoAtualizado);
        

    }
}
