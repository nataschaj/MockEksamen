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
        /// Door fuld property, hvor value sættes til under 5. Hvis den sættes til over 5 bliver der smidt en exception
        /// </summary>
        private int doors;
        public int Doors
        {
            get { return doors; }
            set
            {
                if (value > 5)
                {
                    throw new IllegalDoorsException();
                }
                doors = value;
            }
        }

        /// <summary>
        /// fuld property reg no. Hvis ikke at reg no sættes til præcis 7, bliver der smidt en exception. 
        /// </summary>
        private string registrationNo;
        public string RegistrationNo
        {
            get { return registrationNo; }
            set
            {
                if (value.Length != 7)
                {
                    throw new SpecificCharactertException();
                }
                registrationNo = value;
            }
        }

        

        /// <summary>
        /// fuld property model. Hvis model/value bliver sat til null bliver der smidt en exception.
        /// </summary>
        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Må ikke være null");
                }
                model = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Car()
        {

        }


        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="doors"></param>
        /// <param name="RegistrationNo"></param>
        public Car(string model, int doors, string RegistrationNo)
        {
            this.Doors = doors;
            this.Model = model;
            this.RegistrationNo = registrationNo;
        }

        //public string NotNullModel()
        //{
        //    return model ?? null;
        //}
    }
}
