using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia.Models
{
    public class Inmueble
    {
        public string direccion;
        public int superficie;
        public int antiguedad;
        public float precioBase;  


        public virtual float CalcularDescuentos() { return 0; }
    }



    public class Piso : Inmueble
    {
        private int pisoNro;
        public Piso(string dire, int super, int antigue, float precio, int piso)
        {
            direccion = dire;
            superficie = super;
            antiguedad = antigue;
            precioBase = precio;
            this.pisoNro = piso;
        }

        public override float CalcularDescuentos()
        {
            if(pisoNro >= 3)
            {
                precioBase += (precioBase * 3) / 100;
            }
            return precioBase;
        }
    }


    public class Local : Inmueble
    {
        private int nroDeVentanas;
        public Local(string dire, int super, int antigue, float precio, int nro)
        {
            direccion = dire;
            superficie = super;
            antiguedad = antigue;
            precioBase = precio;
            this.nroDeVentanas = nro;
        }

        public override float CalcularDescuentos()
        {
            if (antiguedad < 15)
            {
                precioBase -= (precioBase * 1) / 100;
            }
            else if (antiguedad > 15)
            {
                precioBase -= (precioBase * 2) / 100;
            }


            if(superficie >= 50)
            {
                if(nroDeVentanas <= 1)
                {
                    precioBase -= (precioBase * 2) / 100;
                }
                else if(nroDeVentanas > 4)
                {
                    precioBase += (precioBase * 2) / 100;
                }
                
            }

            return precioBase;
        }
    }
}
