using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];// stores 5 eleements of typ integer 
            // by default all element are initialie with value 0
            
            Console.WriteLine(a[0]);
           // Console.WriteLine(a[5]);// index Out of range exception 
            string[] b;
            b = new string[] { "bb", "dd", "cc", "aa" };// auto matically compiler detects size of an array 
            Console.WriteLine(b[0] +"  " +b[3]);
          /*  for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            foreach (string iterator in b)
            {
                Console.WriteLine(iterator);
            }
           * */
            Console.WriteLine("occurredd "+Array.IndexOf(b,"cc3"));//return int  if found then index if not then -1
            Console.WriteLine("occurredd  i binary search " + Array.BinarySearch(b, "cc"));
            //Array.Clear(b, 0, b.Length); //clears the values only sets Empty in case of string ,or 0 incase of int , Return Type is void ,  Parameters =(array, startIndex , size(how many elements you want to clears ) )
            //Array.Clear(b, 0, b.Length + 11); ///Index Out Of bound 
            /* foreach (string iterator in b)
            {
                Console.WriteLine(iterator==null?"null":iterator);
            }
            */
           // resizeing aray;
            Console.WriteLine("LEngth of  B : is : " + b.Length + "  ok  " + b[2]);
            Array.Resize(ref b, 1);  // Resize methods requires ref paramter values  // resizes array to specified length 
            // if the resize length is greater than currrent length then it initialize  array with default values , 
            // if current is greater than specified value then it removes the last elements and  keeps first 
            Console.WriteLine("LEngth of  B : is : " + b.Length +"  ok  "+b[0]); //b[2] -->> Ex -index out of bound 
          /*
            Array.Sort(b); ///sorts AScending 
            foreach (string iterator in b)
            {
                Console.WriteLine(iterator == null ? "null" : iterator);
            }
            Array.Reverse(b); //reverses 
            foreach (string iterator in b)
            {
                Console.WriteLine(iterator == null ? "null" : iterator);
            }
            */
            int[,] arr = new int[3, 2]{{1,2},{2,2},{3,2}} ; // 2D arrays  : where size of all rows is fixed  
           for(int i=0;i<3;i++)
           {
               for(int j=0;j<2;j++) //O(m*k) Space:-> O(m*k)
               {
                  Console.Write("X :"+arr[i,j]);
               }
               Console.WriteLine();
           }
       

            // jagged arrays :---> wher size of rows can be differenr also
            int[][] arr1 = new int[3][];
            arr1[0] = new int[2] { 1, 2 };
            arr1[1] = new int[4] {11, 22,33,44 };
            arr1[2] = new int[1] { 111 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++) //O(n) where n is total elements in jagged array 
                {
                    Console.Write(arr1[i][j]+"  ");
                }
                Console.WriteLine();
            }


           Class1[] arrobj = new Class1[3]{new Class1(),new Class1(),new Class1()};
            
            foreach (Class1 iterator in arrobj)
            {
                Console.WriteLine(iterator.ToString());// accessing some methods for each object  //ToString() return the  NamespaceName .classNAme ex:->ClassLibrary1.Class1
                
            }
    
          //  int[] source = new int[3]{1,2,3};
          //  int[] dest=new int [3];
          ////  source.CopyTo(dest,0); // coping on array into another array s
          // // dest = source.Clone();// cannotconvert implicitly object to int 
          //  Object dest2 = source.Clone();
          //  // and then we need to typecast it into Class object only not wokr in primitives 
          //  dest = (int)dest2;
          //  foreach (var  iterator in dest3)
          //  {

          //  }
            Console.ReadKey();
        }
    }
}
