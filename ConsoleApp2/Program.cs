//con el condicional if sabremos si es sexo masculino y si es mayor de edad
string nombre;
int edad;
bool masculino;
string genero;

Console.WriteLine("Ingrese su nombre");
nombre= Console.ReadLine();

Console.WriteLine("Ingrese su edad");
edad = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su sexo.\nM si es masculino\nF si es femenino");
genero = Console.ReadLine();

if (genero == "M" && edad >=18)
{
    Console.WriteLine(nombre+" usted es mayor de edad y su sexo es masculino");
}else if(genero=="M" && edad<18)
{
    Console.WriteLine(nombre + " usted es menor de edad y su sexo es masculino");
}else if (genero=="F" && edad >= 18)
{
    Console.WriteLine(nombre + " usted es mayor de edad y su sexo es femenino");
}else if (genero=="F" && edad < 18)
{
    Console.WriteLine(nombre + " usted es menor de edad y su sexo es femenino");
}
else
{
    Console.WriteLine("Hay un error al ingresar las instrucciones, por favor corregirlo");
}

Console.WriteLine("---------------------------------------------------");
//------- Condicional Switch ---------
int opcion;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
edad = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su sexo.\n1. si es masculino\n2. si es femenino");
opcion = Int32.Parse(Console.ReadLine());


switch (opcion)
{
    case 1: genero = "Masculino";
            break;

    case 2: genero = "Femenino";
            break;

    default: genero = "No definido";
             break;

}
Console.WriteLine(nombre+" su edad es "+edad+" y su sexo es "+genero);

Console.WriteLine("Ingrese un mes para saber cuantos dias tiene.\n1. Enero\n2. Febrero\n3. Marzo" +
    "\n4. Abril\n5. Mayo\n6. Junio\n7. Julio\n8. Agosto\n9. Septiembre\n10. Octubre\n11. Noviembre\n12. Diciembre");
opcion = Int32.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Enero tiene 31 días");
        break;

    case 2:
        Console.WriteLine("Febrero tiene 28 días (29 si es bisiesto)");
        break;

    case 3:
        Console.WriteLine("Marzo tiene 31 días");
        break;

    case 4:
        Console.WriteLine("Abril tiene 30 días ");
        break;

    case 5:
        Console.WriteLine("Mayo tiene 31 días ");
        break;

    case 6:
        Console.WriteLine("Junio tiene 30 días ");
        break;

    case 7:
        Console.WriteLine("Julio tiene 31 días ");
        break;

    case 8:
        Console.WriteLine("Agosto tiene 31 días ");
        break;

    case 9:
        Console.WriteLine("Septiembre tiene 30 días ");
        break;

    case 10:
        Console.WriteLine("Octubre tiene 31 días ");
        break;

    case 11:
        Console.WriteLine("Noviembre tiene 30 días ");
        break;

    case 12:
        Console.WriteLine("Diciembre tiene 31 días ");
        break;

    default:
        Console.WriteLine("Ingreso un numero que no esta dentro del rango");
        break;

}
Console.WriteLine("---------------------------------------------------");

//Condicional while

Console.WriteLine("Se mostraran los numeros del 1 al 10");

int i=1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Se mostraran los numeros del 1 al 10 excepto el 5");
i = 1;
while (i <= 10)
{
    if (i==5)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("---------------------------------------------------");

//Condicional for
Console.WriteLine("Se mostraran los numeros del 1 al 10");
for (i=1; i<=10; i++)
{

    Console.WriteLine(i);

}
Console.WriteLine("Se mostraran los numeros del 1 al 10 excepto el 5");

for (i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.WriteLine("---------------------------------------------------");

//Condicional foreach
String[] nombres = { "Julio","Irving","Amaya"};
Console.WriteLine("Los nombres de los alumnos son: ");
i = 1;
foreach (string alumnos in nombres)
{
    Console.WriteLine(i+"."+alumnos);
    i++;
}

String[] series = { "Last of US", "House of the dragon", "Game of thrones", "Dark" };
Console.WriteLine("Los nombres de las series son los siguientes: ");
i = 1;
foreach (string nombreSeries in series)
{
    Console.WriteLine(i + "." + nombreSeries);
    i++;
}
Console.WriteLine("---------------------------------------------------");

//Condicional do while 

Console.WriteLine("Se mostraran los numeros del 1 al 5");
i = 1;
do 
{
    
    Console.WriteLine(i);
    i++;

}while (i<=5);

Console.WriteLine("Se mostraran los numeros del 1 al 5 excepto el 2");
i = 1;
do
{
    if (i==2)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;

} while (i <= 5);