using System;
using System.Collections;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Xml.Schema;

public class DSA
{

    static void BubbleSort(int[] arrayBack)
    {
        for (int i = 0; i < arrayBack.Length -1 ; i++)
        {
            for (int j = i+1 ; j < arrayBack.Length ; j++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", arrayBack) );
                Console.WriteLine($"{arrayBack[j]} - {arrayBack[j + 1]}");
                if (arrayBack[j] > arrayBack[j + 1])
                {
                
                    int temp;
                    temp = arrayBack[j];
                    arrayBack[j] = arrayBack[j + 1];
                    arrayBack[j + 1] = temp;

                    

                }

                
            }
        }
    }

    static void SelectionASCSort(int[] array) {
        //ASC ORDER
        int j;
        for (int i = 0; i < array.Length-1 ; i++)
        {
            int BigValueIndex = i;
            for (j = i + 1; j < array.Length; j++)
            {
                Console.WriteLine($"{array[BigValueIndex]} {array[j]}");

                if (array[BigValueIndex] > array[j])
                {
                    Console.WriteLine($"{array[BigValueIndex]} {array[j]} in if block");
                    BigValueIndex = j;
                }
            }
            int temp;
            temp = array[BigValueIndex];
            array[BigValueIndex] = array[i];
            array[i] = temp;




        }


    }


    static void SelectionDESCSort(int[] array)
    {
        //ASC ORDER
        for (int i = array.Length-1 ; i > 1; i--)
        {
            int BigValueIndex = i;
            for (int j = i - 1; j >= 0; j--)
            {
                Console.WriteLine($"{array[BigValueIndex]} {array[j]}");

                if (array[BigValueIndex] > array[j])
                {
                    Console.WriteLine($"{array[BigValueIndex]} {array[j]} in if block");
                    BigValueIndex = j;
                }
            }
            int temp;
            temp = array[i];
            array[i] = array[BigValueIndex];
            array[BigValueIndex] = temp;




        }


    }

    public static int[] InsertionSort(int[] arr )
    {
        Int64 j,temp;

        //8,1,2, 6, 4, 0
        for (int i = 1; i < arr.Length; i++)
        {
            temp = arr[i];
            
            Console.Write($" temp {temp}");
            Console.WriteLine($" i - {arr[i]} j - {arr[i-1]} j+1 - {arr[i+1]}");
            for (j = i - 1;  j >= 0; j--)
            {
                if (arr[j] > temp)
                {   
                    arr[j+1] = arr[j];
                }
                else
                {
                    break;
                }
            } 
              

            arr[j+1] = (int)temp;
        }

        return arr;


    }

