// See https://aka.ms/new-console-template for more information
// savarjisho 20 
// At that as little as possible letters should be changed in the word.
// For example, the word HoUse must be replaced with house, and the word ViP — with VIP.
// If a word contains an equal number of uppercase and lowercase letters,
// you should replace all the letters with lowercase ones.
// For example, maTRIx should be replaced by matrix.
// Your task is to use the given method on one given word.

Console.WriteLine("enter string");
string s = Console.ReadLine();
Console.WriteLine(s);

int uppercase = 0;
int lowercase = 0;

for(int i=0; i < s.Length; i++)
{
    if (s[i]>='A' && s[i] <= 'Z')
    {
        uppercase++;
    }
    else //if (s[i] >= 'a' && s[i] <= 'z')
    {
        lowercase++;
    }
}
if (uppercase <= lowercase) { 
    s=s.ToLower();
}
else
{
    s=s.ToUpper();
}
Console.WriteLine(s);