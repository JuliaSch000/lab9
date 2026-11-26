namespace FirstDungeonMap.App.UI;

public static class MapRenderer
{
    public static void Print(char[,] map, int playerX = -1, int playerY = -1)
    {
        // TODO: renderuj mapę w konwencji map[y, x]. Gracz ma być nakładką.
        Console.WriteLine($"[Mapa {map.GetLength(1)} × {map.GetLength(0)}");
         for (int i = 1; i<= map.GetLength(1); i++)
        {
            for (int j = 1; j<= map.GetLength(0); j++)
            {
                
                if ((i == 1) || i == map.GetLength(1))
                {
                    Console.Write("#");
                }
                else if ((j == 1) || j == map.GetLength(0))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine("");
        }
    }

    public static void PrintLegend()
    {
        Console.WriteLine("Legenda: # ściana | . podłoga | @ gracz | > wyjście | $ skarb");
    }
}
