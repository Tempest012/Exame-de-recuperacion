using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_de_recuperacion.Class
{
    internal class Examen
    {
        public void Calificaciones()
        {
            int[] calificaciones = new int[10];
            Random random = new Random();

            for (int i = 0;i<calificaciones.Length;i++)
            {
                calificaciones = random.Next(10);
            }
            
            for(int h=0;h<calificaciones.Length;h++)
            {
                for(int j=h+1; j<calificaciones.Length;j++)
                {
                    int aux;
                    if (calificaciones[h] > calificaciones[j])
                    {
                        aux = calificaciones[h];
                        calificaciones[h] = calificaciones[j];
                        calificaciones[j] = aux;
                    }
                }

            }
            Console.WriteLine("Ingresa el numero a buscar");
            int valor=Convert.ToInt32(Console.ReadLine());
            int pos=0;
            bool bandera = false;
            while(pos < calificaciones.Length && bandera==false )
            {
                if(pos==valor)
                {
                    bandera = true;
                    break;
                }
                pos++;
            }
            if(bandera==true)
            {
                Console.WriteLine("Si se encontro el numero en la posicion" + pos);
            }
            else
            {
                Console.WriteLine("No se encontro el numero");
            }

        }
        public void Productos()
        {
            int[,] productos = { { 500, 1000, 250, 400, 60 },
                                 {3000,150,1800,130,20 },
                                 {100, 200,2900,90,4000 },
                                 {400,500,300,2400,3600 } };

            int producto1= 0;
            int producto2= 0;
            int producto3= 0;
            int producto4= 0;
            int producto5= 0;

            int verdedor1= 0;
            int verdedor2= 0;
            int verdedor3= 0;
            int verdedor4= 0;

            for(int i=0;i<4;i++)
            {
                producto1+= productos[i,0];
                producto2+= productos[i,1];
                producto3+= productos[i,2];
                producto4+= productos[i,3];
                producto5+= productos[i,4];
               
            }
            for(int i=0;i<5;i++)
            {
                verdedor1+= productos[0,i];
                verdedor2+= productos[1,i];
                verdedor3+= productos[2,i];
                verdedor4+= productos[3,i];
            }
            Console.WriteLine("El producto 1 obtuvo " + producto1);
            Console.WriteLine("El producto 2 obtuvo " + producto2);
            Console.WriteLine("El producto 3 obtuvo " + producto3);
            Console.WriteLine("El producto 4 obtuvo " + producto4);
            Console.WriteLine("El producto 5 obtuvo " + producto5);

            Console.WriteLine("El Vendedor 1 obtuvo " + verdedor1);
            Console.WriteLine("El Vendedor 2 obtuvo " + verdedor2);
            Console.WriteLine("El Vendedor 3 obtuvo " + verdedor3);
            Console.WriteLine("El Vendedor 4 obtuvo " + verdedor4);
        }

        public void Curp()
        {
            string[] curp=new string[18];

            for(int i=0; i<curp.Length;i++)
            {
                Console.WriteLine("Ingrese tu curp por digito");
                curp[i] = Console.ReadLine();

                if (curp[10]=="H")
                {
                    Console.WriteLine("Es hombre");
                }
                else { Console.WriteLine("Es mujer"); }

            }
        }

    }

}
