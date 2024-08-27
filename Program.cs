using RPG.src.Entities;

class Program {
    static void Main(string[] args) {

        Hero hero = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizzard");
        blackWizard blackWizard = new blackWizard("Topapa", 42, "Black Wizzard");
        Ninja ninja = new Ninja("Wedge", 42, "Ninja");

        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));

        Console.WriteLine(blackWizard.Attack(1));
        Console.WriteLine(blackWizard.Attack(7));

        Console.WriteLine(ninja.Attack(1));
        Console.WriteLine(ninja.Attack(7));
    }
}