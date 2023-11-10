using Exame_de_recuperacion.Class;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Examen examen = new Examen();

            examen.Productos();
            examen.Curp();
            examen.Calificaciones();
        }
    }
}