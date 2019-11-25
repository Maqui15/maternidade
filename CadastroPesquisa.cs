using System;
using System.IO;
using System.Text;

public class CadastroPesquisa
{
  
  public CadastroPesquisa()
  {

  }


  public void Cadastrar(Bebes instancia)
  {
    FileStream dadosBebes = new FileStream("dados.txt", FileMode.Append, FileAccess.Write);
    StreamWriter escrita = new StreamWriter(dadosBebes, Encoding.UTF8);

    escrita.WriteLine(instancia.getNome());
    escrita.WriteLine(instancia.getDataNasc());
    escrita.WriteLine(instancia.getSexo());

    escrita.Close(); 
    dadosBebes.Close();
  }
  

  public void Pesquisar()
  {
    Console.WriteLine("Digite o nome do bebe que vc deseja procurar.");
    string nomeBebe = Console.ReadLine();

    FileStream dadosBebes = new FileStream("dados.txt", FileMode.Open, FileAccess.ReadWrite);

    StreamReader leitura = new StreamReader(dadosBebes, Encoding.UTF8);
    Console.Clear();
    Console.WriteLine("-----------------------------------------------------------------------");
    while(!leitura.EndOfStream)
    {
      string verificacao = leitura.ReadLine();

      if(verificacao == nomeBebe)
      {
        for(int i=0; i<3; i++)
        {
        
        Console.WriteLine(verificacao);
        verificacao = leitura.ReadLine();
        }
      }
    }
    leitura.Close();
    dadosBebes.Close();
    

    Console.WriteLine("------------------BERÇÁRIO------------------");
    Console.WriteLine();
    FileStream Bbtxt = new FileStream("banco.txt", FileMode.Open, FileAccess.Read);

    StreamReader leitura2 = new StreamReader(Bbtxt, Encoding.UTF8);

    for(int i=0; i<5; i++)
    {
      for(int j=0; j<4; j++)
      { string leit;

        leit = leitura2.ReadLine();
        Console.Write(" {0} ", leit);

      }

      Console.WriteLine();

    }
    leitura2.Close();
    Bbtxt.Close();
    Console.WriteLine("-----------------------------------------------------------------------");

  }    
  
}