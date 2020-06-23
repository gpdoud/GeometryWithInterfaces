using System;

namespace GeometryWithInterfaces {
    class Program {
        static void Main(string[] args) {

            var shapes = new IShape[] {
                new Quadrillaterial { Side1 = 1, Side2 = 3, Side3 = 5, Side4 = 7 },
                new Rectangle {Side1 = 2, Side2 =5 },
                new Square {Sides = 7 },
                null, null, null, null, null, null, null
            };

            foreach(var shape in shapes) {
                if(shape == null) continue;
                shape.Perimeter();
            }
        }
    }
}
