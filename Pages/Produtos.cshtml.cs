using LojadeGames.Data;
using LojadeGames.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojadeGames.Pages;

public class ProdutosModel : PageModel
{
    private readonly ProdutosRepository _produto;
    public Produtos produto {get;set;}

    public ProdutosModel(ProdutosRepository repositorio)
    {
        _produto = repositorio;
    }
    
    public void OnGet()
    {
      produto = _produto.PuxarProdutos();
    }
}
