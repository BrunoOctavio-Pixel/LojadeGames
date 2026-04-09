using LojadeGames.Models;

namespace LojadeGames.Data;

public class ProdutosRepository
{
    // private static List<Produtos> produtos = new List<Produtos>();

    // static ProdutosRepository()
    // {
    //     produtos.Add(new Produtos{ marca="PSP,Xbox e Nintendo", categorias="Jogos,Consoles e Acessórios", imagem="", preço=20 , quantidade=20   });
    // }

    private static Produtos produto = new Produtos {Marca="PSP,Xbox e Nintendo",Categorias="Jogos,Consoles e Acessórios",Imagem="C:/Users/Manhã/Desktop/LojadeGames/imagens/OIP.jpg",Preço=20,Qtd=50};

    public Produtos PuxarProdutos()
    {
        return produto;
    }
}