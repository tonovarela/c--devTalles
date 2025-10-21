partial class Program {

    static void LinqDemo()
    {
            List<MarvelCharacter> characters = new List<MarvelCharacter>
            {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
            };
          var avengers= characters.Where(c => c.Team == "Avengers")
                                                   .OrderBy(c => c.Name)                                                                                                      
                                                   .ToList();
        Console.WriteLine("Avengers Characters:");
        ShowInfo(avengers);
        
        var sortedQuery = characters.OrderByDescending(c => c.Name);
        Console.WriteLine("Characters sorted by Name in descending order:");
        ShowInfo(sortedQuery.ToList());

        var firstThreeCharacters = characters.Take(3);
        Console.WriteLine("\nFirst three characters:");        
        ShowInfo(firstThreeCharacters.ToList());

        
                                        

     
    }

    static void ShowInfo(IEnumerable<MarvelCharacter> characters)
    {
        Console.WriteLine("-----------------------------");
        foreach (var character in characters)        
            Console.WriteLine($"{character.Name} a.k.a {character.Alias} from {character.Team}");
        
        Console.WriteLine("-----------------------------");

    }


class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}



}