using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    class Square : IShape {

        public int Sides { get; set; }

        public void Perimeter() {
            Console.WriteLine($"Permeter is {4 * Sides}");
        }

    }
}
