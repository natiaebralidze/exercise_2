// See https://aka.ms/new-console-template for more information
//სავარჯიშო 11
//დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში უნიკალურ ელემენტებს
//( მაგ 1 1 1 2 2 3  4—> 1 2 3 4) მასივის შევსება როგორც გინდა მოახდინეთ.

int[] array = new int[] {1,1,1,2,2,3};
bool unicNum = true;

for (int i = 0; i < array.Length; i++)
{
    unicNum = true;
    for (int j = 0; j < i; j++)
    {
        if (array[i] == array[j])
        {
            unicNum = false;
        }
    } 
    if (unicNum) {
        Console.Write(array[i]);
    }
}