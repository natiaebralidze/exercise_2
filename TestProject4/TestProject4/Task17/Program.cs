// See https://aka.ms/new-console-template for more information
//სავარჯიშო 17
string s = Console.ReadLine();
Console.WriteLine(s);
string[] splitArray = s.Split('+');
string min = splitArray[0];

Array.Sort(splitArray);

for (int i = 0; i < splitArray.Length; i++)
{

    Console.WriteLine(splitArray[i]);
}
string s1 = null;
for (int i = 0; i < splitArray.Length; i++)
{
    s1 = s1 + splitArray[i];
    if (i < splitArray.Length - 1)
    {
        s1 = s1 + "+";
    }
}
Console.Write(s1);