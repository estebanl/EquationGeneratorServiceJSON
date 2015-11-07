using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EquationGeneratorServiceJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EquationGeneratorService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EquationGeneratorService.svc o EquationGeneratorService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EquationGeneratorService : IEquationGeneratorService
    {

        public Equation GenerateEquation(string operation, string level)
        {
            int maximun = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(level)));
            int minimun = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(level )- 1));
            Random randomObject = new Random();
            Equation newEquation = new Equation(randomObject.Next(minimun,maximun),randomObject.Next(minimun,maximun), operation);
            return newEquation;

        }
        
    }
}
