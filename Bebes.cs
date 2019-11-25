using System;
using System.IO;
using System.Text;

  public class Bebes
  {
    private string  _nome;
    private string  _dataNasc;
    private string  _sexo;

    public Bebes (string nome, string dataNasc, string sexo)
    {
      this._nome = nome;
      this._dataNasc = dataNasc;
      this._sexo = sexo;
    }

    public string getNome()
    {
      return _nome;
    }

    public void setNome(string _nome)
    {
      this._nome = _nome;
    }

    public string getDataNasc()
    {
      return _dataNasc;
    }

    public void setDataNasc(string _dataNasc)
    {
      this._dataNasc = _dataNasc;
    }

    public string getSexo()
    {
      return _sexo;
    }

    public void setSexo(string _sexo)
    {
      this._sexo = _sexo;
    }

    public  Bebes()
    {

    }
  }
