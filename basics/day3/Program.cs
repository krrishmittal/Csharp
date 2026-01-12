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
// class is the user defined type that contains fields, methods and its members memory are allocated when the object of the class is being created  This approach makes programs more organized, reusable and easier to maintain.

// Object in C# is something you create from a class, which represents a real-world entity and lets you use the data and actions defined in that class. When an object is created, the class is instantiated. All objects share the class’s behavior, but each has its own unique state. A class can have multiple instances.When we declare a reference variable in C# (like Dog tuffy or Dog freedo), no memory for the object is allocated at that time.

// class ClassName{
//     // Fields
//     // Properties
//     // Methods
// }

// here we have used the classes and object to display the values that were being passed as the parameters. the new keyword is used for instantiating a class by allocation memory for new object
// class Num
// {
//     public int a,b;
//     public void display(int a,int b)
//     {
//         this.a=a;
//         this.b=b;
//         Console.Write(a+ " "+b);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Num n=new Num();
//         n.display(4,6);
//     }
// }



// Methods in C# A method is a block of code that performs a specific task. It can take inputs, return results and is defined within classes to make programs modular, readable and reusable.

// static int Add(int a, int b){
//     return a + b;
// }
// Access Modifier: Defines the visibility of the method.
// Return Type: Specifies the type of value the method returns.
// Method Name: The name used to call the method.
// Parameters: A list of inputs the method can take and it is optional
// Method Body: The block of code that defines what the method does

//method calling can be of two types direct method calling and static method calling
// direct method is when we invoke the method using the instance of the class
// class P
// {
//     public void print()
//     {
//         Console.WriteLine("Direct method calling");
//     }
// }
// class M()
// {
//     public static void Main()
//     {
//         P obj=new P();
//         obj.print(); 
//     }
// }

// static method we dont need to create the object of the class we can use the method by using the class name directly
// class P
// {
//     public static int print(int value)
//     {
//         return value*value;
//     }
// }
// class M()
// {
//     public static void Main()
//     {
//         int res=P.print(4);
//         Console.Write(res);
//     }
// }

// Method Parameters
// Parameter       Description                                 Example

// Value           Passes a copy of the argument               void Display(int x)

// Reference       Passes a reference to the argument          void Update(ref int x)

// Output          Parameter Used to return multiple values    void GetValues(out int x)

