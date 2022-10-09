// See https://aka.ms/new-console-template for more information
// სავარჯიშო 10
//დაწერეთ პროგრამა რომელიც მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას.
int[] array = new int[] { 7, 5, -9, 1, -23, -5, 6, 8, 5 };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        count++;
    }
}
Console.WriteLine(count);