const int val = 6;
const int column = 5;

int[,] mass = new int[val, column];
int[] mass1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int counter = 1;

for (int n = 0; n < val; n++)
{
    if (n % 2 == 0)
    {
        for (int m = 0; m < column; m++)
        {
            mass[n, m] = counter;
            counter++;
            Console.Write("{0}\t", mass[n, m]);
        }
    }
    else
    {
        for (int m = column - 1; m >= 0; m--)
        {
            mass[n, m] = counter;
            counter++;
            Console.Write("{0}\t", mass[n, m]);
        }
    }

    Console.WriteLine();
}
