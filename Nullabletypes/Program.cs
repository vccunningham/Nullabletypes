using System;

namespace Nullabletypes {
    class Program {
        static void Main(string[] args) {

            var math = new Major { Id = 1, Description = "Math", MinSat = 900 };

            Student[] Students = new Student[] {


            new Student(1, "Jane", "J", 3.0, null, math, 900),

            new Student(2, "Jason", "J", 2.8, null, math, 900),

            new Student(3, "Jake", "Jake", 2.3, null, math, 900)

            


            };

        }
    }
}
