// int FindQuart (double x, double y)
// {
//     if(x>0 && y>0)
//     return 1;
//     if(x<0 && y>0)
//     return 2;
//     if(x<0 && y<0)
//     return 3;
//     if(x>0 && y<0)
//     return 4;

//     return 0;
// }
// Console.WriteLine("Input X:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y:");
// double y = Convert.ToDouble(Console.ReadLine());

// int result = FindQuart(x,y);

// if(result==0)
// Console.WriteLine("Point not find");
// else
// Console.WriteLine($"Point located in {result} quart");


// Console.WriteLine("Input X:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y:");
// double y = Convert.ToDouble(Console.ReadLine());
// void toch1(double x , double y )



// void Coordinats( double x, double y,double x1, double y1)
// {
//    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x-x1),2)+Math.Pow((y-y1),2)),2));
// }
// Console.WriteLine("input x=");
// double x=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y=");
// double y=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input x1=");
// double x1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y1=");
// double y1=Convert.ToDouble(Console.ReadLine());
// Coordinats(x,y,x1,y1);



// Console.WriteLine("Input N:");
// double N = Convert.ToDouble(Console.ReadLine());
// Quad(N);

// void Quad(double A)
// {
//     int i = 1;
//     double z = 0;
//     while (i < A + 1)
//     {
//         z = Math.Pow(i, 2);
//         Console.WriteLine($" {i} -> {z}:");
//         i++;

//     }
// }

// //Задача 19

// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void comparPolindrom(string str)
// {
//     int n = str.Length;
//     string rezStr = "";
//     for (int i = n - 1; i >= 0; i = i - 1)
//     {

//         //Console.WriteLine($" {i} -> {str[i]}:");
//         rezStr = rezStr + str[i];
//     }
//     if (str == rezStr)
//         Console.WriteLine($"Число : {rezStr} - полиндром !!!");
//     else
//     {
//         Console.WriteLine($"Число : {rezStr} - НЕ полиндром :-(");
//     }
// }

// Console.WriteLine("Input число:");
// string pol = Console.ReadLine();

// comparPolindrom(pol);

// //Задача 21
// //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// //A (7,-5, 0); B (1,-1,9) -> 11.53

// void fPoint(float[] arrPoint1)
// {
//     Console.Write("x=");
//     float x = float.Parse(Console.ReadLine());
//     arrPoint1[0] = x;
//     Console.Write("y=");
//     float y = float.Parse(Console.ReadLine());
//     arrPoint1[1] = y;
//     Console.Write("z=");
//     float z = float.Parse(Console.ReadLine());
//     arrPoint1[2] = z;
//     //Console.WriteLine($"Точка 1 ({x} , {y} , {z})");

//     int count = 3;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arrPoint1[i]} , ");
//     }

//     //return; //($"{arrPoint1[0] } , {arrPoint1[1]} , {arrPoint1[3]}");
// }

// Console.WriteLine($" ВВедите точку 1 : ");
// float[] P1 = { 0, 0, 0 };
// fPoint(P1);
// Console.WriteLine($" __-->\n  -->  P1[ {P1[0]} , {P1[1]} , {P1[2]} ]");
// Console.WriteLine($"\n\n ВВедите точку 2 : ");
// float[] P2 = { 0, 0, 0 };
// fPoint(P2);
// Console.WriteLine($"\n  -->  P2[ {P2[0]} , {P2[1]} , {P2[2]} ]");



// void Coordinat3D(float[] arr1, float[] arr2)
// {
//     double DL;
//     DL = Math.Round(Math.Sqrt(Math.Pow((arr1[0] - arr2[0]), 2) + Math.Pow((arr1[1] - arr2[1]), 2) + Math.Pow((arr1[2] - arr2[2]), 2)), 4);
//     Console.WriteLine($"Расстояние между двумя точками в 3D пространстве :  -->  {DL}");
// }

// Coordinat3D(P1, P2);



//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("ВВедите число :  ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write($"\n");
Cube(n);
Console.Write($"\n\n");
void Cube(double N)
{
    int i = 1;
    double z = 0;
    while (i < N + 1)
    {
        z = Math.Pow(i, 3);
        Console.WriteLine($" Куб числа {i}  будет  --> {z}:");
        i++;

    }
}

