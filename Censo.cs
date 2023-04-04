public class Censo{
public static Dictionary<int, Persona> dicPersonas = new Dictionary<int, Persona>();

public static void cargarPersona(){
    bool existe = false;
    int dni = Funciones.IngresarEntero("Ingrese su DNI: ");
    if (dicPersonas.ContainsKey(dni)) modificarDatos();
    else
    {
        string ape = Funciones.IngresarTexto("Ingrese su apellido: ");
        string nom = Funciones.IngresarTexto("Ingrese su nombre: ");
        DateTime fnac = Funciones.IngresarFecha("Ingrese su fecha de nacimiento con el formato: (aaaa/mm/dd): ");
        string em = Funciones.IngresarTexto("Ingrese su email: ");

        Persona unaPersona = new Persona(dni, ape, nom, fnac, em);
        dicPersonas.Add(dni, unaPersona );
        Console.WriteLine("Se ha creado la persona " + nom + " " + ape + " y se ha agregado a la lista");
    }
}

public static void obtenerEstadisticas(){
int cont = 0;
float promedio = 0;
if(dicPersonas.Count == 0) Console.WriteLine("Aun no se ingresaron personas en la lista");
foreach (var valor in dicPersonas.Values)
{
    int edad = Persona.obtenerEdad();
    bool votar = Persona.puedeVotar(edad);
    if(votar == true) cont = cont + 1;
    promedio = promedio + edad;
}
    promedio = promedio / dicPersonas.Count();
    Console.WriteLine("Estadisticas del censo: ");
    Console.WriteLine("La cantidad de personas es de: " + dicPersonas.Count);
    Console.WriteLine("La cantidad de personas que pueden votar es de: " + cont);
    Console.WriteLine("El promedio de edad es de: " + promedio);
}

public static void buscarPersona(){
bool encontro = false;
int dniPedido = Funciones.IngresarEntero("Ingrese el DNI que desea buscar: ");
foreach (var clave in dicPersonas)
{
    if(clave.Key == dniPedido){
    Console.WriteLine("Nombre: " + Persona.nombre);
    Console.WriteLine("Apellido: " + Persona.apellido);
    Console.WriteLine("Fecha de nacimiento: " + Persona.fechaNacimiento.ToShortDateString());
    Console.WriteLine("Email: " + Persona.email);
    encontro = true;
    }
}
if(encontro == false) Console.WriteLine("No se encuentra el DNI");
}

public static void modificarMail(){
bool encontro = false;
int dniPedido = Funciones.IngresarEntero("Ingrese el DNI que desea buscar y modificar su email: ");
string mailNuevo = Funciones.IngresarTexto("Ingrese su email nuevo: ");
foreach (var clave in dicPersonas)
{
    if(clave.Key == dniPedido){
    Persona.email = mailNuevo;
    encontro = true;
    }
}
if(encontro == false) Console.WriteLine("No se encuentra el DNI");
}
public static void modificarDatos()
{
    string eleccion = "", nuevoApe = "", nuevoNom = "", nuevoEm = "";
    DateTime nuevaFnac = new DateTime();
    int dniPedido = 0;
        Console.WriteLine("Parece que este DNI ya existe, queres cambiar los datos de la persona previamente ingresada? Escribir 'Si' o 'No'");
        do
        {
            eleccion = Console.ReadLine();
        }
        while(eleccion != "Si" && eleccion != "No");

    if(eleccion == "Si"){
    dniPedido = Funciones.IngresarEntero("Ingrese el DNI de la persona que quiere modificar sus datos: ");
    nuevoApe = Funciones.IngresarTexto("Ingrese su nuevo apellido: ");
    nuevoNom = Funciones.IngresarTexto("Ingrese su nuevo nombre: ");
    nuevaFnac = Funciones.IngresarFecha("Ingrese su nueva fecha de nacimiento con el formato: (aaaa/mm/dd): ");
    nuevoEm = Funciones.IngresarTexto("Ingrese su nuevo email: ");
    }

    foreach (var clave in dicPersonas){
    if(clave.Key == dniPedido){
    Persona.apellido = nuevoApe;
    Persona.nombre = nuevoNom;
    Persona.fechaNacimiento = nuevaFnac;
    Persona.email = nuevoEm;
    }

}
}
}


