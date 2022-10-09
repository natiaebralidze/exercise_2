// See https://aka.ms/new-console-template for more information
//სავარჯიშო 3
//კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ 1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი
int.TryParse(Console.ReadLine(), out int numOddNumbers);
int sum = 0;
int multiple = 1;

for (int i = 1; i <= numOddNumbers; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + i;
        multiple = multiple * i;
    }
}
Console.WriteLine(sum);
Console.WriteLine(multiple);
