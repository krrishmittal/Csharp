// See https://aka.ms/new-console-template for more information

// printing statetent
// Console.WriteLine("Enter your name:");

// taking input from user and printing it
// string name =Console.ReadLine();  
// Console.WriteLine($"hello {name}");


// integer calculations and how to use the class that we create outside the program main file

// Calc  c = new Calc();
// int res=c.add(5,10);  //Addition
// Console.WriteLine($"The sum is {res}");
// int res1=c.sub(5,10);  //substraction
// Console.WriteLine($"The sum is {res1}");
// int res2=c.mul(5,10);  //multiplication
// Console.WriteLine($"The sum is {res2}");
// int res3=c.div(5,10);  //division
// Console.WriteLine($"The sum is {res3}");

// Control Statements 

// In i=new In();
// int age=i.Inp1();
// if (age > 10)
// {
//     Console.WriteLine("Eligible");
// }
// else
// {
//     Console.WriteLine("Not eligible");
// }

// loops in c#
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"value :{i}");
// }

//class in c# 
// class Program
// {
//     static void greet(String name)
//     {
//         Console.WriteLine($"Hello :{name}");
//     }
//     static void main()
//     {
//        greet("krrish");
//        greet("madhuarya"); 
//     }
// }


// variables in c#
// int age=18;
// string name="Krrish";
// bool flag=true;
// double pi=3.14;

// arrays in c#
// string[] students={"krrish","nitin","abhishek","nikhil"};
// for(int i = 0; i < students.Length; i++)
// {
//     Console.WriteLine($"Name: {students[i]}");
// }



// class Car
// {
//     public string name="beep";

// static void Main()
// {   
//     Car c =new Car();
//     Car c1=new Car();

//     Console.WriteLine(c.name);
// }
// }

// class Test :Car
// {
//     static void Main()
//     {
//         Hell h=new Hell();
//         h.print();
//     }
// }

// if else statements
// int age=10;
// if (age > 18)
// {
//     Console.WriteLine("Voting Eligible");
// }
// else
// {
//     Console.WriteLine("Voting not eligible");
// }

//out parameter used to return multiple values from a method
// void hi(out int num1,out int num2){
//     num1=20;
//     num2=30;
// }
// int num1,num2;
// hi(out num1,out num2);
// Console.WriteLine(num1);
// Console.WriteLine(num2);

// Arrays in C#

// int[] arr={1,2,3,4,5};
// foreach (int a in arr)
// {
//     Console.WriteLine(a);
// }

// taking input for the array in the integer array
// int[] arr=new int[5];
// for(int i=0;i<arr.Length;i++)
// {
//     int val=Convert.ToInt32(Console.ReadLine());
//     arr[i]=val;
// }
// foreach (int a in arr)
// {
//     Console.WriteLine(a);
// }

// use of params we can pass any number of values in the function parameter
// int[] arr={1,2,3,4,5};
// static int add(params int[] arr)
// {
//     int total=0;
//     foreach (int a in arr)
//     {
//         total+=a;
//     }
//     return total;
// }
// // int total=add(arr); simple way of passing the value to the method in the form of array
// int total=add(1,2,3,4,5,6);
// Console.WriteLine(total);

// string array
// string[] arr=new string[5];
// for(int i = 0; i < arr.Length; i++)
// {
//     string name=Console.ReadLine();
//     arr[i]=name;
//     Console.WriteLine(arr[i]);
// }


// 2d array we create using a comma in the bracket
// int[,] arr=new int[4,2];
// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; j < 2; j++)
//     {
//         arr[i,j]=Convert.ToInt32(Console.ReadLine());
//     }
// }

// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; j < 2; j++)
//     {
//         Console.Write(arr[i,j]+" ");
//     }
//     Console.WriteLine();
// }


// jump statements
//break stops the loop and come out of it
// for(int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

//continue omiit the iteration and comes to the top of that loop
// for(int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

//go to used to give transfer to the labeled statement
// int i=6;
// switch (i)
// {
//     case 0:
//         Console.Write(0);
//         break;
//     case 1:
//         Console.Write(1);
//         break;
//     case 2:
//         Console.Write(2);
//         break;
//     case 6:
//         Console.Write(6);
//         goto case 1;
// }

// sorting an array Array.Sort() is the method for sorting the array in C#
// int[] arr=new int[5]{1,5,23,33,7};
// Array.Sort(arr);
// foreach(int a in arr)
// {
//     Console.WriteLine(a);
// }
// Console.Write(Array.BinarySearch(arr,23));


// Class and object in C#
// class is the user defined type that contains fields, methods and its members memory are allocated when the object of the class is being created

// class ClassName{
//     // Fields
//     // Properties
//     // Methods
// }

// here we have used the classes and object to display the values that were being passed as the parameters. the new keyword is used for instantiating a class by allocation memory for new object
class Num
{
    public int a,b;
    public void display(int a,int b)
    {
        this.a=a;
        this.b=b;
        Console.Write(a+ " "+b);
    }
}
class Program
{
    static void Main()
    {
        Num n=new Num();
        n.display(4,6);
    }
}

// Methods in C#
