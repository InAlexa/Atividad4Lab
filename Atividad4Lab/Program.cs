Console.WriteLine("Ejercicio uso de Git");

int cat = 0; //variable creada para salir del menu, se cambia de valor al ingresar la opcion "salir"
while (cat == 0)
{
    try // dentro de este bloque de código se pueden encontrar errores de usuario al momento de ingresar una opción en el menú principal
    {
        Console.WriteLine("Menú principal");
        Console.WriteLine("1. Crear Matrices");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        Console.WriteLine("4. ");
        Console.WriteLine("5. Salir");
        int opcionMenuPrincipal = int.Parse(Console.ReadLine());

        switch (opcionMenuPrincipal) // Menú principal
        {
            case 1:
                Console.WriteLine("uno");
                CrearMatrices();
                break;
            case 2:
                Console.WriteLine("dos");
                break;
            case 3:
                Console.WriteLine("tres");
                break;
            case 4:
                Console.WriteLine("cuatro");
                break;  
            case 5:
                Console.WriteLine("Ha salido del programa.");
                cat = 1;
                break;
            default: //creado por si el usuario ingresa una opción que no está dentro del menú
                Console.WriteLine("Escoja una de las opcines dentro del menú.");
                break;
        }
    }
    catch (FormatException ex) // los siguientes catch atrapan los errores del primer bloque try
    {
        Console.WriteLine("Error: no se ha ingresado un número entero.");
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error: " + ex.Message);
    }
}

// Aqui empieza el código de la MATRIZ
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

