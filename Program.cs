// See https://aka.ms/new-console-template for more information



#region Practica1 
Console.WriteLine("Cual es tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola Bienverido :{nombre}");
Console.WriteLine(DateTime.Now);

#endregion

#region Practica2

#region Ejercicio1
int edad;
string nombre1=null;
string apellido=null;

Console.WriteLine("Escriba su edad y presione enter, luego su nombre y enter luego su apeliido y enter");
edad = Convert.ToInt16(Console.ReadLine());
nombre1  = Console.ReadLine().ToString();
apellido=Console.ReadLine().ToString();

Console.WriteLine($"Bievenido al primer ejercicio de c# {nombre1} {apellido}, tienes una edad de {edad} anos");
#endregion

#region Ejercicio2

//Coche: puertas, ruedas, marca, ITV
int puertas = 4,ruedas=4;
string marca ="Honda", ITV="Nose Que es esto";

Console.WriteLine($"El Coche tiene {puertas} y {ruedas}, es de marca {marca}, y otra variable que nose {ITV}");

//Mesa: peso, largo, material, color 
int peso = 123;
float largo= 123.15f;
string material = "Hierro";
string color = "azul";

Console.WriteLine($"La mesa tiene {peso} y {largo}, es de material {material}, y el color es {color}");

#endregion

#region Ejercicio3

char variable = 'a';
Console.WriteLine("Edad es mayor a 18 {0}", (edad > 18));
Console.WriteLine("son iguales  {0}", (variable == 'a'));
Console.WriteLine("DOs condiciones verdaderas {0}",(edad > 18) && (variable == 'a') );
Console.WriteLine("1 y 1 condiciones  {0}",(edad > 18) && (variable == 'b') );

#endregion



#endregion

#region Practica3

ClienteStruc cliente = new ClienteStruc("Braulio","8294492453","El Millon","braulio-alvarez@hotmail.com");
Console.WriteLine(cliente.ToString());

#endregion

#region Practica4
//Ejercicio 1
#region ejercicio1
int contador=0;
while(contador < 10)
{
    contador++;
 Console.WriteLine("Multiplicador{0} ", (1 * contador));

}
#endregion
//Ejercicio 2
#region ejercicio2
int entero;
int positivoContador=0;
int negatigoContador=0;
do
{

Console.WriteLine("Ingrese un numero entero y luego presione enter.. para finalizar ingrese un 0");
 entero = Convert.ToInt16(Console.ReadLine());

 if(entero > 0 ) 
 {
    positivoContador++;
    Console.WriteLine($"El valor {entero} es positivo  cantidad acumulada {positivoContador}");
    
 }
else
{
    negatigoContador++;
Console.WriteLine($"El valor {entero}, es negativo, cantidad acumulada {negatigoContador}");

}
}
while(entero != 0);

#endregion

#region ejercicio3
Console.WriteLine("Introduce el valor de la coordenada X como un entero");
int _x = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Introduce el valor de la coordenada Y como un entero");
int _y = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Introduce el bool es decir true si es relleno, false si no es relleno");
bool _b = Convert.ToBoolean(Console.ReadLine());

int i, j;
for ( i = 1; i <= _y; i++) 
{
    for (j = 1; j <= _x; j++) 
        Console.Write("*", j);
        Console.WriteLine(" ");
}




#endregion

#endregion