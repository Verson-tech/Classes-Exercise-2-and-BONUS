using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
       public Car()
        {

        }
        //properties:
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        //constructor
        public Car(int yearInput,string makeInput, string modelInput, string engineNoiseInput, string honkNoiseInput, bool isDrivableInput)
        {
            Year = yearInput;
            Make = makeInput;
            Model = modelInput;
            EngineNoise = engineNoiseInput;
            HonkNoise = honkNoiseInput;
            IsDrivable = isDrivableInput;
        }

        //methods:
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
