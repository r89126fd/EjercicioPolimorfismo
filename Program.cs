using System;

namespace EjercicioPolimorfismo
{
    // Clase base
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("El animal se mueve.");
        }
    }

    // Clase derivada 1
    class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }

        public override void Moverse()
        {
            Console.WriteLine("El perro corre rápidamente.");
        }
    }

    // Clase derivada 2
    class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau miau!");
        }

        public override void Moverse()
        {
            Console.WriteLine("El gato camina sigilosamente.");
        }
    }

    // Clase derivada 3
    class Pajaro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El pájaro canta: ¡Pío pío!");
        }

        public override void Moverse()
        {
            Console.WriteLine("El pájaro vuela en el cielo.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            Animal miGato = new Gato();
            Animal miPajaro = new Pajaro();

            // Polimorfismo en acción
            miPerro.HacerSonido();
            miPerro.Moverse();

            miGato.HacerSonido();
            miGato.Moverse();

            miPajaro.HacerSonido();
            miPajaro.Moverse();
        }
    }
}
