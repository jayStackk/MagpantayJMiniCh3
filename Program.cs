// John Magpantay  
// 10-20-22
// This is a program that would ask the user about their names and what time they woke up,
// I will be using
// Peer Review: Brandon Le - Project works as intended. I'm able to do two user inputs and 
// play again function works. Does need data validation and then it would be perfect.
// but it's understandable due to John having to restart due to laptop issues.
// Good job overall.

Console.Clear();
bool truHart = true;
string runAgain = "";
// string playAgain = "yes";
int numAnswer = 0;


while (runAgain != "done")
{

    //string name;


    Console.Write("What is your name? ");
    string name = Console.ReadLine();
    name = name.ToUpper();
    truHart = Int32.TryParse(name, out numAnswer);



    // string time;
    //Console.Write("What time did you wake up?");
    //string time = Console.ReadLine();

    //Console.WriteLine("Hello, " + name + " you woke up at " + time + "!");

    //Console.WriteLine("Do you want to run the program again");
    //Console.Write(" yes or press 'enter' ");

    //playAgain = Console.ReadLine();

    Console.WriteLine("------------------");


    if (truHart == true)
    {

        Console.WriteLine(" Invalid, you got numbers in your name?");
    }

    // Console.WriteLine(" Let's run it again!");
    else
    {
        Console.WriteLine($"You said your name is {name}? SO unique! time you woke up?");

        string nameTwo = Console.ReadLine();

        Console.WriteLine($"{nameTwo} is still a good time, my sleep sched is not good atm ");
    }

    Console.WriteLine("If you want to end it type done or just press enter to restart");
    runAgain = Console.ReadLine();

}

