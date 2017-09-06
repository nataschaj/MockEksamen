using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{
    public class Owner
    {
        //public string address { get; set; }
        //public string name { get; set; }
        //public string phone { get; set; }


        /// <summary>
        /// fuld property name. Hvis navnet er mindre end 4 bliver der smidt en exception. 
        /// </summary>
        public string name
        {
            get { return name; }
            set
            {
                if (value.Length < 4)
                    throw new CharacterTooShortException();
                name = value;
            }
        }

        //[StringLength(10, MinimumLength = 3, ErrorMessage = "skal være mellem 3 og 10! ")]
        //public string navn { get; set; }


        /// <summary>
        /// fuld property phone. Hvis phone/value ikke er lig med 8 bliver der smidt en exception
        /// </summary>
        public string phone
        {
            get { return phone; }
            set
            {
                if (value.Length != 8)
                    throw new ArgumentException();
                phone = value;
            }
        }

        /// <summary>
        /// fuld property adress. Hvis længden sættes til mindre end 6 bliver der smidt en exception
        /// </summary>
        public string adress
        {
            get { return adress; }
            set
            {
                if (value.Length < 6)
                    throw new ArgumentException("Længden er mindre end 6! ");
                adress = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Owner()
        {
      
        }

       
    }
}
