// See https://aka.ms/new-console-template for more information
//სავარჯიშო 2. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს რიცხვს n-ს და დაბეჭდავს 1-დან n მდე რიცხვებს ისე
//როგორც სურათზეა(სურ 1).
//(თითო ხაზზე ელემენტების რაოდენობა იზრდება 1-ით)

Console.WriteLine("enter digit");
int.TryParse(Console.ReadLine(), out int n);
int line = 1;
int printedSymbolsOnLine = 0;


for(int i = 1; i <= n; i++)
{
    if(printedSymbolsOnLine < line)
    {
        for (int j = 1; j <= 3; j++) {
            Console.Write(" ");
        }
        Console.Write(i + " ");
        printedSymbolsOnLine++;
    }
    else 
    {
        line++;
        Console.WriteLine();
        Console.Write(i + " ");
        printedSymbolsOnLine=1;
    }
}
