using  _06_SwitchCase.Models;

{
    Console.WriteLine("Digite uma letra");
    string letra = Console.ReadLine().ToLower();


    switch (letra)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("A letra é uma vogal.");
            break;
        default:
            Console.WriteLine("A letra é uma consoante.");
            break;
    }
}