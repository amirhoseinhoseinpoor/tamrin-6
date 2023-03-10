//Amirhosein hoseinpoor.
ConsoleKeyInfo digit;
int keybord;
int x =Convert.ToInt32(Console.ReadLine());
do
{
    Console.WriteLine("Hi! welcome to my app i have some qoustion from you first of all how old are you ");

    keybord = 0;
    do
    {
        do
        {
            digit = Console.ReadKey(true);
        } while (digit.KeyChar.ToString() != "0" && digit.KeyChar.ToString() != "1" && digit.KeyChar.ToString() != "2" &&
                 digit.KeyChar.ToString() != "3" && digit.KeyChar.ToString() != "4" && digit.KeyChar.ToString() != "5" &&
                 digit.KeyChar.ToString() != "6" && digit.KeyChar.ToString() != "7" && digit.KeyChar.ToString() != "8" &&
                 digit.KeyChar.ToString() != "9" && digit.Key.ToString() != "Enter");
        if (digit.Key.ToString() != "Enter")
        {
            keybord = keybord * 10 + Convert.ToInt32(digit.KeyChar.ToString());
            Console.Write(digit.KeyChar);
        }

    } while (digit.Key.ToString() != "Enter");
    Console.WriteLine();

   
    switch (x)
    {
        case  >= 18:
            Console.WriteLine("youre an adult");
            break;
        case >= 3:
            Console.WriteLine("youre a kid");
            break;
        case >= 0:
            Console.WriteLine("youre a baby");
            break;
        case < 0:
            Console.WriteLine("._.");
            break;
    }
    Console.WriteLine("do you want to continue? if so press 'y'otherwise prees 'n':");
    do
    {
        digit = Console.ReadKey(true);
    } while (digit.KeyChar.ToString() != "y" && digit.KeyChar.ToString() != "n");

} while (digit.KeyChar.ToString() == "y");

