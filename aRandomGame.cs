/* game rules:
If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/




var dice = new System.Random();
List <int> rolls = new List<int>();
int bonusCount = 0; 
for(int i = 0; i < 3; i++){
    rolls.Add(dice.Next(1,7));
}

if (rolls[0] == rolls[1]) {
    bonusCount++;
}

if (rolls[0] == rolls[2]) {
    bonusCount++;
}

if (rolls[1] == rolls[2]) {
    bonusCount++;
}
rolls.Add(bonusCount*2);
rolls.ForEach(Console.WriteLine);

Console.WriteLine(rolls.Sum());

if (rolls.Sum() >= 15){
    Console.WriteLine("Win");
} else {
    Console.WriteLine("Lose");
}
