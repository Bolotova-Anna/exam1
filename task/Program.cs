int NewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<3)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
    return count;
}
void FillNewArray(string[] array, string[] newarray)
{
    int g = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<3)
        {
            newarray[g] = array[i];
            g++;
        }
    }
}
void Print(string[] array)
{
    System.Console.WriteLine("["+ string.Join(",", array)+"]");
}

string[] ourarray = {"more", "-5", "dog", "beautiful","4"};
int n = NewArray(ourarray);
string[] ourarray2 = new string[n];
FillNewArray(ourarray,ourarray2);
Print(ourarray2);