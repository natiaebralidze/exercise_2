// სავარჯიშო 13;
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიყვანს ტექსტ და დაითვლის ტექსტში სიტყვების რაოდენობას.
//(პუნქტუაციური ნიშნების რაოდენობას, და მაღალი და დაბალი რეგისტრის სიმბოლოებს)

Console.WriteLine("enter string");
string phrase = Console.ReadLine();
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"{word}");
}

Console.WriteLine("enter string");
string s = Console.ReadLine();
int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] >= 'A' && s[i] <= 'Z')
    {
        count++;
    }
}
Console.WriteLine("number of Uppder case letters " + count);

int counter = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] >= 'a' && s[i] <= 'z')
    {
        counter++;
    }
}
Console.WriteLine("number of lower case letters " + counter);