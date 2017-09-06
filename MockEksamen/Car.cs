using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{
    public class Car
    {
        public enum color { Black, White, Gray, Red, Green, Blue };

        public int doors
        {
            get { return doors; }
            set
            {
                if (value > 5)
                    throw new InvalidOperationException();
                doors = value;
            }
        }

        public string registrationNo
        {
            get { return registrationNo; }
            set
            {
                if (value.Length == 7)
                    throw new InvalidOperationException();
                registrationNo = value;
            }
        }

        public string model
        {
            get { return model; }
            set
            {
                if (value != null)
                    throw new InvalidOperationException();
                model = value;
            }
        }

        public Car()
        {

        }
    }
}
