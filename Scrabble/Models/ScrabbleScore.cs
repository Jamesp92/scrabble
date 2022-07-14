namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    // these are fields
    public string Word { get; set; }

    public int GetScore()
    {
      // A, E, I, O, U, L, N, R, S, T  
      
      if (Word == "a" || Word == "o")
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}