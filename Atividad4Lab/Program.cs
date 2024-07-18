Console.WriteLine("Ejercicio uso de Git");

int cat = 0; //variable creada para salir del menu, se cambia de valor al ingresar la opcion "salir"
while (cat == 0)
{
    try // dentro de este bloque de código se pueden encontrar errores de usuario al momento de ingresar una opción en el menú principal
    {
        Console.Clear();
        Console.WriteLine("Menú principal");
        Console.WriteLine("1. Crear Matrices");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        Console.WriteLine("4. Juego: adivina el número.");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Selecciona una de las opciones:");
        int opcionMenuPrincipal = int.Parse(Console.ReadLine());

        switch (opcionMenuPrincipal) // Menú principal
        {
            case 1:
                Console.WriteLine("uno");
                break;
            case 2:
                Console.WriteLine("dos");
                break;
            case 3:
                Console.WriteLine("tres");
                break;
            case 4:
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
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Has ocurrido un error: " + ex.Message);
        Console.ReadKey();
    }
}
