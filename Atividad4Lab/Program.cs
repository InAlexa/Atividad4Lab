Console.WriteLine("Ejercicio uso de Git");

int cat = 0; //variable creada para salir del menu, se cambia de valor al ingresar la opcion "salir"
while (cat == 0)
{
    try // dentro de este bloque de código se pueden encontrar errores de usuario al momento de ingresar una opción en el menú principal
    {
        Console.Clear();
        Console.WriteLine("Menú principal");
        Console.WriteLine("1. Crear Matrices");
        Console.WriteLine("2. Juego: adivina el número.");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Selecciona una de las opciones:");
        int opcionMenuPrincipal = int.Parse(Console.ReadLine());

        switch (opcionMenuPrincipal) // Menú principal
        {
            case 1:

                Console.WriteLine("Crear Matrices");
                CrearMatrices();
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

                break;
            
            case 2:
                int cat4 = 0;
                while (cat4 == 0)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Adivina el número.");
                        Console.WriteLine("Escoge un número del 1 al 10");
                        int numeroSeleccionado = int.Parse(Console.ReadLine());
                        Random numeroRandom = new Random();
                        int numeroRandomEntero = numeroRandom.Next(1, 11);
                        if (numeroRandomEntero == numeroSeleccionado)
                        {
                            Console.WriteLine("Tu número: " + numeroSeleccionado);
                            Console.WriteLine("El número aleatorio: " + numeroRandomEntero);
                            Console.WriteLine("Felicidades ¡Has ganado!");
                        }
                        else
                        {
                            Console.WriteLine("Tu número: "+ numeroSeleccionado);
                            Console.WriteLine("El número aleatorio: "+ numeroRandomEntero);
                            Console.WriteLine("Has perdido. Vuelve a intentarlo.");
                        }

                        int cat4a = 0;
                        while (cat4a == 0)
                        { 
                        Console.WriteLine("¿Deseas seguir jugando?");
                        Console.WriteLine("Si / No");
                        string terminarJuego = Console.ReadLine();
                    
                            switch (terminarJuego)
                            {
                                case "si":
                                    Console.Clear();
                                    Console.WriteLine("Sigue jugando entonces.");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    break;
                                case "Si":
                                    Console.Clear();
                                    Console.WriteLine("Sigue jugando entonces.");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    break;
                                case "SI":
                                    Console.Clear();
                                    Console.WriteLine("Sigue jugando entonces.");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    break;
                                case "no":
                                    Console.Clear();
                                    Console.WriteLine("Has salido del juego. Vuelve pronto");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    cat4 = 1;
                                    break;
                                case "No":
                                    Console.Clear();
                                    Console.WriteLine("Has salido del juego. Vuelve pronto");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    cat4 = 1;
                                    break;
                                case "NO":
                                    Console.Clear();
                                    Console.WriteLine("Has salido del juego. Vuelve pronto");
                                    Console.ReadKey();
                                    cat4a = 1;
                                    cat4 = 1;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa una de las opciones.");
                                    Console.ReadKey();
                                    break;

                            } 
                        }
                    }
                    catch (FormatException ex) // los siguientes catch atrapan los errores de este bloque try
                    {
                        Console.WriteLine("Error: no se ha ingresado un número entero.");
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ha ocurrido un error: " + ex.Message);
                        Console.ReadKey();
                    }
                }
                break;  
            case 3:
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
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Has ocurrido un error: " + ex.Message);
        Console.ReadKey();
    }
}
