using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Speed { get; set; }
        Vehicle type { get; set; }

        int setSpeed(int newspeed);
        int getSpeed();

    }
}
