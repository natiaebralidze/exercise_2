// See https://aka.ms/new-console-template for more information
// სავარჯიშო 9
//დაწერეთ პროგრამა რომელიც მოცემულ მასივს დაბეჭდავს შებრუნებული სახით მაგ 1 2 3 4 —-> 4 3 2 1

int[] array = new int[] {1, 2, 3, 4};

for(int i=array.Length-1; i>=0; i--)
{
    Console.Write(array[i]+" ");
}
