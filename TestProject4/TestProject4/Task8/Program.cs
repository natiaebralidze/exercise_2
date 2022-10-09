// See https://aka.ms/new-console-template for more information
//სავარჯიშო 8
//დაწერეთ პროგრამა რომელიც მასივში დაითვლის ამ მასივში უმცირეს,
//უდიდეს ელემენტს და იპოვნის მედიანას(შუა წევრს)

int[] array = new int[] {5,20,6,8,9,15,1,7,25};
int temp;
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max= array[i];
    }
    if(min > array[i])
    {
        min= array[i];
    }
}

Console.WriteLine("minimum "+min);
Console.WriteLine("maximum " + max);

int x = array.Length;
if (x % 2 == 0)
{
    int k = array.Length / 2;
    int middle = (array[k - 1] + array[k]) / 2;
    Console.WriteLine("middle "+middle);
}
else
{
    int middle = array[array.Length / 2];
    Console.WriteLine("middile "+middle);
}