using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car
    {
        private string carRegNumber;
        private string model;
        private string year;

        public Car(string aCarRegNumber, string aModel, string aYear)
        {
            carRegNumber = aCarRegNumber;
            model = aModel;
            year = aYear;
        }
        public string CarRegNumber
        {
            get { return carRegNumber; }
            set { carRegNumber = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
