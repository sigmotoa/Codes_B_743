/*
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Vamos a validad la divisivilidad de un numero");
Console.WriteLine("Ingrese el divisor");
int divisor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el dividendo");
int dividendo = Convert.ToInt32(Console.ReadLine());

var resultado = dividendo % divisor;

Console.WriteLine($"El numero {dividendo} es {resultado==0} divisible por {divisor}");
*/

Console.WriteLine("Ingrese la cantidad de numeros");

int fin = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] sumar = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] producto = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
//while (i < fin)
//{
  //  sumar[i] = producto[i] * 3;
    //Console.WriteLine($"En la posición: {i}\tsumar:{sumar[i]} \tproducto: {producto[i]}");
    //i++;
    //Console.WriteLine(sumar[i]);
    //i = i+1;
//}
//Console.WriteLine(sumar);

    for (int j = 1; j < fin; j=j+2)
    {
        Console.WriteLine(j);
    }

