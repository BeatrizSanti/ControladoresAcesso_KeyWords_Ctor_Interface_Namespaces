using Aula4_ControladoresAcesso.Classes;

//Exemplos controlador privado


var exemploPrivado1 = new MinhaClassePrivada();
exemploPrivado1.numeroPrivado = 1; //Note a propriedade não sendo encontrada

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
//--------------------------------------------------------------------------

var exemploPrivado2 = new PessoaPrivada();
exemploPrivado2.Nome = "Teste";
Console.WriteLine(exemploPrivado2.Nome); //Essa propriedade é acessível (public)
Console.WriteLine(exemploPrivado2.nome); //Essa propriedade não é acessível (private)

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
//--------------------------------------------------------------------------

var exemploPrivado3 = new ExemploPrivado();
exemploPrivado3.MetodoPublico(); //Esse método é acessível (public)
exemploPrivado3.MetodoPrivado(); //Esse método não é acessível (private), mas está sendo chamado dentro do público





//Exemplos controlador protected


var exemploProtected1 = new PessoaProtected();
exemploProtected1.nome = "teste"; //Note a propriedade não sendo encontrada

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
//--------------------------------------------------------------------------