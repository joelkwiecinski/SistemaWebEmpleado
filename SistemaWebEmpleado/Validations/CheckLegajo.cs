using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleado.Validations
{
    public class CheckLegajo : ValidationAttribute
    {
        public CheckLegajo()
        {
            ErrorMessage = "El formato del legajo debe ser AA12345, es decir, comienza con AA y lleva 5 números.";
        }

        public override bool IsValid(object value)
        {
            string legajo = Convert.ToString(value);

            // Por las dudas, limpiamos espacios en blanco
            legajo.Replace(" ", "");

            // Chequeamos que comience con AA y que tenga números
            if (legajo.Substring(0, 2) == "AA" && int.TryParse(legajo.Replace("AA", ""), out int numLegajo) && legajo.Replace("AA", "").Length == 5)
            {
                // Comienza con AA y el resto son números
                return true;
            } else
            {
                return false;
            }
        }
    }
}