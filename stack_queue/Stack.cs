using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    public class Stack  //stiva
    {
        float[] v;
        public int n;

        public Stack()
        {
            n = 0;
        }

        public void push(float value) //adaugare
        {
            n++;
            float[] t = new float[n];
            for (int i = 0; i < n - 1; i++) //se decaleaza elementele cu o poz pt a elibera prima poz
            {
                t[i + 1] = v[i]; //mutam elementele pe o pozitie +1 la dreapta
            }
            t[0] = value; //se introduce valoarea pe prima pozitie
            v = t;
        }

        public float pop() //eliminare
        {
            float tor = v[0]; //se elimina valoarea de pe prima pozitie si o afisam
            n--;
            float[] t = new float[n];
            for (int i = 0; i < n; i++) //mutam elementele cu o pozitie +1 spre stanga
                t[i] = v[i + 1];
            v = t;
            return tor;

        }

        public void view()
        {
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        public void viewLine()
        {
            view();
            Console.WriteLine();
        }
    }
}
