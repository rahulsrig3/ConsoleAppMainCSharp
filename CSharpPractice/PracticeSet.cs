using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpPractice
{
    class PracticeSet
    {
        public static void Main(String[] args)
        {
            //List<string> list = new List<string>();
            //LinkedList<string> listLinkedList = new LinkedList<string>();
            //HashSet<string> set = new HashSet<string>();
            //***********************************************************************************
            //ArrayList arrList = new ArrayList();
            //Hashtable hashtable = new Hashtable();
            //***********************************************************************************

            //ArrayList arrList = new ArrayList();
            //Console.WriteLine(arrList.Capacity); //0
            //arrList.Add(1);
            //Console.WriteLine(arrList.Capacity); //4
            //arrList.Add("rahul");
            //Console.WriteLine(arrList.Capacity); //4
            //arrList.Add(34.353);
            //Console.WriteLine(arrList.Capacity); //4
            //arrList.Add(null);
            //Console.WriteLine(arrList.Capacity); //4
            //arrList.Add('h');
            //Console.WriteLine(arrList.Capacity); //8
            //arrList.Add(252542425245);
            //Console.WriteLine(arrList.Capacity); //8
            //arrList.Add(true);
            //Console.WriteLine(arrList.Capacity); //8
            //arrList.Remove(null);
            //Console.WriteLine(arrList.Capacity); //8
            //arrList.RemoveAt(4);
            //Console.WriteLine(arrList.Capacity); //8
            //arrList.RemoveRange(1, 4);  //removes objects from the arraylist from index 1 to 4
            //Console.WriteLine(arrList.Capacity); //8
            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]); //1
            //}
            //**********************************************************************************

            //Hashtable hTable = new Hashtable();
            //hTable.Add("hello", "hi");
            //hTable.Add(1, 435);
            //hTable.Add(2, true);
            //hTable.Add(3, false);
            //hTable.Add(true, 352.2352353);
            //hTable.Add('d', 424252);
            //foreach(Object key in hTable.Keys)
            //{
            //    Console.WriteLine(key + " : " + hTable[key]); //insertion order is not maintained
            //}
            //**********************************************************************************

            //arrayAscending();
            //KeyBasedDisplayArray();
            //maxLengthOfString();
            //segregationOfZeros();
            //convertString("HelloBrotherDarkside");
            //occurence();
            //removeDuplicate();
            //duplicateChar();
            //uniqueChar();
            //reverseStirng();
            //reverseWithThirdVar();
            //reverseWithoutLength();
            //reverseWord();
            //reverseWordMaintainPosition();
            //reverseWordReversePosition();
            //occuranceWord();
            //duplicateWord();
            //uniqueWord();
            //removeDuplicateWord();
            AddOfNumInString();

        }

        //public static void arrayAscending()
        //{
        //    int[] arr = { 50, 30, 20, 10, 40 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i+1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                int temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }               
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]+" ");
        //    }
        //    Console.WriteLine("minimum: "+arr[0]);
        //    Console.WriteLine("second minimum: "+arr[1]);
        //    Console.WriteLine("maximum: "+arr[arr.Length-1]);
        //    Console.WriteLine("second maximum: "+arr[arr.Length-2]);
        //}

        //public static void KeyBasedDisplayArray()
        //{
        //    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int key = 3;
        //    for (int i = key; i < num.Length; i++)
        //    {
        //        Console.Write(num[i]);
        //    }
        //    for (int i = 0; i < key; i++)
        //    {
        //        Console.Write(num[i]);
        //    }
        //}

        //public static void maxLengthOfString()
        //{
        //    String[] str = { "hello", "hi", "maximum", "minimum", "tyss" };
        //    String maxLength = str[0];
        //    for (int i = 1; i < str.Length; i++)
        //    {
        //        if (maxLength.Length<str[i].Length)
        //        {
        //            maxLength = str[i];
        //        }
        //    }
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i].Length == maxLength.Length)
        //        {
        //            Console.WriteLine(str[i]);
        //        }
        //    }            
        //}

        //public static void segregationOfZeros()
        //{
        //    int[] a = { 1, 2, 0, 0, 1, 0, 0, 2 };
        //    int[] b = new int[a.Length];
        //    int m = 0, n = a.Length-1;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i]==0)
        //        {
        //            b[n] = a[i];
        //            n--;
        //        }
        //        else
        //        {
        //            b[m] = a[i];
        //            m++;
        //        }
        //    }
        //    for (int i = 0; i < b.Length; i++)
        //    {
        //        Console.Write(b[i]+" ");
        //    }

        //}

        //public static void convertString(String words)
        //{

        //    char[] wordsArr = words.ToCharArray();
        //    char[] newStr = new char[wordsArr.Length + 5];
        //    int j = 0;
        //    for (int i = 0; i < wordsArr.Length; i++)
        //    {
        //        if (char.IsUpper(wordsArr[i]))
        //        {
        //            if (i == 0)
        //            {
        //                newStr[j] = char.ToLower(wordsArr[i]);
        //                j++;
        //                continue;
        //            }
        //            newStr[j] = '_';
        //            newStr[++j] = char.ToLower(wordsArr[i]);
        //            j++;
        //            continue;
        //        }
        //        newStr[j] = wordsArr[i];
        //        j++;
        //    }
        //    Console.Write(newStr);
        //}

        //public static void occurence()
        //{
        //    String str = "aditee";
        //    //char[] st = str.ToCharArray();
        //    HashSet<char> set = new HashSet<char>();
        //    foreach(char c in str)
        //    {
        //        set.Add(c);
        //    }
        //    foreach (char ch in set)
        //    {
        //        int count = 0;
        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            if(str[i] == ch)
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine(ch + " occurance is: "+count);
        //    }
        //}

        //public static void removeDuplicate()
        //{
        //    String str = "aditee";
        //    HashSet<char> set = new HashSet<char>();
        //    foreach (char c in str)
        //    {
        //        set.Add(c);
        //    }
        //    foreach (char c in set)
        //    {
        //        Console.WriteLine(c);
        //    }
        //}

        //public static void duplicateChar()
        //{
        //    String str = "aditee";
        //    HashSet<char> set = new HashSet<char>();
        //    foreach (char c in str)
        //    {
        //        set.Add(c);
        //    }
        //    foreach (char c in set)
        //    {
        //        int count = 0;
        //        for(int i = 0; i < str.Length; i++)
        //        {
        //            if(str[i] == c)
        //            {
        //                count++;
        //            }
        //        }
        //        if(count == 2)
        //        {
        //            Console.WriteLine(c+" occurence is: "+count);
        //        }
        //    }
        //}

        //public static void uniqueChar()
        //{
        //    String str = "aditee";
        //    HashSet<char> set = new HashSet<char>();
        //    foreach (char c in str)
        //    {
        //        set.Add(c);
        //    }
        //    foreach (char c in set)
        //    {
        //        int count = 0;
        //        for(int i = 0; i < str.Length; i++)
        //        {
        //            if(str[i] == c)
        //            {
        //                count++;
        //            }
        //        }
        //        if(count == 1)
        //        {
        //            Console.WriteLine(c+" occurance is: "+count);
        //        }
        //    }
        //}

        //public static void reverseStirng()
        //{
        //    String str = "aditee";
        //    for(int i = str.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(str[i]);
        //    }
        //}

        //public static void reverseWithThirdVar()
        //{
        //    String str = "aditee";
        //    string st = "";
        //    for(int i = str.Length - 1; i >= 0; i--)
        //    {
        //        st = st + str[i];
        //    }
        //    Console.WriteLine(st);
        //}

        //public static void reverseWithoutLength()
        //{
        //    String str = "aditee";
        //    char[] ch = str.ToCharArray();
        //    int count = 0;
        //    foreach(char c in ch)
        //    {
        //        count++;
        //    }
        //    for(int i = count-1; i >= 0; i--)
        //    {
        //        Console.Write(str[i]);
        //    }
        //}

        //public static void reverseWord()
        //{
        //    String str = "I am from Bangalore";
        //    String[] word = str.Split(" ");
        //    for (int i = word.Length-1; i >= 0; i--)
        //    {
        //        Console.Write(word[i]+" ");
        //    }
        //}

        //public static void reverseWordMaintainPosition()
        //{
        //    String str = "I am from Bangalore";
        //    String[] word = str.Split(" ");
        //    foreach(String s in word)
        //    {
        //        for(int i = s.Length-1; i >= 0; i--)
        //        {
        //            Console.Write(s[i]);
        //        }
        //        Console.Write(" ");
        //    }
        //}

        //public static void occuranceWord()
        //{
        //    String str = "I am from Pune now I am in Bangalore";
        //    str = str.ToLower();
        //    String[] word = str.Split(" ");
        //    HashSet<String> set = new HashSet<String>();
        //    foreach (String s in word)
        //    {
        //        set.Add(s);
        //    }
        //    foreach (String s in set)
        //    {
        //        int count = 0;
        //        for(int i = 0; i < word.Length; i++)
        //        {
        //            if(word[i] == s)
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine(s+" occurance is: "+count);
        //    }

        //}

        //public static void duplicateWord()
        //{
        //    String str = "I am from pune now i am in Bangalore";
        //    str = str.ToLower();
        //    String[] word = str.Split(" ");
        //    HashSet<String> set = new HashSet<String>();
        //    foreach(String s in word)
        //    {
        //        set.Add(s);
        //    }
        //    foreach(String s in set)
        //    {
        //        int count = 0;
        //        for(int i = 0; i < word.Length; i++)
        //        {
        //            if(word[i] == s)
        //            {
        //                count++;
        //            }
        //        }
        //        if(count == 2)
        //        {
        //            Console.WriteLine(s+" occurance is: "+count);
        //        }
        //    }
        //}

        //public static void uniqueWord()
        //{
        //    String str = "I am from pune but now i am in Bangalore";
        //    str = str.ToLower();
        //    String[] words = str.Split(" ");
        //    HashSet<String> set = new HashSet<String>();
        //    foreach(String s in words)
        //    {
        //        set.Add(s);
        //    }
        //    foreach(String s in set)
        //    {
        //        int count = 0;
        //        for(int i = 0; i < words.Length; i++)
        //        {
        //            if(words[i] == s)
        //            {
        //                count++;
        //            }
        //        }
        //        if(count == 1)
        //        {
        //            Console.WriteLine(s+" occurance is: "+count);
        //        }
        //    }
        //}

        //public static void removeDuplicateWord()
        //{
        //    String str = "I am from Pune but now i am in Bangalore";
        //    str = str.ToLower();
        //    String[] words = str.Split(" ");
        //    HashSet<String> set = new HashSet<String>();   
        //    foreach(String s in words)
        //    {
        //        set.Add(s);
        //    }
        //    foreach(String s in set)
        //    {
        //        Console.Write(s+" ");
        //    }
        //}

        public static void addOfNumInString()
        {
            String str = "1sd53@%^2f35";
        }

    }
}
