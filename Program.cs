// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais= "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela =TiposEscuela.Secundaria;

            Console.WriteLine(escuela);

            Curso curso1 = new Curso()
            {
                Nombre = "Java",
                Jornada = TiposJornada.Mañana
            };

            Curso curso2 = new Curso()
            {
                Nombre = "C#",
                Jornada = TiposJornada.Tarde
            };

            Curso[] arregloCursos = new Curso[2];

            arregloCursos[0] = curso1;
            arregloCursos[1] = curso2;

            escuela.Cursos = arregloCursos;

            ImprimirCursosWhile(arregloCursos);
            ImprimirCursosDoWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos);
            ImprimirCursosForEach(arregloCursos);
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while(contador < arregloCursos.Length)
            {
                Console.WriteLine($"While Nombre: {arregloCursos[contador].Nombre}, Id:{arregloCursos[contador].UniqueId}, Jornada:{arregloCursos[contador].Jornada}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($" DoWhile Nombre: {arregloCursos[contador].Nombre}, Id:{arregloCursos[contador].UniqueId}, Jornada:{arregloCursos[contador].Jornada}");
                contador++;
            }while(contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($" For Nombre: {arregloCursos[i].Nombre}, Id:{arregloCursos[i].UniqueId}, Jornada:{arregloCursos[i].Jornada}");
                
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
               Console.WriteLine($" ForEach Nombre: {curso.Nombre}, Id:{curso.UniqueId}, Jornada:{curso.Jornada}"); 
            }
        }
    }
}
