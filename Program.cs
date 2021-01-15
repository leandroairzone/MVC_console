using System;
using MVC_CONSOLE.Controllers;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
         
         // Instanciamos nosso Controller
         ProdutoController produtoController  = new ProdutoController(); 

          produtoController.Cadastrar();


          ProdutoController.MostrarProdutos();

        }
    }
}
