using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    class Rectangle : IShape {

        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public void Perimeter() {
            Console.WriteLine($"Permeter is {2 * (Side1 + Side2)}");
        }

    }
}
