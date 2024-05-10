namespace Aula4_ControladoresAcesso.Classes
{
    /// <summary>
    /// Propriedade protegida
    /// </summary>
    public class ClasseBaseProtected
    {
        protected int numeroProtegido;

        protected void MetodoProtegido()
        {
            // Código do método protegido
        }
    }

    /// <summary>
    /// Propriedade protegida sendo acessada pela classe que herda
    /// </summary>
    public class ClasseDerivadaProtected : ClasseBaseProtected
    {
        public void Exemplo()
        {
            // Acesso ao membro protegido da classe base
            numeroProtegido = 42;
            MetodoProtegido();
        }
    }

    /// <summary>
    /// Propriedade protegida
    /// </summary>
    public class PessoaProtected
    {
        protected string nome;

        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }
    }

    /// <summary>
    /// Propriedade protegida sendo acessada pela classe que herda. Ver exemplo na program sobre acesso sem herdar
    /// </summary>
    public class ClienteProtected : PessoaProtected
    {
        public void Exemplo()
        {
            // Acesso ao membro protegido da classe base
            nome = "João";
        }
    }

    /// <summary>
    /// Método virtual para substituição
    /// </summary>
    public class AnimalProtected
    {
        protected virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal");
        }
    }

    /// <summary>
    /// Substituição do método virtual
    /// </summary>
    public class CachorroProtected : AnimalProtected
    {
        protected override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }

}
