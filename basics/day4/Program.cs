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

