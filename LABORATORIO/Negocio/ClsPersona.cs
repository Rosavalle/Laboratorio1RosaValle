using LABORATORIO.Entidades;

namespace LABORATORIO.Negocio
{
    public class ClsPersona
    
            
    {
        public String CalcularIMC(Persona per)
        {
            double Promedio = per.Peso / Math.Pow(per.Altura, 2);

            if(Promedio > 25)
            {
                return $"tiene sobre peso";
            }
            else 
            {
                return $"tiene un peso ideal";
            }
        }

        public String MayorDeEdad(Persona per)
        {
            if(per.Edad >= 18)
            {
                return $"Es mayor de edad";
            }
            else
            {
                return $"Es menor de edad";
            }
        }
    }
}

    