//სავარჯიშო 12
//დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში მხოლოდ იმ ელემენტებს რომლებიც გვხვდება 1 ხელ.

//-23,1,1,5,5,5,5,7,7,8,9

int[] array = new int[] { 7, 5, 1, 9, 7, 1, -23, 5, 5, 8, 5 };
for (int i = 0; i < array.Length; i++)
{
    bool isRepetable = false;
    for (int j = 0; j < array.Length; j++)
    {
        if (i == j)
        {
            continue;
        }
        if (array[i] == array[j])
        {
            isRepetable = true;
        }
    }

    if (!isRepetable)
    {
        Console.WriteLine(array[i]);
    }
}