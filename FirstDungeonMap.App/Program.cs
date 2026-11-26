using FirstDungeonMap.App.UI;
using FirstDungeonMap.Core.Maps;

namespace FirstDungeonMap.App;

public static class Program
{
    private const int PlayerX = 2;
    private const int PlayerY = 2;

    public static void Main()
    {
        Console.WriteLine("=== PIERWSZA MAPA LOCHU ===");
        Console.WriteLine("Wybierz zadanie 1–7:");

        if (!int.TryParse(Console.ReadLine(), out int taskNumber) || taskNumber < 1 || taskNumber > 7)
        {
            Console.WriteLine("Niepoprawny numer zadania.");
            return;
        }

        switch (taskNumber)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            case 4: Task4(); break;
            case 5: Task5(); break;
            case 6: Task6(); break;
            case 7: Task7(); break;
        }
    }

    private static void Task1()
    {
        char[,] map =
        {
            { '#', '#', '#', '#', '#' },
            { '#', '.', '.', '>', '#' },
            { '#', '.', '.', '.', '#' },
            { '#', '#', '#', '#', '#' }
        };

        
        
        DungeonMap.Create(4, 5);
        Console.WriteLine($"Mapa ma {map.GetLength(0)} wiersze i {map.GetLength(1)} kolumn.");
        Console.WriteLine($"Długość mapy: {map.Length}");
    }

    private static void Task2()
    {
        int width = 12;
        int height = 7;
        char[,] map = new char[width, height];
        // TODO: wypełnij krawędzie '#', a wnętrze '.'.
        MapRenderer.Print(map);
        width = 8;
        height = 5;
        char[,] map2 = new char[width, height];
        MapRenderer.Print(map2);
        width = 20;
        height = 4;
        char[,] map3 = new char[width, height];
        MapRenderer.Print(map3);
    }

    private static void Task3()
    {
        
        char[,] map = DungeonMap.Create2(12, 7);
        map[1, 10] = '>'; // y = 1, x = 10
        // TODO: dodaj wyjście, skarb i przeszkody.
        MapRenderer.Print(map);
    }

    private static void Task4()
    {
        char[,] map = DungeonMap.CreateSample();
        // TODO: wyświetl '@' jako nakładkę, nie zapisując go do mapy.
        MapRenderer.Print(map, PlayerX, PlayerY);
    }

    private static void Task5()
    {
        char[,] map = DungeonMap.CreateSample();
        int[,] coordinates = { { 2, 2 }, { 0, 0 }, { 20, 3 }, { 10, 5 } };

        for (int i = 0; i < coordinates.GetLength(0); i++)
        {
            int x = coordinates[i, 0];
            int y = coordinates[i, 1];
            Console.WriteLine($"({x}, {y}) -> wewnątrz: {DungeonMap.IsInside(map, x, y)}, dostępne: {DungeonMap.IsWalkable(map, x, y)}");
        }
    }

    private static void Task6()
    {
        char[,] map = DungeonMap.CreateSample();
        MapRenderer.Print(map, PlayerX, PlayerY);
        Console.WriteLine("TODO: uzupełnij raport mapy.");
    }

    private static void Task7()
    {
        char[,] map = DungeonMap.CreateSample();
        // TODO: zaprojektuj własną mapę projektu.
        MapRenderer.Print(map, PlayerX, PlayerY);
        MapRenderer.PrintLegend();
    }
}
