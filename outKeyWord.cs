/*Business Rules:

Rule 1: If the value is alphanumeric, concatenate it to form a message

Rule 2: If the value is numeric, add it to the total

*/



string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal sum = 0m;
string msg = "";
foreach (string value in values) {
    if(decimal.TryParse(value, out decimal dec))
    {
        sum += dec;
    }
    else
    {
        msg += value;
    }
}
Console.WriteLine($"Message: {msg}");
Console.WriteLine($"Total: {sum}");
