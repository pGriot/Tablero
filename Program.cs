internal class Program
{
    private static void Main()
    {

        string rowChar;
        int row;
        bool cont = true;
        bool odd = false;


        do
        {
            while (true)
            {
                Console.WriteLine("ingrese la longuitud de las filas del tablero: ");

                // Lee el valor ingresado y verifica que sea un número
                rowChar = Console.ReadLine();

                try
                {
                    row = int.Parse(rowChar);
                    break;
                }
                catch
                {
                    Console.WriteLine("Debe ingresar un número");
                }
            }

            // Calcula la cantidad de cuadros rojos que serán necesarias
            int reds = (row * row) / 2;

            // Si el número ingresado es impar sería imposible colorear en la misma cantidad los cuadros rojos y azules, por eso -
            // - realizamos este paso
            if (row%2 > 0) odd = true;

            int redCount = 0;
            int blueCount = 0;
            int rowCount;
            Console.WriteLine();

            for (int r = 0; r < row; r++)
            {
                // Inicializa el contador de cuadros rojos de cada fila para mostrar al usuario
                rowCount = 0;
                for (int c = 0; c < row; c++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                    // Verifica que queden cuadros rojos para pintar, que no sobrepase la diagonal y no pinte la fila central
                    if (odd && c == row / 2 && c == r)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(" M ");
                    }
                    else if((reds > 0) && (c <= r) && (r + 1 != row / 2))
                    {
                        // En caso que se cumplan las condiciones, pinta de rojo el cuadro...
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" R ");
                        reds = reds - 1;
                        rowCount++;
                        redCount++;
                    }
                    else 
                    {
                        // ...En caso contrario lo pinta de azul
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" B ");
                        blueCount++;
                    }
                }

                // Indica la cantidad de cuadros pintados de rojo de cada fila
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"| Rojos {rowCount}");
                Console.WriteLine();
            }

            // Indica cuantos cuadros rojos se pintaron
            Console.WriteLine("\nCantidad de cuadros rojos: " + redCount);
            Console.WriteLine("Cantidad de cuadros azules: " + blueCount);
            if (odd) Console.WriteLine("Se introdujo un cuadro magenta para mantener el equilibrio en la cantidad de cuadros azules y rojos");

            // Consulta si desea intentar de nuevo o salir
            Console.WriteLine("\n¿Desea continuar? (s/n)");
            string resp = Console.ReadLine();

            if (resp.ToUpper() == "N") cont = false;

            Console.WriteLine("\n \n");

        } while (cont);
    }
}