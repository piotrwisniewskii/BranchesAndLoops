/*
ExploreIf();

void ExploreIf()
{

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second number");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("And the first number is not equal to the second number");
}
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("Or the first number is equal to the second number");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second number");
}
}

int counter = 0;
do
{
    Console.WriteLine($"Hello World the counter is {counter}");
    counter++;
} while (counter < 10);

*/


// for (int index = 0; index < 10; index++)
// {
//    Console.WriteLine($"Hello World! The index is {index}");
// }

/*

for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}

for (int column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column in {column}");
}

*/


for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
