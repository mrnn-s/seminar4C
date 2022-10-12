//поиск числа в массиве
bool Poisk2(int[] coll, int find)
{
    foreach (int i in coll)
    {
        if (i == find)
        return true;
    }
    return false;
}
void PrintNumz(int[] collit)
{
    int count = collit.Length;
    int position = 0;
    foreach (int item in collit)
    {
        Console.Write($"{collit[position]} ");
        position++;
    }
}
void FillnumZ(int[] coll)
{
    int n = coll.Length;
    Random ruk = new Random();
    for (int i = 0; i < n; i++)
    {
        coll[i] = ruk.Next(1, 10);
    }
}
Console.WriteLine("vvedite dlinu massiva");
int dlinna = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("vvedite chislo dlya poiska");
int isk = int.Parse(Console.ReadLine() ?? "0");
int[] numz = new int[dlinna];
FillnumZ(numz);
PrintNumz(numz);
Console.WriteLine(Poisk2(numz, isk)? "chislo est" : "chisla net");