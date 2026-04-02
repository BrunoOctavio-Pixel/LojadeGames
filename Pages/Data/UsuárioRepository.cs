using LojadeGames.Models;

namespace LojadeGames.Data;

public class UsuárioRepository
{
    private static List<Usuário> usuário = new List<Usuário>();

    static UsuárioRepository()
    {
        usuário.Add(new Usuário{ gmail="bruno@gmail.com", senha= 072418 });
    }
}