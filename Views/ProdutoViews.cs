using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;
using MVC_CONSOLE.Views;

namespace MVC_CONSOLE.Views
{
    public class ProdutoViews
    {
         
        public  void ListarTodos(List <Produto> produtos)
        {
             foreach (Produto item in produtos)

             {
                   Console.WriteLine($"Código : {item.Codigo}");
                   Console.WriteLine($"Nome : {item.Nome}");
                   Console.WriteLine($"Preco : R$ {item.Preco}");
                   Console.WriteLine();

             }               
        }

        public Produto CadastrasProduto()
      {   
            Produto produto = new Produto();

         Console.WriteLine($"Digite o codigo do produto ");      
         produto.Codigo = int.Parse(Console.ReadLine() );

          Console.WriteLine($"Digite o nome do produto ");
          produto.Nome = Console.ReadLine();
          
            Console.WriteLine($"Digite o preco do produto");
            produto.Preco = float.Parse(Console.ReadLine());
                
           return produto;

     }       
        
    }
}




