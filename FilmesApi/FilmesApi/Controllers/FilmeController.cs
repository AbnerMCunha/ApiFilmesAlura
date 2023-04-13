using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController {

    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)    //Anotação FromBody representa que a info será lançada a partir do corpo da requisição
    {
        filme.Id = id++ ;
        filmes.Add(filme);
        Console.WriteLine(filme);
        Console.WriteLine("\nId: " + filme.Id);
        Console.WriteLine("Titulo: " + filme.Titulo);
        Console.WriteLine("Genero: " + filme.Genero);
        Console.WriteLine("Duracao: " + filme.Duracao.ToString());
    }

    [HttpGet]
    public List<Filme> RecuperaFilmes()
    {
        Console.WriteLine(filmes.Count.ToString());
        return filmes;
    }

    [HttpGet("{Id}")]
    public Filme? RecuperaFilmePorId( int id)
    {
        Console.WriteLine(filmes.FirstOrDefault(x => x.Id == id).Id.ToString() ); 
        return filmes.FirstOrDefault(x => x.Id == id);
    }
}



