using LojadeGames.Models;

namespace LojadeGames.Data;

public class UsuárioRepository
{
    // private static List<Usuário> usuário = new List<Usuário>();

    // static UsuárioRepository()
    // {
    //     usuário.Add(new Usuário{ gmail="bruno@gmail.com", senha= 072418 });
    // }

    private static Usuario usuário = new Usuario {gmail="",senha=072418};

    public Usuario PuxarUsuário()
    {
        return usuário;
    }
}