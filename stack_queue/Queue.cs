using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    public class nod
    {
        public int l, c, v;
        public nod(int l, int c, int v)
        {
            this.l = l;
            this.c = c;
            this.v = v;
        }
        public void view()
        {
            Console.Write("(" + l + " " + c + " " + v + ")");
        }
    }
    public class Queue  //coada
    {
        nod[] v;
        public int n;

        public Queue()
        {
            n = 0;
        }

        public void push(nod value) //adaugare
        {
            n++;
            nod[] t = new nod[n];
            for(int i=0; i<n-1; i++) //se decaleaza elementele cu o poz pt a elibera prima poz
            {
                t[i + 1] = v[i]; //mutam elementele pe o pozitie +1 la dreapta
            }
            t[0] = value; //se introduce valoarea pe prima pozitie
            v = t;
        }

        public nod pop() //stergere
        {
            nod tor = v[n - 1]; //eliminam ultimul element
            n--;
            nod[] t = new nod[n];
            for (int i = 0; i < n; i++) //copiem v-u in t, mai putin ultima val dat n-- de mai sus
                t[i] = v[i];
            v = t;
            return tor; //returnam elementul sters (pentru a stii pe care l-am sters)
        }

        public void view()
        {
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }

        public void viewLine()
        {
            view();
            Console.WriteLine();
        }
    }
}
