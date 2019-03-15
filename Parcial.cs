using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int salida = 0 ;

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for(int i = 0; i < notas.Length; i++)
        {
            if(notas[i] <= 3.0)
            {
                salida ++;
            }
        }

        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[5];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double[] tempnotas = new double [notas.Length];
        string[] tempnombres = new string[nombres.Length];

        for (int j = 0; j < notas.Length - 1; j++)
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (notas[i] > notas[i + 1])
                {

                    tempnotas[i] = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tempnotas[i];

                    tempnombres[i] = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tempnombres[i];
                }

            }
            for (int i = 0; i < 5; i++)
            {
                salida[i] = nombres[i];
            }
        }
            //- Arriba de esta línea va su código --------

            return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int legth = 0, v=0;
        string[] temp = new string[nombres.Length];
        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] > 3)
            {
                nombres[i] = "-n";
            }
            else legth++;
        }
        salida = new string[legth];
       
        for(int i = 0; i < nombres.Length; i++)
        {
            if(nombres[i] != "-n")
            {
                salida[v++] = nombres[i];
            }
             
        }


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        salida = new string[names.Length];
        for(int i=0; i < nombres.Length; i++)
        {
            if (nombres[i].Contains("A"))
            {
                salida[i] = nombres[i];
            }
        }


        //- Arriba de esta línea va su código --------

        return salida;
    }
}

