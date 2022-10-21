void Check()
{
    while (true)
    {
        Console.WriteLine("Введите слово");
        string w = Console.ReadLine();
        char[] word = w.ToCharArray();
        bool check = false;
        bool checkword = true;

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {


                foreach (char check1 in word)
                {
                    foreach (char check2 in word.Reverse())
                    {
                        if (checkword == true)
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
                }

            }
            else if (char.IsLetter(c) == false)
            {

                checkword = false;

            }
        }
        if (checkword == false)
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели не слово");
            Console.WriteLine();
        }

        if (checkword == true)
        {
            if (check == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Слово палиндром");
                Console.WriteLine();
            }
            else if (check == false)
            {
                if (w == "" || w == " ")
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не слово");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Слово не палиндром");
                    Console.WriteLine();
                }

            }
        }
    }
}
Check();
