// See https://aka.ms/new-console-template for more information
// სავარჯიშო 16

string s = "pneumonoultramicroscopicsilicovolcanoconiosis";
int count = 0;

for (int i = 1; i < s.Length - 1; i++)
{
    count++;
}
Console.Write(s[0]); Console.Write(count);
Console.Write(s[s.Length - 1]);

