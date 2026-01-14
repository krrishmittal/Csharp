// properties in C# is a member in C# that allows to read write or compute the value of the private field easily by using the get,set methods 
// The block of “set” and “get” is known as Accessors. It is very essential to restrict the accessibility of the property. There are two types of accessors: get accessors and set accessors.

// class Program
// {
//     private int age;
//     public int Get_Age
//     {
//         get{return age;}
//     }
//     public int Set_Age
//     {
//         set
//         {
//             if(value>=0){age=value;}
//             else
//             {
//                 Console.WriteLine("Age cannot be negtive");
//             }
//         }
//     }
// }

// class C
// {
//     public static void Main()
//     {
//         Program p=new Program();
//         p.Set_Age=-25;
//         Console.WriteLine(p.Get_Age);
//     }
// }

//auto implemented get set
// class Prog
// {
//     public string name
//     {
//         get;
//         set;
//     }="Krrish";
// }
// class M
// {
//     public static void Main()
//     {
//         Prog p=new Prog();
//         Console.WriteLine(p.name);
//         p.name="Mittal";
//         Console.WriteLine(p.name);
//     }    
// }


//Constructors in C# these are automatically called when the object of the class is being created it has the same name as the class and it doesnot have any return type and used to initialize the class's object data members
// class P
// {
//     public P()
//     {
//         Console.WriteLine("Constructor Called");
//     }
// }
// class M
// {
//     public static void Main()
//     {
//         P obj=new P();
//     }
// }

// Constructor of 5 types
// default with no parameters

// parameterized with parameters at least one
// class Program
// {
//     int n;
//     Program(int n)
//     {
//         this.n=n;
//         Console.WriteLine(n);
//     }
//     public static void Main()
//     {
//         Program p=new Program(3);
//     }
// }

// copy creating a new object by copying the values from an existing object of the same class
// class Program
// {
//     string month;
//     int year;
//     Program (Program obj)
//     {
//         month=obj.month;
//         year=obj.year;
//     }
//     Program(string month,int year){
//         this.month=month;
//         this.year=year;
//     }
//     public  string details{
//         get{
//             return "month: "+month +" year: "+year.ToString();
//         }
//     } 
//     public static void Main()
//     {
//         Program p1=new Program("January",2004);
//         Program p2=new Program(p1);
//         Console.WriteLine(p2.details);
//     }
// }

// static 


// private Using a private constructor prevents the creation of the instances of that class it may cause error when we try to create the object of the class we use this when we only have static members in our class
// class Prog
// {
//     private Prog()
//     {
//         Console.WriteLine("Private constructor");
//     }
//     public static int cnt;
//     public static int inc()
//     {
//         return cnt++;
//     }
//     public static void Main()
//     {
//         Prog.cnt=10;
//         Console.WriteLine(Prog.cnt);
//         Prog.inc();
//         Console.WriteLine(Prog.cnt);
//     }
// }


// Destructor in C#  it is automatically called when the object is destroyed It is used to release unmanaged resources like file handles, database connections

// class P
// {
//     P()
//     {
//         Console.WriteLine("Constructor called");
//     }
//     ~P()
//     {
//         Console.WriteLine("destructor called");
//     }
//     public static void Main()
//     {
//         P obj=new P(); 
//     }
// }


// Exception Handling in C#

// In C#, exception handling is the process of responding to runtime anomalies, called exceptions, in a controlled way. Proper handling ensures that a program continues to run or exits gracefully instead of crashing unexpectedly. C# provides structured exception handling using the keywords try, catch, finally, and throw.

// class M
// {
//     public static void main()
//     {
//         try
//         {
//             int res=10/0;
//             Console.WriteLine(res);
//         }
//         catch(DivideByZeroException e)
//         {
//             Console.WriteLine("Exception: "+e);
//         }
//     }
// }

// try: The try block contains the code that might throw an exception. Only the code inside the try block is monitored for exceptions.
// catch: The catch block handles exceptions thrown in the try block. You can have multiple catch blocks to handle different exception types
// finally: The finally block always executes, whether an exception occurs or not. It is mainly used for cleanup tasks like closing files, releasing resources, or clearing memory
// throw: The throw keyword is used to manually raise an exception. It can be used to signal that an error or invalid condition has occurred.
//Exception handling prevents programs from crashing due to runtime errors.

// class P
// {
//     public static void Main()
//     {
//         try
//         {
//             int [] arr=new int[6]{1,2,3,4,5,10/0};

//             // if (arr[2] < 10)
//             // {
//             //     throw new ArgumentException("Less than 10");
//             // }
//             Console.WriteLine(arr[5]);
//         }
//         catch (IndexOutOfRangeException e)
//         {
//             Console.WriteLine("Exception "+e);
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e);
//         }
//         finally
//         {
//             Console.WriteLine("This always executes");
//         }
//     }
// }

// user created exception
// class M
// {
//     class AgeOutOfBound : Exception
//     {
//         public AgeOutOfBound(String message):base(message){}
//     }
//     class P
//     {
//         public static void Main()
//         {
//             try
//             {
//                 int age=10;
//                 if(age<18)
//                 {
//                     throw new AgeOutOfBound("Age is less than 18");
//                 }
//             }
//             catch(AgeOutOfBound e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }


// Absraction in C# An abstract class cannot be directly instantiated. We can only create objects of derived classes.Abstract methods are declared in the abstract classes but do not have implementation, derived classes are required to implement them.
// public abstract class Animal
// {
//     public abstract string sound{get;}
//     public virtual void Move()
//     {
//         Console.WriteLine("Animal is moving");        
//     }

// }
// public class Cat: Animal
// {
//     public override string sound=>"Meow";
//     public override void Move()
//     {
//         Console.WriteLine("Cat is moving");
//     }
// }
// public class Dog : Animal
// {
// 	public override string sound => "Woof";
// 	public override void Move()
// 	{
// 		Console.WriteLine("Dog is moving");
// 	}
// }
// class P
// {
//     public static void Main()
//     {
//         Animal a=new Dog();
//         Animal b=new Cat();
//         Console.WriteLine(a.sound);
//         a.Move();
//         Console.WriteLine(b.sound);
//         b.Move();
//     }
// }

// we use abstract class at the time of inheritance. 
// A derived class must use the override keyword to implement an abstract method.
// It can contain constructors or destructors.
// It can implement functions with non-Abstract methods.
// It cannot support multiple inheritances.
// It can’t be static.

// public abstract class Base{
//     public abstract void display();
// }
// public class Child1 : Base
// {
//     public override void display()
//     {
//         Console.WriteLine("Child1");
//     }
// }

// public class Child2 : Base
// {
//     public override void display()
//     {
//         Console.WriteLine("Child2");
//     }
// }
// class M
// {
//     public static void Main()
//     {
//         Base b=new Child1();
//         b.display();
//         b=new Child2();
//         b.display();
//     }
// }