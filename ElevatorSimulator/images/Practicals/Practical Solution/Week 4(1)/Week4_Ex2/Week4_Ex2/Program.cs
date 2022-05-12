using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Ex2
{
    public class BookListHashing
    {

        public int size_of_table;     //size of the table
        public int[] flag ;           //flag indicating that a row is ocupied or not
        public string[] bl;        //rows for saving the new records;

        BookListHashing(int n)
        {
            size_of_table = n;
            flag = new int[size_of_table];
            bl = new string[size_of_table];
            for (int i=0;i< size_of_table; i++)
            {
                flag[i] = 0;           //initialising the flag, none of the rows are ocupied at the begining
                bl[i] = " ";
            }
        }

        public int hashing(int n)
        {
            int position;
            position = n % size_of_table;
            return position;
        }

        int Greatest_Common_Factor(int a, int b)                        //Find the greatest common factor of two number. 
        {
            return b == 0 ? a : Greatest_Common_Factor(b, a % b);
        }

        public int probe(int n)
        {
            int position;
            position = Math.Max(1, n % size_of_table);

            while (Greatest_Common_Factor(position, size_of_table) > 1)      //If the greatest common factor is not 1, reduce the probe by 1 and check again
            {
                position--;
            }
            return position;
        }

        public int wrap(int h, int p)
        {
            int d;
            d = h - p;
            if (d < 0)
            {
                d = size_of_table + (h - p);
            }
            if (flag[d] == 1)
            {
                d = d - p;
                d = wrap(d, p);
            }
            return d;
        }


        public static void Main(string[] args)
        {
            int pos;
            int h;
            int p;

            
            int[] index = new int[7] { 1, 9, 18, 19, 5, 15, 25};
            string[] Title = new string[7] {"A1", "I9", "R18", "S19", "E5", "O15", "Y25"};

            
            
            //create the BookListHashing object with 10 rows
            BookListHashing blh = new BookListHashing(10);


            //Arrange the position of the records using hashing
            for (int i = 0; i < 7; i++)
            {
                h = blh.hashing(index[i]);
                if (blh.flag[h] == 1)                   //ocupied already, then search for next place
                {
                    p = blh.probe(index[i]);            //step size from probe
                    pos = blh.wrap(h, p);
                }
                else
                {
                    pos = h;
                }
                blh.flag[pos] = 1;
                blh.bl[pos] = Title[i];
   
                Console.WriteLine("position in table = " + pos + ", " + blh.bl[pos] );
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
