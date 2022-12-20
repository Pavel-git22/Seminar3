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



void comparPolindrom(string str)
{
    int n = str.Length;
    string rezStr = "";
    for (int i = n - 1; i >= 0; i = i - 1)
    {

        //Console.WriteLine($" {i} -> {str[i]}:");
        rezStr = rezStr + str[i];
    }
    if (str == rezStr)
        Console.WriteLine($"Число : {rezStr} - полиндром !!!");
    else
    {
        Console.WriteLine($"Число : {rezStr} - НЕ полиндром :-(");
    }
}

Console.WriteLine("Input число:");
string pol = Console.ReadLine();

comparPolindrom(pol);