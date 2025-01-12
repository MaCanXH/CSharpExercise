using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingAndUsingObjects;

namespace Chapter_11
{
    class Q7
    {
        static void ans()
        {
            Console.WriteLine("Sequnce[1...3]: {0}, {1}, {2}",
                Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());

            Cat somecat = new Cat();
            somecat.Name = "Johnny";
            somecat.Color = "blue";
            somecat.SayMiau();
        }

    }
}
