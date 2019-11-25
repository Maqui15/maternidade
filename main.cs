using System;

class MainClass {
  public static void Main (string[] args) {
    
    string resposta;

    Bercario berc = new Bercario();
    CadastroPesquisa Acesso = new CadastroPesquisa();
    bool resposta1 = true;


    while(resposta1 == true)
    {

    Console.WriteLine("Você deseja cadastrar ou pesquisar?");
    resposta = Console.ReadLine();

    if (resposta == "cadastrar" || resposta == "CADASTRAR" || resposta == "Cadastrar")
    {      
      string nome;
      string data;
      string sexo;  

      Console.WriteLine("Qual o nome do Bebê?");
      nome = Console.ReadLine();
      Console.WriteLine("Qual a data de nascimento do bebê ?");
      data = Console.ReadLine();
      Console.WriteLine("Qual o sexo do Bebê?");
      sexo = Console.ReadLine();

      Bebes baby = new Bebes(nome, data, sexo);
      //Console.WriteLine(baby.getNome());
      berc.ChecarBebes(baby);
      Acesso.Cadastrar(baby);
    }else
    {
     Acesso.Pesquisar(); 
    }
    }
    
  }
}