// 4.2 слож
int[,] mas1 = new int[10, 10];
Random r = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        mas1[i, j] = r.Next(-20, 20);
        if (mas1[i, j] < 0) mas1[i, j] = (mas1[i, j] * -1) * 3;
        else if (mas1[i, j] > 0) mas1[i, j] = (mas1[i, j] * -1) * 3;
        Console.Write(mas1[i, j] + " ");
    }
    Console.WriteLine();
}
