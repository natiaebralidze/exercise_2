// See https://aka.ms/new-console-template for more information
//სავარჯიშო 5
//დაწერეთ პროგრამა რომელიც შეამოწმებს არის თუ არა სტრინგი პალინდრომი.
//(პალინდრომია სტრინგი თუ ის შებრუნებული სახითაც იგივენაირად იკითხება) asdffdsa

string s = Console.ReadLine();
bool isPalindrome = true;

for(int i = 0; i < s.Length; i++)
{
    if (s[i] == s[s.Length-i-1])
    {
        //isPalindrome = true;
        continue;   
    }
    else
    {
        isPalindrome=false;
        break;
    }

}

if (isPalindrome)
{
    Console.WriteLine("its a palindrome");
}
else
{
    Console.WriteLine("its not a palindrome");
}