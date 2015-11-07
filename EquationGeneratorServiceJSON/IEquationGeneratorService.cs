using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EquationGeneratorServiceJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEquationGeneratorService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEquationGeneratorService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "equation/{operation}/{level}")]
        Equation GenerateEquation(string operation, string level);
    }
    
 
}
