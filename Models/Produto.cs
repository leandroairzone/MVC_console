using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_CONSOLE.Models
{
    public class Produto
    {
         public int Codigo { get; set;}

       public string Nome { get; set; }

      public float Preco { get; set; }

      private const string PATH = "Database/Produto.csv";

        public Produto()

        {            
            string pasta = PATH.Split("/") [0];

          // verificamos se a pasta não existe e criamos nesta condição
          if(!Directory.Exists(pasta))
          {             
               Directory.CreateDirectory(pasta);
          } 
           // Verificamos se o arquivo Produto.csv existe, caso não exista, vamos cria lo
           
           if(!File.Exists(PATH))
          {
             File.Create(PATH);
          }
         
        }
   
     
                  public List<Produto> Ler()

                  {
                      List<Produto> produtos = new List<Produto>();

                      // Pegar as informções do csv
                      string[]  linhas = File.ReadAllLines(PATH);

                       foreach (string item in linhas )
                    { 
                      // Separar atributo pelo ;             
                      string[] atributos = item.Split(";");
                      // Criamos um produto vazio para poder colocar na lista final de produtos 
                
                            Produto prod  = new Produto();
                            prod.Codigo   = int.Parse(atributos[0]);
                            prod.Nome     = atributos [1];
                            prod.Preco    = float.Parse(atributos[2]);

                             produtos.Add(prod);
                    }
                
                    return  produtos; 

                  }      
                  
                  public void Inserir(Produto p)
                  {
                    // Preparamos um array de string para o método AppendAllLines
                     string[] linhas = { PrepararLinhaCSV(p) };

                     // Inserimos o array de linhas no arquivo
                     File.AppendAllLines(PATH,linhas );
                  }

                  public string PrepararLinhaCSV(Produto prod )  
                  {
                    // Preparamos a linhas para o formato do csv 
                    return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
                  }           
    }
}