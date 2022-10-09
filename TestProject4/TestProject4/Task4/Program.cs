// See https://aka.ms/new-console-template for more information
//სავარჯიშო 4
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი რიცხვისთვის
//დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.

int.TryParse(Console.ReadLine(), out int nums);
int sumofSquares = 0;
int j;

for (int i = 1; i <= nums; i++)
{
    j = i * i;
    sumofSquares = sumofSquares + j;
}
Console.WriteLine(sumofSquares);
