using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ValidadorDocumento
    {
        //Aqui definimos los atributos - el estado
        private string tipo, genero, estadoValidacion;
        private long numero;
        private bool esValido;

        //Aqui definimos los metodos - los comportamneitos
        //Aqui viene en contructor de la clase
        public ValidadorDocumento()
        {
            tipo = "No Asignado";
            numero = 0;
            genero = "No Ingresado";
            esValido = false;
            estadoValidacion = "No se pudo validar";
        }
        public long Numero
        {
            get { return numero; }
            set {
                if (value >= 0)
                    numero = value;
            }
        }
        public bool EsValido
        {
            get { return esValido; }
        }

        public string Genero
        {
            get { return genero; }
            set
            {
                if(value == "M" || value == "F")
                {
                    genero = value;
                }
                else
                {
                    esValido = false;
                    estadoValidacion = "Incorrecto por dato erroneo de genero";
                }
            }
        }
        private void EjecutaValidacion()
        {
            //Se necesita la longitud del numero del documentos
            int longitud = numero.ToString().Length;

            //variable "flag" prar indicar si se fallo una validacion
            bool estaComprobada = true;

            //Aqui se implementa la regla numero No 1
            //cedula, hombre, longtud entre 3 y 8, rangos entre
            //1 y 19.999.999 y 70.000.000 y 99.999.999

        }
    }
}
