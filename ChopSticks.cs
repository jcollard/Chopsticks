using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChopSticks
{

    private List<Player> players = new List<Player>();
    private int currentPlayer = 0;

    public ChopSticks(int numPlayers)
    {
        while (numPlayers > 0)
        {
            players.Add(new Player());
            numPlayers--;
        }
        currentPlayer = 1;
    }

    public string GetInfo()
    {
        StringBuilder builder = new StringBuilder();
        int ix = 0;
        foreach (Player p in players)
        {
            builder.Append($"Player {ix}: {p.GetInfo()}\n");
            ix++;
        }
        return builder.ToString();
    }

}