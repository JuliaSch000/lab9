namespace FirstDungeonMap.Core.Maps;

public static class DungeonMap
{
    public static char[,] Create(int width, int height) // zad 1
    {
        char[,] map = new char[height, width];
        for (int i = 1; i<= map.GetLength(1); i++)
        {
            for (int j = 1; j<= map.GetLength(0); j++)
            {
                if ((j == 4) && (i == 2))
                {
                    Console.Write(">");
                }
                else if ((i == 1) || i == map.GetLength(1))
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
        // TODO: zbuduj podłogę i ściany na krawędziach.
        return map;
    }

    public static char[,] Create2(int width, int height) // zad 3
    {
        char[,] map = new char[height, width];
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
        // TODO: zbuduj podłogę i ściany na krawędziach.
        return map;
    }

    public static char[,] CreateSample()
    {
        
        char[,] map = Create(12, 7);
        map[1, 10] = '>';
        map[3, 4] = '#';
        map[3, 5] = '#';
        map[4, 8] = '$';
        return map;
    }

    public static bool IsInside(char[,] map, int x, int y)
    {
        // TODO: sprawdź cztery granice przed odczytem map[y, x].
        return false;
    }

    public static bool IsWalkable(char[,] map, int x, int y)
    {
        // TODO: pole jest dostępne, gdy leży na mapie i nie jest ścianą.
        return false;
    }

    public static int CountSymbol(char[,] map, char symbol)
    {
        // TODO: policz wystąpienia symbolu na całej mapie.
        return 0;
    }

    public static bool TryFindSymbol(char[,] map, char symbol, out int foundX, out int foundY)
    {
        // TODO: zwróć współrzędne pierwszego wystąpienia.
        foundX = -1;
        foundY = -1;
        return false;
    }
}
