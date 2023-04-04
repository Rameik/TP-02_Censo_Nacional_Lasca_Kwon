
bool salir = false;
do{
menu(ref salir);
}
while(salir == false);

void menu(ref bool salir)
{
    int opcion;
    Console.WriteLine("Ingresar opcion entre:");
    Console.WriteLine("1. Cargar Nueva Persona");
    Console.WriteLine("2. Obtener Estadísticas del Censo");
    Console.WriteLine("3. Buscar Persona");
    Console.WriteLine("4. Modificar Mail de una Persona");
    Console.WriteLine("5. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1: Censo.cargarPersona();
        break;
        case 2: Censo.obtenerEstadisticas();
        break; 
        case 3: Censo.buscarPersona();
        break;
        case 4: Censo.modificarMail();
        break;
        case 5: salir = true;
        break;
    }
}