    #region Pattern
    public static void FizzBuzz(int n)
    {
        // Hackkerank SampleTest 

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0 && i % 5 != 0)
                Console.WriteLine("Fizz");
            else if (i % 3 != 0 && i % 5 == 0)
                Console.WriteLine("Buzz");
            else
               Console.WriteLine(i);
            
        }
    }


    public static int[] LC2sum(int[] array,int target)
    {
        List<int> temp = new List<int>();
        //[2,7,11,15]
        //Leetcode 2 Sum
        for (int i = 0; i < array.Length; i++)
        {

            for (int j =  i + 1; j < array.Length; j++)
            {
               int Sum =array[i]+array[j];
                //Console.WriteLine($"{array[i] } { array[j]}");
                //Console.WriteLine(Sum);
                if (Sum == target)
                {
                    //Console.WriteLine(Sum);
                    temp.Add(j);
                    temp.Add(i);
                     return temp.ToArray();
                }


            }
        }

        return temp.ToArray();


    }

    public static void pattern()
    { //CODE FOR BLOCK STAR PATTERNS & NOs

        /*  ****     12345 
            ****     678910
            ****     11121314
            ****      ....    */
        
        int n = 5;
        int pr = 1;
        
        for (int i = 1; i < n; i++)
        {
           
            for (int j = 0; j < n; j++)
            {
                
                Console.Write(pr);
                pr++;
            }
            Console.WriteLine();
        }
    }


    public static void pattern2()
    {

        Console.WriteLine("Enter Rows");
        Int64 n= Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS "+ n);

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }



    }


    public static void pattern3()
    {

        Console.WriteLine("Enter Rows");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);
        int a = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(a);
                a++;
            }
            Console.WriteLine();
        }



    }



    public static void pattern4()
    {

        Console.WriteLine("Enter Rows");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);
       // Int64 a = n;

        for (Int64 i = n; i >= 1; i--)
        {
            Int64 a=n;

            for (Int64 j = n; j >= 1; j--)
            {
                Console.Write(a);
                a--;
            }
            Console.WriteLine();
        }



    }

    //assignments/09-patterns.md
    //KUNAL K..
    public static void pattern5()
    {
        Console.WriteLine("Enter No");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);

        //pattern2



        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j  <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }





    }


    public static void pattern6()
    {
        Console.WriteLine("Enter No");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);

        //pattern3



        for (int i = 1; i <= n; i++)
        {
            for (Int64 j = n; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }





    }

    public static void pattern7()
    {
        Console.WriteLine("Enter No");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);

        //pattern5


        //Method By Omkar
        //for (int i = 1; i <= n; i++)
        //{
        //    if (i>= n/2)
        //    {
        //        for (Int64 j = n; j >= i; j--)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();

        //    }
        //    else 
        //    {

        //        for (Int64 j = 1; j <= i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        //Mthod BY Kunal Khus.

        for (Int64 row= 0; row < 2*n; row++)
        {
            //pattern6
            Int64 ToatalSpace =row > n ? 2*n-row:row;
            for (Int64 j = 0; j <= row; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();

        }





    }



    public static void pattern8()
    {
        Int64 n=ReturnstherowNo();
        Int64 TotalSpaces;

        //pattern6
        for (int row = 0; row < n; row++)
        {
            TotalSpaces = n - row;

            for (int spaces = 0; spaces < TotalSpaces; spaces++)
            {
                Console.Write(" ");
            }

            for (int col = 0; col <= row; col++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();


        }


    }


    public static Int64 ReturnstherowNo()
    {

        Int64 TotalSpaces;
        Console.WriteLine("Enter No");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("N IS " + n);
        return n;
    }

    public static void pattern9()
    {
        Int64 n=ReturnstherowNo();
        Int64 TotalSpaces;
        //pattern8 pyramid-


        for (int row = 0; row < n; row++)
        {
            TotalSpaces=n- row;

            for (int col = 0; col <= n; col++)
            {
                if (col%2==0)
                {
                    Console.Write("*");
                }
                else { 
                    
                    Console.Write(" "); 
                }    
            }
            Console.WriteLine();    


        }



    }
    #endregion


    public static int Reverse(int x)
    { 
        int no, ans=0;
        for (; x != 0; )
        {
            no = x % 10;
            ans= (ans * 10) + no;
            x= x / 10;
            
        }
        return ans;
    }


    public static void dectobin(int x)
    { 
        int ans = 0,val=0,comps=0,dec=1,add=0;
        
       while (x != 0){
            ans=x % 2;
            val=(val * 10) + ans;
            x=x/2;
            if (val == 1)
            {
                ans = 0;
                comps = (comps * 10) + ans;
            }
            else
            {
                ans = 1;
                comps = (comps * 10) + ans;
            }


       }
        //val = 0;
        //while (comps!=0)
        //{           
        //    ans = comps % 10;
        //    if (ans == 1)
        //    {
        //        add = (Int32)(add + Math.Pow(2,dec));
        //        dec++;

        //    }
        //    comps = comps / 10;
        //}

        //Console.WriteLine(val);
       
    }
    
    public static void power2(int n)
    {
        int max = 31;
        for (int i = 1; i < max; i++)
        {

            if (Math.Pow(2,i) == n)
            {
                Console.WriteLine("true");
                break;
            }

        }
    }


    public static bool SameafterReversal(int n)
    {
        int res=0,prevno=n;
        for (int i = 0; i < 2; i++)
        {
            n = reverseno(n);
           

        }
        //n =res;

        if (prevno == n)
        {
            return true;
        }
        else 
            return false;


        

    }

    static int  reverseno(int n)
    {
        int a,b=0;
        while (n != 0)
        {
            a = n % 10;
            b = b * 10 + a;
            n = n / 10;

        }

        return b;

    }


    static void Arrys()
    {

        int size=0;
        //Wrking With Arrys
        Console.WriteLine("Enter Size of an array");
        size = Convert.ToInt32(Console.ReadLine());

        int[] arr= new int[size];
        Console.WriteLine("Enter Elements in Array");

        for (int i = 0; i < size; i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Elements in Array");
        for (int i = 0; i < arr.Length; i++)
        {

            Console.WriteLine(arr[i]);

           
        }

        Console.WriteLine("Min Element in Array");
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Minnimum Value is " + min);

        Console.WriteLine("max Element in Array");
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Maximum Value is " + max);


        Console.WriteLine("Adding all elements of an array ");

        int sum=0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum= sum + arr[i];
        }
        Console.WriteLine("Sum of elements is " + sum);

        Console.WriteLine("Implementing Linear Search");

        if (LinearSearch(arr, 2))
            Console.WriteLine("found");
        else
            Console.WriteLine("not found");

        Console.WriteLine("Reversing AN Array");


        ReverseArray(arr);

    }

    static bool LinearSearch(int[] arr,int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (key == arr[i])
            {
                return true;
            }
        }
        return false;
    }

    static void ReverseArray(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length /2; i++)
        {


                temp = arr[arr.Length - i-1];
                arr[arr.Length - i-1] = arr[i];
                arr[i] = temp;


        }


        foreach (var item in arr)
        {
            Console.Write(item);
        }
    }



    static void SwapAlter(int[] arr)
    {
        //Swap Alternate elements of an array
        Console.WriteLine("Before Swapping");

        foreach (var item in arr)
        {
            Console.Write(item);
        }

        int temp,val=1;
        for (int i = 0; i < arr.Length; i+=2)
        {
            if (arr.Length - 1 == i)
                val = 0;
            //i++;
            temp = arr[i + val];
            arr[i + val] = arr[i];
            arr[i] = temp;
            //i--;

        }

        Console.WriteLine("After Swapping");
                                                                                                                                                                                                     
        foreach (var item in arr)
        {
            Console.Write(item);
        }

    }

    static bool UniqueElementofArray(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    break;
                }
               
            }
        }

        return false;

    }

    static bool Occurence(int[] arr)
    {
       Dictionary<int,int> hash= new Dictionary<int, int>();
       Int64 countOfOccurence = 1;
       bool Uniqueocc = true;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if ((!hash.ContainsKey(arr[i])) /*&& arr[i] == arr[j]*/)
                {
                    if (arr[i] == arr[j])
                    {
                        countOfOccurence++;

                    }
                }
                else
                    break;


            }
            if (!hash.ContainsKey(arr[i]))
            {
                hash.Add(arr[i], (int)countOfOccurence);
                countOfOccurence = 1;
            }
            

        }
        countOfOccurence=0;
        foreach (int key in hash.Values)
        {
             countOfOccurence = hash.Values.Count(v => v == key);

            if (countOfOccurence > 1) {
                Uniqueocc = false;
                break;
            }
        }
        return Uniqueocc;

    }

    static void ops(int[] arr)
    {
        int an = 0;

        for (int q = 0; q < arr.Length; q++)
        {
            an = an ^ arr[q];
            Console.WriteLine(an);
        }
    }

    
    static List<Int32> negate(int[]arr)
    {

       
            List<Int32> ans=new List<Int32>();
            for (int i = 0; i < arr.Length; i++)
            {
                int index = Math.Abs(arr[i]) - 1;
                if (arr[index] < 0)
                    ans.Add(Math.Abs(arr[i]));
                else
                    arr[index] *= -1;
            }
            return ans;
    }

    
    static int InserPos(int[] arr,int n)
    {
        int res;
        //Search Insert position 
        for (int i = 0; i < arr.Length; i++)
        {
            if (n== arr[i])
            {
                return i;
            }
            else if(i== arr.Length-1)
                return i+1;
            else
            {
                res=n - arr[i];
                Console.WriteLine($"{n} {arr[i]} {n - arr[i]}");

                if (res == 0 || res == 1)
                    return res = res == 0 ? i : i + 1;
                else if (i == 0 && res == -1)
                    return i;
                else if (res < 0 &&  i !=0 )
                {   
                     if (n - arr[i - 1] > 0)
                        return i; 
                }

                }
            }
        return 0;

    }


    #region Return Duplicates 
    //Return Duplicate In an array
    static List<int> Duplicate(int[] arr)
    {
        HashSet<int> myHashSet = new HashSet<int>();
        List<int> resList = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (myHashSet.Contains(arr[i]))
                resList.Add(arr[i]);
            else
                myHashSet.Add(arr[i]);
        }


        return resList;

    }

    static List<int> DuplicatebyNeag(int[] arr)
    {
        List<int> res = new List<int>();
        int index;
        for (int i = 0; i < arr.Length; i++)
        {
            index= Math.Abs(arr[i])-1;

            if (arr[index] > 0)
                arr[index] *= -1;
            else
                res.Add(Math.Abs(arr[i]));
            
        }
        return res;


    }
    #endregion

    #region IntersectionOfanarray
    static List<int> Intersect(int[] arr,int[] arr2) 
    {
        List<int> res = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr2.Length  ; j++)
            {
                if (arr[i] == arr2[j])
                {
                    res.Add((int)arr[i]);
                    arr2[j] *= -1;
                    break;
                }



            }
        }

        return res;
        

    }
    #endregion

    #region Sort01
    static void Sort01(int[] arr)
    {
        int j=arr.Length/2,k=arr.Length,swap;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                i++;
            
            if (arr[i] > arr[j])
            {
                swap= arr[i];
                arr[i] = arr[j];
                arr[j] = swap;
                j--;

            }
            if (arr[i] < arr[j] && arr[j]==1)
                j -= 1;

            if (arr[i] < arr[j]  && arr[j] < arr[k] && arr[k] == 2)
                k -= 1;



        }
    }
    #endregion


    #region sort012(1)
    static void Sort012(int[] arr)
    {
        int j=0,swap;

        for (int i = 0; i < arr.Length; i++)
        {
            
             j = i + 1;
          
            //}
            if (arr[i] == 0)
                i++;

            if (arr[i] == arr[j] /*&& j <arr.Length*/)
            {
                j++;
            }
            if (j == arr.Length)
            {
                break;
            }
            if (arr[i] > arr[j])
            {
                swap = arr[i];
                arr[i] = arr[j];
                arr[j] = swap;
                j++;

            }
            //if (arr[i] < arr[j] && arr[j] == 1)
            //    j += 1;

            



        }
    }
    #endregion

    #region SORT012(2BEST EYE OF THE TIGER)
    public static void Sort120ETT(int[] arr) 
    {
       int j,k=arr.Length-1,swap;

        for (int i = 0; i < arr.Length/2; i++)
        {
            j = i + 1;
            if (arr[k] == 2)
                k--;
            if (k == i)
                k = 0;
            if (arr[i] > arr[j])
            {
                swap = arr[i];
                arr[i] = arr[j];
                arr[j] = swap;
            }

            if (arr[i] > arr[k] /*&& i < k*/)
            {
                swap = arr[i];
                arr[i] = arr[k];
                arr[k] = swap;
            }
            if (arr[k] == 2)
                k--;
            if (arr[j] > arr[k] && j < k)
            {
                swap = arr[j];
                arr[j] = arr[k];
                arr[k] = swap;
            }
            if (arr[k] == 2)
                k--;


        }
    }
    #endregion

    #region
    public static int BinarySearch(int[] arr,int key)
    {
        int start=0,end=arr.Length-1,mid;
        mid=start+(end-start)/2;

        for (; start <=end; )
        {
            if (arr[mid]==key)
            {
                return mid;
            }

            if (key > arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                end= mid - 1;
            }

            mid = start + (end - start) / 2;

        }
        return -1;

    }
    #endregion

    #region NumberofOccurence

#end

    public static void Main(string[] args)
    {
       int[] vals = { 1,3,5,7,8,11};
        //int[] vals1 = { 2, 2, 1, 1 ,2 ,0 ,2 ,0 ,2 ,1 };
        //        10
        //10
        //2 2 2 2 2 2 2 2 2 2
        //10
        //1 1 1 1 1 1 1 1 1 1
        //10
        //0 0 0 0 0 0 0 0 0 0
        //10
        //1 0 1 0 1 0 1 0 1 0
        //10
        //1 2 2 1 1 2 2 1 1 2
        //10
        //0 1 2 0 1 2 0 1 2 0
        //10
        //0 2 1 0 2 1 0 2 1 2
        //10
        //2 2 2 2 2 0 0 0 0 0
        //10
        //2 2 1 1 2 0 2 0 2 1
        //10
        //0 0 0 0 0 1 1 1 2 2
        //negate(vals);
        //ops(vals);
        //var Hashvals=Occurence(vals);
        //
        //var Index= DuplicatebyNeag(vals);
        // var Index = Intersect(vals1, vals);
        //Sort120ETT(vals1);
        int Index=BinarySearch(vals, 1);
        Console.WriteLine(Index);

        //Console.WriteLine(Index);


    }

}





