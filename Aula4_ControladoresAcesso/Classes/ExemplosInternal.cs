using Aula4_ControladoresAcesso_Internal;

namespace Aula4_ControladoresAcesso.Classes
{
    // Assembly B
    public class OutraClasse
    {
        void Exemplo()
        {
            // Acesso à classe e membro internos só é permitido dentro do mesmo assembly (Assembly A)
            ClasseInterna instancia = new ClasseInterna();
            instancia.ValorInterno = 42;
        }
    }

    // Consumidor da Biblioteca
    public class Consumidor
    {
        void Exemplo()
        {
            // Acesso a membros internos não é permitido fora do assembly da biblioteca
            ImplementacaoInterna implementacao = new ImplementacaoInterna();
            implementacao.MetodoInterno(); // Erro de compilação
        }
    }
}
