namespace realexample
{
    // Interface to be used about all player in the game
    public interface IPlayer
    {
        // Name of the player
        string Name {get;set;}

        // Simulate current level of the player
         int CurrentLevel {get;set;}
    }
}