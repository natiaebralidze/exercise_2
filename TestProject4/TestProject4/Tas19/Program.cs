// See https://aka.ms/new-console-template for more information
//სავარჯიშო 19
Console.WriteLine("enter name with lower character");
string name = Console.ReadLine();
string newname = null;
int counter = 0;
if (name.Length > 100)
{
    Console.WriteLine("debili xar?");
}
else
{
    for (int i = 0; i < name.Length; i++)
    {
        counter = 0;
        for (int j = 0; j < i; j++)
        {
            if (name[j] == name[i])
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            newname = newname + name[i];
        }
    }
}
if (newname.Length % 2 != 0)
{
    Console.WriteLine("IGNORE HIM!");
}
else
{
    Console.WriteLine("CHAT WITH HER!");
}
Console.WriteLine(newname);
