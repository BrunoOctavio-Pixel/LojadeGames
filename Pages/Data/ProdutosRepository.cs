using LojadeGames.Models;

namespace LojadeGames.Data;

public class ProdutosRepository
{
    private static List<Produtos> produtos = new List<Produtos>();

    static ProdutosRepository()
    {
        produtos.Add(new Produtos{ marca="Play,Xbox e Nintendo", categorias="Jogos,Consoles e Acessórios", imagem="", preço= , quantidade=   });
    }
}