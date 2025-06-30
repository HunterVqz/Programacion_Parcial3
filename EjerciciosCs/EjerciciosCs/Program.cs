/*
//Programa que asigna dos numeros y devuelve
//la suma, resta, multiplicacion y division

//asignacion de las variables
double num1 = 5, num2 = 10;
double suma, resta, multiplicacion, division;

//Operaciones matematicas
suma = num1 + num2; 
resta = num1 - num2;
multiplicacion = num1 * num2;  
division = num1 / num2;

//Impresion de resultados
Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es " + resta);
Console.WriteLine("La multiplicacion es: " + multiplicacion);
Console.WriteLine("La division es: " + division);

//Desarrollar un programa que asigne 5 notas, calcule y muestre el promedio.
double Area, R;
double pi = 3.14;
R = 5;
Area = pi * R * R;

Console.WriteLine("El area del circulo es: " + Area);
 */




//Programa que calcula el área de un rectángulo

Console.WriteLine("Ingrese la base del rectángulo: ");
double baseRect = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo: ");
double alturaRect = Convert.ToDouble(Console.ReadLine());

double areaRect = baseRect * alturaRect;

Console.WriteLine("El área del rectángulo es: " + areaRect);