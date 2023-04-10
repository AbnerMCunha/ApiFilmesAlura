using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController {

    private List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)    //Anotação FromBody representa que a info será lançada a partir do corpo da requisição
    {
        filmes.Add(filme);
        Console.WriteLine(filme);
        Console.WriteLine("Titulo: " + filme.Titulo);
        Console.WriteLine("Genero: " + filme.Genero);
        Console.WriteLine("Duracao: " + filme.Duracao.ToString());
    }

    [HttpGet]
    public List<Filme> RecuperaFilmes()
    {
        return filmes;
    }


}
