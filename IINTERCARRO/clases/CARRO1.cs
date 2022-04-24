using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IINTERCARRO.clases
{
    internal class Carro
    {


        public string Marca { get; }
        public int Modelo { get; }

        public String Color { get; set; }
        private int bocina = 0;
        private int Encendido = 0;
        private int velocidad_actual = 0;
        //private const int MAXVELOCIDAD = 149;
        private int freno = 0;
        public int MAXVELOCIDAD { get; }



        public Carro(string _marca, int _modelo, string _color, int maxvel)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.velocidad_actual = 0;
        }



        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado";
            }


            string mensaje = "";
            if (velocidad_actual < MAXVELOCIDAD)
            {

                velocidad_actual += 30;
                mensaje = $"vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas, vas a maxima velocidad, Disminuye tu velocidad ";

            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }



        public string acelerar(int AcelerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += AcelerarAkph;
                mensaje = $"vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";

            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }



        public string GetVelocidadActual()
        {
            return $"VAmos a {velocidad_actual}KPH";
        }


        public string EncenderMotor()
        {

            string mensaje = "";

            if (Encendido == 0)
            {
                Encendido = 1;
                mensaje = "Brururururururu carro encendido!!";
                velocidad_actual = 0;

            }
            else
            {
                mensaje = "ups el carro ya estaba encendido";
            }
            return mensaje;
        }



        public string Desacelerar()
        {

            string mensaje = "";


            if (velocidad_actual <= 0)
            {

                mensaje = $"has parado 0 KPH\n";

            }
            else
            {
                velocidad_actual -= 30;
                mensaje = $"disminuyes la velocidad a {velocidad_actual} KPH";
                
            }




            //Console.WriteLine(mensaje);
            return mensaje;

        }

        public string Frenado()
        {
            if (Encendido == 0 && velocidad_actual==0)
            {

                Encendido = 1;
                return "EL CARRO ESTA PARADO, VELOCIDAD O KPH";

            }
           

                string mensaje = "";

                freno = velocidad_actual;

                velocidad_actual -= freno;
                mensaje = $"\nAGUAS EL TRAFICO!! HAS FRENADO {velocidad_actual} KPH\n";



                //Console.WriteLine(mensaje);
                return mensaje;


            


        }


        public string pitar()
        {


            return "\nHAS PITADO";


        }



        public string ApagarMotor()
        {
            string mensaje = "";

            if (Encendido == 1)
            {
                Encendido = 0;
                mensaje = "HAS APAGADO El CARRO";
            }
            else
            {
                mensaje = "EL CARRO YA ESTABA APAGADO";

            }
           


            return mensaje;

        }






    }
}
