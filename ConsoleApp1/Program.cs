using System.Text;

public class Program
{

    public static void Main(string[] args)
    {   
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Random random = new Random();
        Console.Clear();
        int movimiento_restante = 10;
        int posicion_camara_x = 1;
        int posicion_camara_y = 0;
        int tamano_camara_horizontal = 15;
        int tamano_camara_vertical = 15;
        char[,] mapa = new char[100, 100];
        for (int i = 0; i < mapa.GetLength(0) -1; i++)
        {
            for (int j = 0; j < mapa.GetLength(1) -1 ; j++)
            {
                if (random.Next(0, 2) == 0)
                    mapa[i, j] = '#';
                else
                {
                    mapa[i, j] = Convert.ToChar(32);
                }
                
            }
        }
        
        while (true)
        {
            Console.Clear();
            DibujarMapa(mapa, posicion_camara_x, posicion_camara_y, tamano_camara_horizontal, tamano_camara_vertical, movimiento_restante);
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            { 
                if (movimiento_restante > 0)
                {
                    posicion_camara_x--;
                    movimiento_restante--;
                }
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                if (movimiento_restante > 0)
                {
                    posicion_camara_x++;
                    movimiento_restante--;
                }
            }
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (movimiento_restante > 0)
                {
                    posicion_camara_y--;
                    movimiento_restante--;
                }
            }
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                
                if (movimiento_restante > 0)
                {
                    posicion_camara_y++;
                    movimiento_restante--;
                }
            }
        }
    }
    public static void DibujarMapa(char[,] mapa, int posicion_camara_x, int posicion_camara_y, int tamano_camara_horizontal, int tamano_camara_vertical, int movimiento_restante)
    {
        Console.WriteLine("Posicion camara x: " + posicion_camara_x + " Posicion camara y: " + posicion_camara_y + " Movimiento restante: " + movimiento_restante);
        if (posicion_camara_x < 0)
        {
            posicion_camara_x = 0;
        }
        if (posicion_camara_y < 0)
        {
            posicion_camara_y = 0;
        }
        
        for (int i = 0; i < tamano_camara_vertical; i++)
        {
            for (int j = 0; j < tamano_camara_horizontal ; j++)
            {
                Console.Write(mapa[i + posicion_camara_y, j + posicion_camara_x] + " ");
            }
            Console.WriteLine();
        }
        
        
    }
}