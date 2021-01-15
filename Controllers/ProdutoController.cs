using System.Collections.Generic;
using MVC_CONSOLE.Models;
using MVC_CONSOLE.Views;


namespace MVC_CONSOLE.Controllers
{
    public class ProdutoContrller
    {
        Produto produto = new  Produto();
 
         ProdutoView produtoView = new  ProdutoView();
         
            public void MostrarProdutos()

             {
                 List<Produto> todos = produto.Ler();
                produtoView.ListarTodos(todos);
             } 

             public void Cadastrar()
              { 
                 produto.Inserir( produtoView.CadastrarProduto() );
              }                        
    }
}


