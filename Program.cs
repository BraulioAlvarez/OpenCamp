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
