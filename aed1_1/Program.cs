// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

int f1(int[] v, int tam, int elem)
{
    int i = 0;
    // tam = n vezes
    while (i < tam)
    {
        // O(1)
        if (v[i] == elem)
        {
            return 1;
        }
        i++;
    }
    return 0;
}

Console.WriteLine(f1(new int[3] { 1, 2, 3 }, 3, 1));

int f2(int[] Va, int tamVa, int[] Vb, int tamVb, int elem)
{
    // Ordem tamVa + tamVb
    // O(1)
    for (int i = 0; i < Va.Length; i++)
    {
        if (elem == Va[i])
        {
            return 1;
        }
    }
    // // O(1)
    for (int i = 0; i < Vb.Length; i++)
    {
        if (elem == Vb[i])
        {
            return 1;
        }
    }
    return 0;
}

Console.WriteLine(f2(new int[] { 1, 2, 3 }, 3, new int[] { 4, 5, 6 }, 3, 7));


int f3(int[] Va, int tamVa, int[] Vb, int tamVb)
{
    // O(tamVa * tamVb)
    for (int i = 0; i < Va.Length; i++)
    {
        for (int j = 0; j < Vb.Length; j++)
        {
            if (Va[i] == Vb[j])
            {
                return 1;
            }
        }
    }
    return 0;
}

Console.WriteLine(f3(new int[] { 1, 2, 3 }, 3, new int[] { 3, 4, 5 }, 3));

int f4(int[] v, int tam)
{
    // O(tam^2)
    for (int i = 0; i < v.Length; i++)
    {
        for (int j = i+1; j < v.Length; j++)
        {
            if ((v[i] == v[j]))
            {
                return 1;
            }
        }
    }
    return 0;
}

Console.WriteLine(f4(new int[] { 1, 1, 2, 3, 4, 5 }, 6));

