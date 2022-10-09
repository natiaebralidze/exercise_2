// See https://aka.ms/new-console-template for more information
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიტანს 10 ელემენტს და შეავსებს მასივს. (სცადეთ სხვადასხვა ტიპისთვის)

Console.WriteLine("Enter 10 elements:");
int[] numbers=new int[10];

for(int i=0; i<numbers.Length; i++)
{
    int.TryParse(Console.ReadLine(), out int elements);
    numbers[i] = elements;
}

for(int i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
