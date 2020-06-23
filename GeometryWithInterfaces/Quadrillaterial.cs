using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    class Quadrillaterial : IShape {

        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Perimeter() {
            Console.WriteLine($"Permeter is {Side1+Side2+Side3+Side4}");
        }
    }
}
