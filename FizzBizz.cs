for (int i = 1; i < 101; i++)
{
    string Fizz = "";
    string Bizz = "";
    string symbol ="";
    int fizz = i%3;
    int bizz = i%5;
    if (fizz == 0 || bizz == 0) symbol = " - ";
    if (fizz == 0) Fizz = "Fizz";
    if (bizz == 0) Bizz = "Bizz";
    Console.WriteLine($"{i}{symbol}{Fizz}{Bizz}");
}
