// See https://aka.ms/new-console-template for more information

bool Exit = false;
do
{
    Random RpsGen = new Random();
    int CPicked = RpsGen.Next(1, 4);
    Cdecider();
    string Win = "You win!";
    string Lose = "You lose!";
    string Draw = "It's a draw";
    Console.WriteLine(CPicked);
    Console.WriteLine("Please pick Rock, Paper or Scissors");
    string PPicked = Console.ReadLine();
    GameBrain(PPicked);

    void GameBrain(string Pinput)
    {
        if (Pinput == Cdecider())
        {
            Console.WriteLine("The opponent picked "+ Cdecider()) ;
            Console.WriteLine(Draw); 
        }
        else if (Pinput == "Paper" && Cdecider() == "Rock")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Win); 
        }
        else if (Pinput == "Paper" && Cdecider() == "Scissors")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Lose); 
        }
        else if (Pinput == "Rock" && Cdecider() == "Paper")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Lose); 
        }
        else if (Pinput == "Rock" && Cdecider() == "Scissors")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Win); 
        }
        else if (Pinput == "Scissors" && Cdecider() == "Paper")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Win); 
        }
        else if (Pinput == "Scissors" && Cdecider() == "Rock")
        {
            Console.WriteLine("The opponent picked "+ Cdecider());
            Console.WriteLine(Lose); 
        }
        else if(Pinput == "Exit") { Exit = true; }
        else { Console.WriteLine("Please pick Rock, Paper, Scissors, or Exit"); }
    }

    string Cdecider()
    {
        string Cinput;
        if (CPicked == 1) { return Cinput = "Rock"; };
        if (CPicked == 2) { return Cinput = "Paper"; };
        if (CPicked == 3) { return Cinput = "Scissors"; };
        return Cinput = "yes";
    }
}
while (Exit== false);
