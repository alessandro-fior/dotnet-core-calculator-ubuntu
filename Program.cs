//--
using System;
using System.Threading;


namespace CalculatorConsole
{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

  class Program
  {
    static bool exp1() { Console.Write("exp1\n"); return true; }
    static bool exp2() { Console.Write("exp2\n"); return true; }
    static bool exp3() { Console.Write("exp3\n"); return true; }
    static bool exp4() { Console.Write("exp4\n"); return true; }

    static void Main(string[] args)
    {
      // Console.Write("Quanti hanni hai?  ->  ");
      // string lettura = Console.ReadLine();

      // //int eta = Convert.ToInt32(lettura);

      //if (int.TryParse(lettura, out int eta) && eta > 0 && eta <= 120)
      // {

      //   if (eta >= 18) //>, <, >=, <=, ==, !=
      //   {
      //     Console.WriteLine("Sei maggiorenne");

      //     if (eta >= 65 || eta >= 25 && eta <= 35)
      //       Console.WriteLine("Hai diritto a uno sconto");
      //   }
      //   else
      //     Console.WriteLine("Sei minorenne");
      //  }
      // else 
      //   Console.WriteLine("Il dato inserito non è un numero intero o non ricade nell`intervallo 1-120");


      //string lettura = "";
      //bool prima_volta_in_Italia = false;


      //bool b = !exp1() && exp2() || exp3() && exp4();

      //do
      //{
      //  Console.Write("Quanti anni hai (exit per terminare)? -> ");
      //  lettura = Console.ReadLine();

      //  if (int.TryParse(lettura, out int eta) && eta > 0 && eta <= 120)
      //  {
      //    Console.WriteLine(eta >= 18 ? "Sei maggiorenne" : "Sei minorenne");

      //    if ( (eta >= 12 && eta < 18) || (eta >= 65 && eta <= 75) )
      //      Console.WriteLine("Hai diritto a uno sconto!");

      //    if ( (eta <12 || eta>65) && prima_volta_in_Italia )
      //      Console.WriteLine("Ingresso gratuito!");
      //  }
      //  else
      //    Console.WriteLine("Devi inserire un valore numerico valido! Compreso tra 1 e 120");

      //} while (lettura != "exit");




      string scelta = "";
      do
      {
        Console.WriteLine("MENU\n");
        Console.WriteLine("1 - Somme");
        Console.WriteLine("2 - Sottrazioni");
        Console.WriteLine("3 - Prodotti");
        Console.WriteLine("4 - Divisioni");
        Console.WriteLine("5 - Potenze");
        Console.WriteLine("9 - ESCI");

        Console.WriteLine();

        Console.Write("SCEGLI -> ");
        scelta = Console.ReadLine();



        if (int.TryParse(scelta, out int operazione) && operazione >=1 && operazione<=5 || operazione==9)
        {

          int op1 = 0, op2 = 0;

          if (operazione != 9)
          {
            Console.Write("Primo operando -> ");
            int.TryParse(Console.ReadLine(), out op1);

            Console.Write($"{Environment.NewLine}Secondo operando -> ");
            int.TryParse(Console.ReadLine(), out op2);
          }

          switch (operazione)
          {
            case 1:
                Console.WriteLine($"{op1} + {op2} = {op1 + op2}");
              break;

            case 2:
                Console.WriteLine($"{op1} - {op2} = {op1 - op2}");
              break;

            case 3:
              Console.WriteLine($"{op1} * {op2} = {op1 * op2}");
              break;

            case 4:
              if (op2 != 0)
                Console.WriteLine($"{op1} / {op2} = {(double)op1 / op2}");
              else
                Console.WriteLine("Impossibile dividere per zero!");
              break;

            case 5:
                Console.WriteLine($"{op1} elevato alla {op2} = {Math.Pow(op1, op2)}");
              break;
          }
          

          //  if (operazione == 1)
          //  {

          //  }
          //  else
          //    if (operazione==2)
          //    {
          //      Console.WriteLine("Io svolgo sottrazioni ...");
          //    }
          //    else
          //      if (operazione==3)
          //      {
          //        Console.WriteLine("Io svolgo moltiplicazioni ...");
          //      }
          //      else
          //        if (operazione == 4)
          //        {
          //           Console.WriteLine("Io svolgo divisioni ...");
          //        }
          //        else
          //          if (operazione == 5)
          //          {
          //            Console.WriteLine("Io svolgo elevamenti a potenza ...");
          //          }
          //       }
          //else
          //{
          //  Console.WriteLine("SCELTA NON VALIDA!");
        }
        Console.ReadKey();
        Console.Clear();
      }
      while (scelta != "9");

    }
  }
}

//Random x = new Random();//Console.Write($"Hello World! {new String(' ', x.Next(20))}");
//Thread.Sleep(x.Next(100));