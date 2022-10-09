// See https://aka.ms/new-console-template for more information

//string y = Console.ReadLine();

//bool x = int.TryParse(y, out int xInt);
//Console.WriteLine(xInt);

//int.TryParse(Console.ReadLine(), out int xIny);
//Console.WriteLine(xIny);

//სავარჯიშო 1
//int[] array = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    bool element = int.TryParse(Console.ReadLine(), out int elementInt);
//    array[i] = elementInt;
//}
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}

//int.TryParse(Console.ReadLine(), out int numCount);
//int currentLine = 0;

//for (int i = 1; i <= numCount; i++)
//{
//    currentLine++;
//    for (int j = 1; j < currentLine; j++)
//    {
//        Console.Write(currentLine + j);
//        Console.Write("  ");
//    }
//    Console.WriteLine();
//}

//int.TryParse(Console.ReadLine(), out int numCount);
//int[] arr = new int[numCount];
//for (int i = 0; i < numCount; i++)
//{
//    arr[i] = i;
//}

//int lines = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    lines++;
//    for (int j = 0; j < lines; j++)
//    {
//        Console.Write(arr[lines + j] + " ");
//    }
//    Console.WriteLine();
//}

// სავარჯიშო 3
//int.TryParse(Console.ReadLine(), out int numOddNumbers);
//int sum = 0;
//int multiple = 1;

//for (int i=1; i<=numOddNumbers; i++) 
//{
//    if (i %2 != 0)
//    {
//        sum = sum + i;
//        multiple = multiple * i;
//    }
//}
//Console.WriteLine(sum);
//Console.WriteLine(multiple);

//სავარჯიშო 4
//int.TryParse(Console.ReadLine(), out int nums);
//int sumofSquares = 0;
//int j;

//for (int i = 1; i <= nums; i++)
//{
//    j = i * i;
//    sumofSquares=sumofSquares + j;
//}
//Console.WriteLine(sumofSquares);

// სავარჯიშო 5
//string s = Console.ReadLine();
//bool isStringPalindrome = true;

//for (int i = 0; i <= s.Length / 2; i++)
//{
//    if (s[i] != s[s.Length - 1 - i])
//    {
//        Console.WriteLine("not palindrome");
//        isStringPalindrome = false;
//        break;
//    }
//}
//if (isStringPalindrome)
//{
//    Console.WriteLine("palindrome");
//}


//continue gamotovebs for-shi im iteraciistvis if-s, break-i gaacherebs fors
//for (int i = 1; i <= 10; i++)
//{
//    if(i % 2 != 0)
//    {
//        Console.WriteLine(i);

//      }
//else
//{
//    continue;
//}
//Console.WriteLine(i);

// savarjisho 6 კითხე ლექტორს

//int x = 1994;
//int division = 1000;
//double[] array = new double[4];

//for (int i=0; i<x.ToString().Length; i++)
//{
//    double j = x /division;
//    j = Math.Truncate(j);
//    array[i] = j;
//    x=x% division;
//    Console.WriteLine(x + "x");
//    division = division /10;
//    Console.WriteLine(division+"d");
//}

//for(int k=0; k < array.Length; k++)
//{
//    Console.WriteLine(array[k]);
//}

//სავარჯიშო 7 ეს რას ნიშნავს ელემენტის რაოდენობა??
//int[] array = new int[] {1,5,7,8} ;
//int sum = 0;

//for (int i=0; i < array.Length; i++)
//{
//    sum = sum + array[i];
//}
//Console.WriteLine(sum);

//სავარჯიშო 8
//using System;
//using System.Diagnostics.CodeAnalysis;

//int[] array = new int[] { 7, 5, 9, 1, 23, 5, 6, 8, 5 };
//int max=0;
//max = array[0];
//int min = array[0];

//int x = array.Length;
//if (x%2==0)
//{
//    int k = array.Length/ 2;
//    int middle = (array[k - 1] + array[k]) / 2;
//    Console.WriteLine(middle + "middle");
//}
//else
//{
//    int middle = array[array.Length/2];
//    Console.WriteLine(middle + "middle");
//}

//for (int i = 1; i < array.Length; i++)
//{
//    if (max < array[i])
//    {
//        max = array[i];
//    }

//    if (min > array[i])
//    {
//        min = array[i];
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);

//savarjisho 9
//int[] array = new int[] { 7, 5, 9, 1, 23, 5, 6, 8, 5 };
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}

//Console.WriteLine("shebrunebuli");

//for (int i = array.Length-1; i >= 0; i--)
//{
//    Console.WriteLine(array[i]);
//}

//savarjisho 10
//int[] array = new int[] { 7, 5, -9, 1, -23, -5, 6, 8, 5 };
//int count = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] < 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//savarjisho 11
int[] array = new int[] { 7, 5, 1, 9, 7, 1, -23, 5, 5, 8, 5 };
int temp;

//დალაგება არაის, დალაგებულილ ზრდადობის მიხედვით შემინახა
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[i] < array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

//Console.WriteLine(array[0]);
//int unicNum = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//   if(unicNum != array[i])
//    {
//        Console.WriteLine(array[i]);
//        unicNum = array[i];
//    } 
//}

//savarjisho 12
//-23,1,1,5,5,5,5,7,7,8,9

//for (int i = 0; i < array.Length; i++)
//{
//    bool isRepetable = false;
//    for (int j = 0; j < array.Length; j++)
//    {
//        if (i == j)
//        {
//            continue;
//        }
//        if (array[i] == array[j])
//        {
//            isRepetable = true;
//        }
//    }

//    if (!isRepetable)
//    {
//        Console.WriteLine(array[i]);
//    }
//}

