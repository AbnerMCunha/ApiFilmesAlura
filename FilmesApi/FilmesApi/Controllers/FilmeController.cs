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
    public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50)  //O método Skip() indica quantos elementos da lista pular. O Take() define quantos serão selecionados.
    {   //A Anotação [FromQuery] explicita que o usuário quem dará esses dados, por meio da consulta (query), no corpo da requisição
        //Exemplo: https://localhost:7106/filme?skip=10&take=5
        //Caso o usuario não informe, o valor padrão a ser pego é o da atribuição passada nos argumentos deste metodo get.

        //Console.WriteLine(filmes.Count.ToString());
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{Id}")]
    public Filme? RecuperaFilmePorId( int id)
    {
        Console.WriteLine(filmes.FirstOrDefault(x => x.Id == id).Id.ToString() ); 
        return filmes.FirstOrDefault(x => x.Id == id);
    }
}



