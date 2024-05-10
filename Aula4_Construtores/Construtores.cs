namespace Aula4_Construtores
{
    public class ConstrutoresBase
    {
        public ConstrutoresBase(string nome, string endereco)
        {
            //Código do construtor base aqui
        }
    }

    //Construtor precisa ter o nome da classe
    public class Construtores : ConstrutoresBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        /// <summary>
        /// Construtor herdado da classe base
        /// </summary>
        public Construtores(string nome, string endereco) : base(nome, endereco)
        {
            
        }

        /// <summary>
        /// Construtor padrão, também considerado nessa estrutura caso não seja declarado
        /// </summary>
        //public Construtores()
        //{
        //    //Não possui retorno
        //}

        /// <summary>
        /// Construtor que recebe um Id como parâmetro
        /// </summary>
        public Construtores(int id)
        {
            Id = id;
            //Não possui retorno
        }

        /// <summary>
        /// Construtor chamando um outro construtor
        /// </summary>
        public Construtores() : this(42) { }

    }
}


