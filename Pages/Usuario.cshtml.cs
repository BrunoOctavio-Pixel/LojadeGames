using LojadeGames.Data;
using LojadeGames.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojadeGames.Pages;

public class UsuarioModel : PageModel
{
    private readonly UsuárioRepository _usuário;
    public Usuario usuario {get;set;}

    public UsuarioModel(UsuárioRepository repositorio)
    {
        _usuário = repositorio;
    }
    
    public void OnGet()
    {
      usuario = _usuário.PuxarUsuário();
    }
}
