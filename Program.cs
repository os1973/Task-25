/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число А");
string A = Console.ReadLine();
int numberA = int.Parse(A);
Console.WriteLine("Введите число B");
string B = Console.ReadLine();
int numberB = int.Parse(B);

void Power (double A, int B)
{    
    double pow=1;
    for (int i = 1; i <=B; i++)
    pow *=A;    
    cout <<pow;    
}
 
int main()
{
    int B;
    double A;
    cout <<"Введите число A: "; cin >>A;
    cout <<"Введите число B: "; cin >>B;
    Power (A, B);
    system("pause");
    return 0;
}