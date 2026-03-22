using System;
class Program
{
    static void Main(string[] args)
    {
        int[] Numeros= {3,4,2,8,7};
        Console.WriteLine(ExisteSuma(Numeros,6));
        Console.WriteLine(ExisteSuma(Numeros,26));
        Console.WriteLine(ExisteSuma(new int[]{4}, 4));
    }
    static bool ExisteSuma(int[] Numeros, int Objetivo)
    {
        return ExisteSumaRec(Numeros, Objetivo ,0);
    }
    static bool ExisteSumaRec(int[] Numeros, int Objetivo, int Index)
    {
        if (Objetivo == 0)
            return true;
        if (Index >= Numeros.Length|| Objetivo <0 )
            return false;
        if (ExisteSumaRec(Numeros, Objetivo - Numeros[Index],Index + 1))
            return true;
        return ExisteSumaRec(Numeros, Objetivo,Index + 1);
    }
}