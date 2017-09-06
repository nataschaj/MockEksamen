using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{
    class Owner
    {
        //public string address { get; set; }
        //public string name { get; set; }
        //public string phone { get; set; }

        public string name
        {
            get { return name; }
            set
            {
                if (value.Length < 4)
                    throw new InvalidOperationException();
                name = value;
            }
        }

        public string phone
        {
            get { return phone; }
            set
            {
                if (value.Length != 8)
                    throw new InvalidOperationException();
                phone = value;
            }
        }


        public string adress
        {
            get { return adress; }
            set
            {
                if (value.Length < 6)
                    throw new InvalidOperationException();
                adress = value;
            }
        }


        public Owner()
        {

        }

       
    }
}
