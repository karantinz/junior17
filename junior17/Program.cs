Random rand = new Random();
int randomNumber = rand.Next(100);

int degree = 0;
int totalCount = 1;
int multiplicationNumber = 2;

Console.WriteLine("Заданное число: " + randomNumber);

while (totalCount <= randomNumber)
{
    degree++;
    totalCount *= multiplicationNumber;
}

Console.WriteLine($"{multiplicationNumber} в степени {degree} = {totalCount}");