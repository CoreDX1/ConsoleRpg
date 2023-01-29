namespace CSharpConsoleRpg;

public class Game {
    bool end;
    private void InitVariables() {
        this.end = false;
    }
    public Game(){
        this.InitVariables();
        Console.WriteLine("Welcome to C# Console RPG!");
    }

    public void Run(){
        while(this.end == false){
            Console.WriteLine("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number < 0)
                this.end = true;
            else
                Console.WriteLine("You inputted: " + number);
        }
        Console.WriteLine("Ending game...");
    }
}
