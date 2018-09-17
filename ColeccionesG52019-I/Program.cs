using System;
using System.Collections;

namespace ColeccionesG52019_I
{
    class Program
    {
        static void Main()
        {
            ArrayList colcadenas = new ArrayList();
            colcadenas.Add("Uno");
            colcadenas.Add("Dos");
            colcadenas.Add("Tres");

            foreach(string cadena in colcadenas)
            {
                Console.WriteLine(cadena);
            }

            ArrayList colnumeros = new ArrayList();
            colnumeros.Add(1);
            colnumeros.Add(2);
            colnumeros.Add(3);

            foreach( int numero in colnumeros   )
            {
                Console.WriteLine(numero);
            }
            
            colnumeros.Add(3.1416f);
            colnumeros.Add(123456789123456789);

            for(int i=0; i < colnumeros.Count; i++ )
            {
                if( i < 3)
                {
                    int num = (int)colnumeros[i];
                    Console.WriteLine(num);
                }

                if (i==3)
                {

                    float pi = (float)colnumeros[3];
                    Console.WriteLine(pi);

                }

                if(i == 4)
                {
                    long num_1 = (long)colnumeros[4];
                    Console.WriteLine(num_1.GetType());
                }
            }

            colcadenas.Add("21");

            int res = (int)(colnumeros[0]) + int.Parse(colcadenas[3].ToString());
            Console.WriteLine("El resultado de {0} + {1} = {2}", colnumeros[0], colcadenas[3], res);

            colcadenas.Remove("Dos");
            Console.WriteLine(colcadenas[1]);

            colcadenas.RemoveAt(2);
            Console.WriteLine(colcadenas[1]);

            colcadenas.Add("30");
            colcadenas.Add("11");
            colcadenas.Add("9");
            colcadenas.Add(15);
            colcadenas.Add("Treinta");



            int pos = colcadenas.IndexOf("9");

            int sum = int.Parse(colcadenas[pos].ToString()) + (int)colnumeros[2];
            Console.WriteLine(sum);

            Musica cancion1 = new Musica("The Beatles", "Abbey Road", "1969", "Abbey Road");
            Musica cancion2 = new Musica("Avicii", "01", "2017", "Without You");
            Musica cancion3 = new Musica("J Balvin", "No se", "2018", "Despacito");

            ArrayList listacanciones = new ArrayList();

            listacanciones.Add(cancion1);
            listacanciones.Add(cancion2);
            listacanciones.Add(cancion3);

            Console.WriteLine("¿Qué canción quieres reproducir?");
            int c = 0;
            foreach(Musica can in listacanciones)
            {
                Console.WriteLine("[" + c + "]" + can.ToString());
                c++;
            }
            c = int.Parse(Console.ReadLine());
            Musica seleccionada = (Musica)listacanciones[c];
            seleccionada.Reproducir();
            seleccionada.Pausar();
            seleccionada.Detener();
            



        }
    }
}
