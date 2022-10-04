/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
if (A>B)
{
    Console.Write("max = ");
    Console.WriteLine(A);
    Console.Write("min = ");
    Console.WriteLine(B);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(B);
    Console.Write("min = ");
    Console.WriteLine(A);
}



