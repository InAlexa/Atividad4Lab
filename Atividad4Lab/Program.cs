static void CrearMatrices()
{
    int numFilas = 0;
    int numColumnas = 0;

    while (true)
    {
        try
        {
            Console.Write("Ingrese el número de filas:");
            numFilas = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada incorrecta. Ingrese un número entero.");
        }
    }

    while (true)
    {
        try
        {
            Console.Write("Ingrese el número de columnas: ");
            numColumnas = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada incorrecta. Ingrese un número entero.");
        }
    }

    int[,] matriz = new int[numFilas, numColumnas];

    for (int fila = 0; fila < numFilas; fila++)
    {
        for (int columna = 0; columna < numColumnas; columna++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Ingrese el elemento de la fila {fila + 1}, columna {columna + 1}: ");
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada incorrecta. Ingrese un número entero.");
                }
            }
        }
    }

    int numeroABuscar = 0;

    while (true)
    {
        try
        {
            Console.Write("Ingrese el número que está buscando: ");
            numeroABuscar = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada incorrecta. Ingrese un número entero.");
        }
    }

    List<Tuple<int, int>> posiciones = new List<Tuple<int, int>>();

    for (int fila = 0; fila < numFilas; fila++)
    {
        for (int columna = 0; columna < numColumnas; columna++)
        {
            if (matriz[fila, columna] == numeroABuscar)
            {
                posiciones.Add(new Tuple<int, int>(fila, columna));
            }
        }
    }

    if (posiciones.Count > 0)
    {
        Console.WriteLine($"El número {numeroABuscar} se encuentra en:");
        foreach (var posicion in posiciones)
        {
            Console.WriteLine($"Fila: {posicion.Item1}, Columna: {posicion.Item2}");
        }
    }
    else
    {
        Console.WriteLine("El número no eXiste en la matriz.");
    }

    Console.WriteLine("Presione cualquier tecla...");
    Console.ReadKey();
}
