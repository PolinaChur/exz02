using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exz02
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Program program= new Program();
                    Class1 class1 = new Class1();
                    Console.WriteLine("Введите максимально разрешенную массу в тоннах");
                    double massa = Convert.ToDouble(Console.ReadLine());
                    massa = massa * 1000;                                               // масса в (кг)
                    Console.WriteLine("Введите объем кузова");
                    double obem = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите длину кузова");                   // длинна кузова в (м)
                    double dlina = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите ширину кузова");                   // ширина кузова в (м)
                    double shirina = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите длину груза");                   //
                    double dlinaGruza = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите ширину груза");
                    double shirinaGruza = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту груза");
                    double visotaGruza = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите плотность груза");
                    double plotnostGruza = Convert.ToDouble(Console.ReadLine());
                class1.Km();
                     
                class1.MassaGruza(dlinaGruza, shirinaGruza, visotaGruza, plotnostGruza);
                class1.Proverka(dlina, shirina, dlinaGruza, shirinaGruza, obem, visotaGruza,massa,plotnostGruza);
                Console.ReadKey();
            }
            catch (Exception)
            {
                TextWriterTraceListener[] traceListener = new TextWriterTraceListener[1];
                {
                    new TextWriterTraceListener("debug.txt");                                                       // Отладочные классы
                }
                Debug.Listeners.AddRange(traceListener);
                Debug.WriteLine("Ошибка");
                Debug.Flush();
            }
        }
    }
}
