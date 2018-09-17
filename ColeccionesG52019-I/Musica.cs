using System;


namespace ColeccionesG52019_I
{
    class Musica
    {
        private string autor;
        private string album;
        private string año;
        private string titulo;

        public Musica(string autor, string album, string año, string titulo)
        {
            this.autor = autor;
            this.album = album;
            this.año = año;
            this.titulo = titulo;
        }

        public void Reproducir()
        {
            Console.WriteLine("Se está reproduciendo" + this.titulo + " - " + this.autor);

        }

        public void Pausar()
        {
            Console.WriteLine("Musica pausada");
        }

        public void Detener()
        {
            Console.WriteLine("Musica detenida");
        }

        public override string ToString()
        {
            string cancion;
            cancion = titulo + " - " + autor;
            return cancion;
        }


    }
}
