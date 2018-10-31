using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Jaramillo_Regino_Hector_Armando
{
   public class Menu
    {
        Operacion Op = new Operacion();
        public void Menu2()
        {
            Marca:
            Console.WriteLine("Que Codigo Desea ver: \n1.-Codigo 1 \n2.-Codigo 2 \n3.-Codigo 3 \n4.-Codigo 4");
            int Opcion = int.Parse(Console.ReadLine());
            switch(Opcion)
            {
                case 1:
                    Op.Ejercicio1();
                    break;
                case 2:
                    Op.Ejercicio2();
                    break;
                case 3:
                    Op.Ejercicio3();
                    break;
                case 4:
                    Op.Ejercicio4();
                    break;
                default:
                    Console.WriteLine("Ingrese una Opcion del Menu");
                    goto Marca2;
                    break;

            }
            Console.WriteLine("Presiona Enter para continuar");
            Console.ReadKey(true);
            Marca2:
            Console.Clear();
            Console.WriteLine("Desea Consultar Otro Codigo \n1.-Si \n2.-No");
            int Opcion2 = Convert.ToInt32(Console.ReadLine());
            switch(Opcion2)
            {
                case 1:
                    Console.Clear();
                    goto Marca;
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Ingrese una Opcion del Menu");
                    goto Marca2;
                    break;
                    
            }
        }
    }
}
