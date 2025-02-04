using System;
class Program{
    static void Main(){
        //1-MASALA
    //     System.Console.WriteLine("daqiqani kiriting:");
    //     int minute=Convert.ToInt32(Console.ReadLine());
    //     if(minute%60!=0)
    //     System.Console.WriteLine($"{minute/60}:{minute%60}");
    //     else System.Console.WriteLine($"{minute/60}:00");

// 2-MASALA

//     System.Console.WriteLine("yoshni kiriting");
//     int age=Convert.ToInt32(Console.ReadLine());
//     if(age>=0 && age<=12){
//         System.Console.WriteLine("bola");
//     } else if(age>12 && age<=19){
//         System.Console.WriteLine("o'smir");
//     }  else if(age>19 && age<=59){
//         System.Console.WriteLine("kattalar");
//     }
// else System.Console.WriteLine("katta");  
//3-MASALA

        // System.Console.Write("o'rtacha ballni kiriting:");
        // int point=Convert.ToInt32(Console.ReadLine());
        // if(point>=80 && point<=100){
        //     System.Console.WriteLine("A'lo");

        // } else if(point>=60 && point<=79){
        //     System.Console.WriteLine("yaxshi");
        // }  else if(point>=40 && point<=59){
        //     System.Console.WriteLine("qoniqarli");
        // }  else System.Console.WriteLine("qoniqarsiz");
         
         //4-MASALA
        



        Random random = new Random();
        int secretNumber = random.Next(1, 101); // 1 dan 100 gacha son
        int guess = 0;
        
        Console.WriteLine("1 dan 100 gacha bo'lgan raqamni toping!");

        // Foydalanuvchi raqamni to'g'ri topmaguncha sikl davom etadi
        while (guess != secretNumber)
        {
            Console.Write("Raqamni kiriting: ");
            guess = int.Parse(Console.ReadLine());

            // Maslahat berish
            string message = guess > secretNumber ? "Kichikroq son kiriting" :
                             guess < secretNumber ? "Kattaroq son kiriting" :
                             "Tabriklayman! To'g'ri topdingiz.";
            
            Console.WriteLine(message);
        }
    }
}

    
    
