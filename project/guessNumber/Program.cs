class Program
{
    static void Main()
    {
        Random r=new Random();
        int secret=r.Next(1,10);
        int attempts=0;
        int guess=0;
        // Console.Write(secret+" "+guess);
        while(guess!=secret){
            Console.WriteLine("Enter a number: ");
            try{
                guess=Convert.ToInt32(Console.ReadLine());
                attempts++;
                if(guess>secret){
                    Console.WriteLine("Too High"); 
                }
                else if(guess<secret){
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number in: "+attempts+" attempts");
                }
            }
            catch{
                Console.WriteLine(" Invalid input!");
            }
        }
    }
}