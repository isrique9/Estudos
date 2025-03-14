using System;
using System.Data;
using System.Dynamic;
using System.Formats.Asn1;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace MeuProjeto;
class Program

{
    static void Main(string[] args)
    {
        /*
      var mouse = new Product(1,"mouse gamer", 298.88f, EProductType.Product);
      var manuntecaoEletrica = new Product(2, "Manuntenção residencial", 500, EProductType.Service);

      int inteiro = 100;
      float real = 25.5f;

      inteiro = real; 
      real = inteiro; 
      string valorReal = real.ToString();
      inteiro = int.Parse(valorReal);
      inteiro = Convert.ToInt32(real);

      int soma = '+';
      int sub = '-';
      int mult = '*';
      int divi = '/';

      string igual = "==";
      string diferente = "!=";
      string maior = ">";
      string menor = "<";
      string MaiorOuIgual = ">=";
      string MenorOuIgual = "<=";


       int x = 25;

       x == 0; false
       x != 0; true
       x > 0; true
       x < 0; false
       x >= 0; false
       x <= 0; true 

       E- and. deve atender todas as condições, &&
       OU- or. se atender uma conição ja se torna verdadeira
       NEGAÇÃO- not. !

       int x = 12;
       bool entre = (x > 25) && (x < 40);
       bool ou = (x > 25) || (x < 40);
       bool negação = !(x < 25);

      if(condicao) 
      {
          caso precise de mais linhas, se nao precisar usar sem as chaves
      } 
      Caso seja verdadeiro

      if (condicao) { CaseInsensitiveComparer seja verdadeiro
          ...
      } else if (condicao) { SendOrPostCallback, testa outra condicao
          ...
      } else if (condicao) { senao, testa outra condicao
          ...
      }  else { senao acontecer nenhuma das anteriores 
          ...
      }

      int maioridade = 18;
      int idade = 19;
      int idadeMaxima = 65;
      if (idade >= maioridade && idade <= idadeMaxima)
      {
          Console.WriteLine("pode passar");
      }
      else
      {
          Console.WriteLine("nao pode passar");
      }

      Console.WriteLine("Acabou");



      int valor = 1;
      switch (valor)
      {
          case 1: Console.WriteLine("1"); break;
          case 2: Console.WriteLine("2"); break;
          case 3: Console.WriteLine("3"); break;
          default: Console.WriteLine("4"); break; SearchOption não for 1, 2 ou 3 
      }


      bool? nome = false;
      switch (nome)
      {
          case false: Console.WriteLine("nao é o cara"); break;
          case true: Console.WriteLine("nao é o cara"); break;
          default: Console.WriteLine("nao é o cara"); break;
      }


      //conta de 0 a 5

      for (var i = 0; i <= 5; i++)
      {
          Console.WriteLine(i);
      }

      //conta de 1 a 5 
      for (var i = 1; i <= 5; i++)
      {
          Console.WriteLine(i);
      }

      //conta de 0 a 4
      for (var i = 1; i < 5; i++)
      {
          Console.WriteLine(i);
      }

      //conta de 5 a 0
      for (var i = 5; i >= 0; i--)
      {
          Console.WriteLine(i);
      }



      var valor = 0;

      while (valor <= 5)
      {
          Console.WriteLine(valor);
          valor++;
      }


      var valorinfinito = 0;
      while (true)
      {
          valor++;
          Console.WriteLine(valorinfinito);
      }

      var valor = 0;

      do
      {
          Console.WriteLine("Teste");
          valor++;
      }
      while (valor < 5);



      int x = 25;
      int y = x; // y é uma copia de x
      Console.WriteLine(x); // 25
      Console.WriteLine(y); // 25
      x = 32; // somente x foi alterado
      Console.WriteLine(x); // x = 32
      Console.WriteLine(y); // y = 25


      var arr = new string[2];
      arr[0] = "Item1";
      var arr2 = arr; //não cria uma copia 

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      // Altera as duas letras 
      arr[0] = "Item Alterado";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);



      struct Product
     {
      //propriedades 
      // metodo
      public int id;
      public float Price;

      public float PriceInDolar(float dolar)
      {
          return Price * dolar;
      }
      }
  */
    }
}

struct Product
{
    /*
    public Product(int id, string name, double price, EProductType type)
    {

        Id = id;
        Name = name;
        Type = type;

    }

    public int Id;
    public string Name;
    public int Price;
    public double PriceInDolar(double dolar)
    {
        return Price * dolar;

    }

    public EProductType Type;

}
*/
    enum EProductType
    {
        /*
        Product = 1,
        Service = 2
        */
    }
}