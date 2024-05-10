namespace Aula4_ControladoresAcesso.Classes
{
    /// <summary>
    /// Aqui temos uma classe com a propriedade numeroPrivado inacessível por outras classes (visualizar na program.cs o erro)
    /// </summary>
    public class MinhaClassePrivada
    {
        private int numeroPrivado;

        public void SetNumero(int novoNumero)
        {
            numeroPrivado = novoNumero;
        }

        public int GetNumero()
        {
            return numeroPrivado;
        }
    }

    /// <summary>
    /// Propriedade sendo utilizada para definição de valor interno na classe (funciona igual o exemplo acima)
    /// </summary>
    public class PessoaPrivada
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

    /// <summary>
    /// Método privado
    /// </summary>
    public class ExemploPrivado
    {
        private void MetodoPrivado()
        {
            // Código do método privado
        }

        public void MetodoPublico()
        {
            //Acessível dentro do contexto da classe
            MetodoPrivado();
        }
    }

}
