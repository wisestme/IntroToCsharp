using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class VolvoCar : Car
    {
        public string VolvoSoundSystem;
        public VolvoCar(string owner, string color, int mpg, string sound)
            : base(owner, color, mpg)
        {
            VolvoSoundSystem = sound;
        }

        public override void PrintCarDetails()
        {
            base.PrintCarDetails();
            Console.WriteLine($"Volvo Sound System is {VolvoSoundSystem}");
        }
    }
}
