// See https://aka.ms/new-console-template for more information
//სავარჯიშო 18

string s = "Tourr!!";
s = s.ToLower();
Console.WriteLine(s);
string[] s1 = new string[s.Length];

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
    {
        s1[i] = null;
    }
    else
    {
        s1[i] = s[i].ToString();
    }
}

for (int i = 0; i < s1.Length; i++)
{
    string k = s1[i];
    if (s1[i] == null)
    {
        continue;
    }

    if (k[0] >= 'a' && k[0] <= 'z')
    {
        Console.Write("." + s1[i]);
    }
    else
    {
        Console.Write(s1[i]);
    }
}
