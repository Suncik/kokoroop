using System;

class Program   
{
    static void Main(string[] args)
    {
        //1. Doira yuzi va aylana uzunligini hisoblash
        // double L, S;
       
        // Console.Write("R=");
        // double R = Convert.ToDouble(Console.ReadLine());  
        // L = 2 * Math.PI * R;
        // S = Math.PI * Math.Pow(R, 2);  
        // Console.WriteLine($"L={L}");
        // Console.WriteLine($"S={S}");
       
          
    //2. Valyuta konvertri  
        // Console.Write("qiymat=");
        //       float qiymat=Convert.ToSingle(Console.ReadLine());
        //       Console.Write("Kurs=");
        //        int kurs=Convert.ToInt32(Console.ReadLine());
        //        float x=qiymat*kurs;
        //        Console.WriteLine($"{x}sum");
        Console.Write("x=");
        int x=Convert.ToInt32(Console.ReadLine());
        int y=(2023-x)*365;
        Console.WriteLine(y);

    }
}
