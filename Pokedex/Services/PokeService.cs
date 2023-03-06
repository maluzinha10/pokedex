namespace Pokedex.Services;
public class PokeService : IPokeService
{
    private readonly IHttpContextAcessor _session;

    public PokeService(IhttpContextAccessor session)
    {
        _session = session;
    }

    Pokemon GetPokemon(int Numero)
    {

    }

    List<Pokemon> GetPokemon()
    {

    }

    List<Tipos> GetPokemon()
    {

    }


    private void PopularSessao()
    {
        // ViewData["Tipos"] = JsonSerializer.Deserialize<List<Tipo>>(LerArquivo(@"Data\tipos.json")
        // );
        //  var dados = LerArquivo(@"Data\pokemons.json");
        //     var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(dados);
        var dados = LerArquivo(@"Data\pokemons.json");
        _session.HttpContext.Session.SetString("Pokemons", dados);
        dados = LerArquivo(@"Data\pokemons.json");
        _session.HttpContext.Session.SetString("Tipos", dados);
    }

    private string LerArquivo(string nomeArquivo)
    {
        using (StreamReader leitor = new StreamReader(nomeArquivo))
        {
            string dados = leitor.ReadToEnd();
            return dados;
        }
    }

}
