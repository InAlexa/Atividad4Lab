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