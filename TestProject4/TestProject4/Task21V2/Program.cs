// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("darling please enter the string");
string s = Console.ReadLine();
// 21 Console.WriteLine(s); //wHAT DO WE NEED cAPS LOCK FOR?

string[] s1 = s.Split(" ");
int upperCount = 0;
bool isFirstLower = true;

for (int i = 0; i < s1.Length; i++)
{
    upperCount = 0;
    string temporaryStr = null;
    isFirstLower = true;

    for (int j = 0; j < s1[i].Length; j++)
    {
        if (s1[i][j] >= 'A' && s1[i][j] <= 'Z')
        {
            upperCount++;
            if (j == 0)
            {
                isFirstLower = false;
            }
        }
    }
    if (upperCount == s1[i].Length || (isFirstLower && upperCount == s1[i].Length - 1))
    {
        for (int j = 0; j < s1[i].Length; j++)
        {
            if (j == 0)
            {
                temporaryStr = s1[i][j].ToString().ToUpper();
            }
            else
            {
                temporaryStr = temporaryStr + s1[i][j].ToString().ToLower();
            }
        }
        s1[i] = temporaryStr;
    }

    Console.WriteLine(s1[i]);
}

