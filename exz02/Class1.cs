using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace exz02
{
    public class Class1
    {
        public int cena = 35; // Цена 1 км
        public double rast;
        public void Km()
        {
            Console.WriteLine("Введите растояние");
            rast = Convert.ToDouble(Console.ReadLine());
        }
          
        public double MassaGruza(double dlina, double shirina, double visota, double plotnost)
        {
            return dlina*shirina*visota*plotnost;
        }
        public void Proverka(double dlina, double shirina, double dlinaGruza, double shirinaGruza, double obem, double visotaGruza, double massa, double plotnost )
        {
            if(obem/(dlina*shirina)>visotaGruza)
            {
                if(dlinaGruza<dlina)
                {
                    if(shirinaGruza<shirina)
                    {
                        if(massa>(dlinaGruza* shirinaGruza*visotaGruza* plotnost))
                        {
                            Console.WriteLine("Стоимость "+Stoimost(cena, rast, dlinaGruza, shirinaGruza, visotaGruza, plotnost));
                        }
                        else
                        {
                            Console.WriteLine("Перевес");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Груз не помещается");
                    }
                }
                else if(dlinaGruza<shirina)
                {
                    if(shirinaGruza<dlina)
                    {
                        if (massa > (dlinaGruza * shirinaGruza * visotaGruza * plotnost))
                        {
                            Console.WriteLine("Стоимость " + Stoimost(cena, rast, dlinaGruza, shirinaGruza, visotaGruza, plotnost));
                        }
                        else
                        {
                            Console.WriteLine("Перевес");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Груз не помещается");
                    }
                }
                else
                {
                    Console.WriteLine("Груз не помещается");
                }
            }
            else
            {
                Console.WriteLine("Груз не помещается");
            }
        }
        public double Stoimost(double cena, double km, double dlinaGruza, double shirinaGruza,  double visotaGruza, double plotnost)
        {
            double masGruz = MassaGruza(dlinaGruza, shirinaGruza, visotaGruza, plotnost);
           for(int i =0; i<= 99999999; i++)
            {
                if(masGruz/300>1)
                {
                    cena++;
                    masGruz = masGruz-300;
                }
            }
            return cena * km;
        }
    }
}
