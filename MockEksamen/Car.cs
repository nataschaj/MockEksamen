using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{
    /// <summary>
    /// Enum som indeholder bil farverne 
    /// </summary>
    public enum color { Black, White, Gray, Red, Green, Blue };
    public class Car
    {

        /// <summary>
        /// Enum som indeholder bil farverne 
        /// </summary>
       


        /// <summary>
        /// Door fuld property, hvor value sættes til under 5. Hvis den sættes til over 5 bliver der smidt en exception
        /// </summary>
        public int doors
        {
            get { return doors; }
            set
            {
                if (value > 5)
                    throw new InvalidOperationException("Må ikke være under 5!");
                doors = value;
            }
        }

        /// <summary>
        /// fuld property reg no. Hvis ikke at reg no sættes til præcis 7, bliver der smidt en exception. 
        /// </summary>
        public string registrationNo
        {
            get { return registrationNo; }
            set
            {
                if (value.Length != 7)
                    throw new ArgumentNullException("længden skal være 7 bogstaver");
                registrationNo = value;
            }
        }

        /// <summary>
        /// fuld property model. Hvis model/value bliver sat til null bliver der smidt en exception.
        /// </summary>
        public string model
        {
            get { return model; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Må ikke være null");
                model = NotNullModel();
            }
        }

        public string NotNullModel()
        {
            return model ?? null;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Car()
        {
            //this.model = Model;
            //this.doors = doors;
        }


    }
}
