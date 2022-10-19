Console.WriteLine("Введите слово");
string w = Console.ReadLine();
char[] word = w.ToCharArray();
bool check = false;
void Check()
{
    foreach (char check1 in word)
    {
        foreach (char check2 in word.Reverse())
        {

            if (check2 == check1)
            {
                check = true;
            }
            else if (check2 != check1)
            {
                check = false;
            }
        }
    }
    if (check == true)
    {
        Console.WriteLine();
        Console.WriteLine($"Слово палиндром");
        Console.WriteLine();
    }
    else if (check == false)
    {
        Console.WriteLine();
        Console.WriteLine($"Слово не палиндром");
        Console.WriteLine();
    }
}
Check();
