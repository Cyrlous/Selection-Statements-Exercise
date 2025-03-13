namespace Exercise_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your favorite school subject?");
        string favoriteSubject = Console.ReadLine();

        switch (favoriteSubject.ToLower())
        {
            case "math":
                Console.WriteLine("Great choice.  Math is a very useful subject and has a wide variety of applications.");
                break;
            case "programming":
                Console.WriteLine("Being able to write computer programs will open many doors in the modern job market.");
                break;
            case "english":
                Console.WriteLine("Mastery of the English language will allow you to become an effective communicator.");
                break;
            case "physics":
                Console.WriteLine("Studying the laws of physics will give tremendous insight into some of the world's greatest mysteries.");
                break;
            case "spanish":
                Console.WriteLine("Being fluent in multiple languages will give you an advantage when speaking with people of other cultures.");
                break;
            case "history":
                Console.WriteLine("The study of history is fascinating and will help you better understand the nature of humanity.");
                break;
            default:
                Console.WriteLine("That is a very unique and interesting choice.  What is your favorite part about this subject?");
                break;
        }
    }
}