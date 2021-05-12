using System;
using System.IO;

namespace stack_queue
{
    class Program
    {
        static int[,] a;
        static int n, m;
        static void load()
        {
            TextReader load = new StreamReader(@"..\..\..\matrix.in");
            string buffer = load.ReadLine();
            n = int.Parse(buffer.Split(' ')[0]);
            m = int.Parse(buffer.Split(' ')[1]);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] local_s = load.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    a[i, j] = int.Parse(local_s[j]);
            }
        }

        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Lee()
        {
            Queue A = new Queue();
            a[0, 0] = 1;
            A.push(new nod(0, 0, 1));

            while(A.n!=0)
            {
                nod t = A.pop();
                if(t.l-1>=0)
                    if(a[t.l -1, t.c]==0)
                    {
                        a[t.l - 1, t.c] = t.v + 1;
                        A.push(new nod (t.l - 1, t.c, t.v + 1));
                    }
                if (t.c + 1 <m)
                    if (a[t.l, t.c+1] == 0)
                    {
                        a[t.l, t.c+1] = t.v + 1;
                        A.push(new nod(t.l, t.c+1, t.v + 1));
                    }
                if (t.l + 1 < n)
                    if (a[t.l+1, t.c] == 0)
                    {
                        a[t.l+1, t.c] = t.v + 1;
                        A.push(new nod(t.l+1, t.c, t.v + 1));
                    }
                if (t.c - 1 >=0)
                    if (a[t.l, t.c - 1] == 0)
                    {
                        a[t.l, t.c - 1] = t.v + 1;
                        A.push(new nod(t.l, t.c - 1, t.v + 1));
                    }
            }
        }
        static void Main(string[] args)
        {
            /* Stack A = new Stack(); //=A.n=0;
             string s="2 3 + 5 1 + 2 * - 1 3 - + 2 2 * 1 + +";
             string[] local_s = s.Split(' ');
             foreach(string str in local_s)
             {
                 if(str[0]>='0' && str[0] <= '9')
                 {
                     A.push(float.Parse(str));
                 }
                 else
                 {
                     float t1 = A.pop();
                     float t2 = A.pop();
                     switch(str[0])
                     {
                         case '+':
                             A.push(t2 + t1);
                             break;
                         case '-':
                             A.push(t2 - t1);
                             break;
                         case '*':
                             A.push(t2 * t1);
                             break;
                         case ':':
                             A.push(t2 / t1);
                             break;

                     }
                 }
             }
            A.view();
             */
            load();
            view();
            Console.WriteLine();
            Lee();
            view();

            Console.ReadKey();
        }
    }
}
