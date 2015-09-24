using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCoches
{
    class Coche
    {
        private string nBastidor;
        private string marca;
        private string modelo;
        private string nVelocidades;
        private DateTime fMatriculacion;

        public Coche ()
        {
            this.NBastidor = "";
            this.Marca = "";
            this.Modelo = "";
            this.NVelocidades = "";
            this.FMatriculacion = DateTime.Now;
        }

        /*public Coche(string nBastidor, string marca)
        {
            this.NBastidor = "";
            this.Marca = "";
            this.Modelo = "";
            this.NVelocidades = "";
            this.FMatriculacion = DateTime.Now;
        }*/

        public string NBastidor
        {
            get
            {
                return nBastidor;
            }

            set
            {
                nBastidor = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string NVelocidades
        {
            get
            {
                return nVelocidades;
            }

            set
            {
                nVelocidades = value;
            }
        }

        public DateTime FMatriculacion
        {
            get
            {
                return fMatriculacion;
            }

            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("la fecha introducida no es valida");
                }
                else
                {
                    fMatriculacion = value;
                }
            }
        }
    }
}
