// See https://aka.ms/new-console-template for more information
//სავარჯიშო 14
//დაწერეთ პროგრამა რომელიც ტექსტში დაითვლის ხმოვნებს/თანხმოვნებს.

Console.WriteLine("enter string");
string s = Console.ReadLine();
int vowels = 0, ccount = 0;

foreach (char c in s)
{
    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
    {
        if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            vowels++;
        }
        else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            vowels++;
        }
        else
        {
            ccount++;
        }
    }
}
Console.WriteLine("number of vowels " + vowels);
Console.WriteLine("number of constraints " + ccount);
