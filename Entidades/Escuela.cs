namespace CoreEscuela.Entidades
{
    class Escuela
    {
         string nombre;

        //Constructor corto 
        public Escuela(string nombre, int anioDeCreacion) => (Nombre,AnioDeCreacion) = (nombre,anioDeCreacion);

        public Escuela(string nombre, int anioDeCreacion, TiposEscuela tipoEscuela, string pais= "")
        {
            (Nombre,AnioDeCreacion) = (nombre,anioDeCreacion);
            (TipoEscuela,Pais) = (tipoEscuela,pais);
        }
        //Metodo largo
        public string Nombre{
            get{return nombre;}
            set{nombre= value.ToUpper();}
        }
        
        //Metodo corto
        public int AnioDeCreacion{get; set;}
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Curso[] Cursos { get; set; }

        public override string ToString()
        {
            return $"Nombre:{Nombre}, Tipo:{TipoEscuela} \n Pais:{Pais}, Ciudad:{Ciudad}";
        }
        
    }
}