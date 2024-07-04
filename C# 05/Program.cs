namespace C__05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.*/
            // passing by value => input parameter
            // passing by refernce => input output parameter
            //Ex passing by value
            int X = 10, Y = 20;
            Swap(X, Y);
            Console.WriteLine(X);
            Console.WriteLine(Y); // Main stackframe X =10 ,Y =20 ,Excute Swap frame X =20,Y=10 , Temp =10
                                  // Swap (10,20) there no way swapping still X =10 ,y= 20
                                  //Ex passing by reference
            Console.WriteLine("**********");
            int A = 40, B = 50;
            Swapbyref(ref A, ref B);
            Console.WriteLine(A);//Main stackframe A = 40 , B =50 ,Execute Swap by ref  A =50 ,Y =40 , temp = 40 
                                 // Swapbyref(ref A,refB) => Excution Swapping A = 50 ,B =40
            Console.WriteLine(B);
            #endregion
            #region Q2
            /*2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.*/
            // passing by value => Address of Array 
            //passing by reference => Array it self 
            //Ex01
            int[] Num01 = { 1, 2, 3, 4 };
            Console.WriteLine(SumArr(Num01)); // Arr copy from Num01--- Arr = Num01
            Console.WriteLine(Num01[0]); // Main stack frame Declare Num01 in stack refer {1,2,3,4} in heap
                                         // SumArr stack frame  Arr Declare in stack refer {1,2,3,4}in heap and Modify arr[0] =100
                                         // Then arr and Num01 refer in heap {100,2,3,4} and Delete stack frame  SumArr from  stack
            //Ex02 refernce type passing by ref
            Console.WriteLine("=====================");    // Arr and Num02 same Reference
            int[] Num02 = { 1, 2, 3, 5 };                  // Main stack frame Declare Num02 in stack refer {1,2,3,5} in Heap
            Console.WriteLine(SumArray( ref Num02));       //SumArray stack frame rename Num02 by Arr Delete  SumArray stack frame return Main rename Num02
            Console.WriteLine(Num02[0]);                   // passing by value and ref return same result , Appear difference when change object
            #endregion
            #region Q3
            /*3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers*/
            int sumR, SubR;
            Console.WriteLine("Enter your Number 1");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Number 2");
            int N2 = int.Parse(Console.ReadLine());
            SumSub(N1,N2,out sumR, out SubR);
            Console.WriteLine(sumR);
            Console.WriteLine(SubR);


            #endregion
            #region Q4
            /*4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
                    Output should be like 
                    Enter a number: 25                                                                                            
                    The sum of the digits of the number 25 is: 7
            */
            int V = 25;
            Console.WriteLine(SumDigit(V));

            #endregion
            #region Q5

            /*5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:*/
            IsPrime();
            #endregion
            #region Q6
            /*6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters*/
            int[] Elements = { 20, 100, 50, 300, 400, 500, 600, 800, 900, 750 };
            MaxMinArray(ref Elements);
            #endregion
            #region Q7
            /*7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter*/
            Console.WriteLine("Enter your Number Now :??");
            int K = int.Parse(Console.ReadLine());
            Factroial(K);
            #endregion
            #region Q8
            Console.WriteLine("Enter Your Text:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your position");
            int pov = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your char :");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ChangeChar(Name, pov, letter));

            #endregion
        }
        static void Swap(int X, int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        static void Swapbyref(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        static int SumArr(int[] Arr)
        {
            int Sum = 0;
            if (Arr is not null)
            {
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                    Sum += Arr[i];
            }
            return Sum;
        }
        static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            if (Arr is not null)
            {
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                    Sum += Arr[i];
            }
            return Sum;
        }
        static void SumSub(int X, int Y ,out int Sum,out int Sub)
        {
            Sum=X+Y; 
            Sub=X-Y;
        }
        static int SumDigit(int n)
        {
            string n1 = Convert.ToString(n);
            int Sum = 0;
            for (int i = 0; i < n1.Length; i++)
                Sum += Convert.ToInt32(n1.Substring(i, 1));
            return Sum;
        }

        static void IsPrime()
        {
            int Num;
            Console.WriteLine("Enter you Number :");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num ==0 || Num ==1)
            {
                Console.WriteLine(Num +" Number is not prime");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i < Num/2; i++)
                {
                    if (Num % i == 0)
                    {
                        Console.WriteLine($"{Num} : Number is not prime");
                        return;
                    }
                }
                Console.WriteLine($"{Num} : Number is  prime");
                Console.ReadLine();
            }
        }
        static void MaxMinArray(ref int[] Arr)
        {
            int Max = 0;
            int Min = 0;
            if(Arr != null)
            {
                for(int i = 0;i < Arr.Length; i++)
                {
                    Max = Arr.Max();
                    Min = Arr.Min();
                }
                Console.WriteLine($"Max element {Max}");
                Console.WriteLine($"Min element {Min}");
            }
        }
        static void Factroial(int num)
        {
            int factroial = 1;
            for (int i = 1; i <= num; i++)
            {
                factroial *= i;
            }
            Console.WriteLine($"Factroial of {num} is a : {factroial}");
            Console.ReadLine();
        } 
        static string ChangeChar(string text , int pov , char letter)
        {
            text = text.Remove(pov, 1);
            text = text.Insert(pov, letter.ToString());
            return text;
        }

    }

}
