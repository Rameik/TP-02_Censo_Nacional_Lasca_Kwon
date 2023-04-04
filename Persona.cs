public class Persona{

public static int DNI {get;set;}
public static string apellido {get;set;}
public static string nombre {get;set;}
public static DateTime fechaNacimiento {get;set;}
public static string email {get;set;}

public Persona(){


}

public Persona(int dni, string ape, string nom, DateTime fnac, string em){
DNI = dni;
apellido = ape;
nombre = nom;
fechaNacimiento = fnac;
email = em;

}

public static bool puedeVotar(int edad){
bool votar;
if(edad >= 16){
votar = true;
}
else votar = false;
return votar;
}

public static int obtenerEdad(){
    int edad;
    DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);
    if (FechaNacimientoHoy< DateTime.Today)  edad = DateTime.Today.Year - fechaNacimiento.Year;
    else   edad = DateTime.Today.Year - fechaNacimiento.Year -1;
    return edad; 
}
}
