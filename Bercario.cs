using System;
using System.IO;
using System.Text;

public class Bercario
{
 
  private string[,] berc = new string[5,4];
  private int contador = 1;
  private string escolha;
  private bool pre = true;




  public Bercario()
  {

  }

  public Bercario(string escolha)
  {
    this.escolha  = escolha;
  }


  public void ChecarBebes(Bebes instancia)
  {
    if (pre == true)
    {
      
      for(int i=0; i<5; i++)
      {
        for(int j=0; j<4; j++)
        {
        
        berc[i,j] = contador.ToString();

        Console.Write(" {0} ", contador);
        
        contador++;
        }

        Console.WriteLine();
      }
    }
    
    if(pre == false)
    {
      for(int i=0; i<5; i++)
      {
        for(int j=0; j<4; j++)
        {

        Console.Write(" {0} ",berc[i,j]);
        
        }

        Console.WriteLine();
      }
    }
      pre = false;
      FileStream Bbtxt = new FileStream("banco.txt", FileMode.Open, FileAccess.Read);

      StreamReader leitura3 = new StreamReader(Bbtxt, Encoding.UTF8);

      // for(int i=0; i<5; i++)
      // {
      // for(int j=0; j<4; j++)
      // { 
      
      // }

      // Console.WriteLine();

      // }

      // for(int i=0; i<5; i++)
      // {
      //   for(int j=0; j<4; j++)
      //   { string leit;
        
        
      //     leit = leitura3.ReadLine();
      //     Console.Write(" {0} ", leit);

      //   }

      //   Console.WriteLine();

    
    leitura3.Close();
    Bbtxt.Close();
    Console.WriteLine("Escolha um Número.");
    escolha = Console.ReadLine();

    for(int i=0; i<5; i++)
    {
      for(int j=0; j<4; j++)
      {
        if(berc[i,j]== escolha)
        {
          berc[i,j] = instancia.getNome();
        }

      }
    }

    // for(int i=0; i<5; i++)
    // {
    //   for(int j=0; j<4; j++)
    //   {

    //     Console.Write(" {0} ", berc[i,j]);
        
    //   }

    //   Console.WriteLine();
    // }
    contador =1;
    Txt();
  }

  public void Txt()
  {

  
  FileStream Bbtxt = new FileStream("banco.txt", FileMode.Open, FileAccess.Write);
  StreamWriter escrita2 = new StreamWriter(Bbtxt, Encoding.UTF8);

  for(int i=0; i<5; i++)
  {
    for(int j=0; j<4; j++)
    {
      escrita2.WriteLine(berc[i,j]);
    }
  }

  escrita2.Close();
  Bbtxt.Close();

  }
}