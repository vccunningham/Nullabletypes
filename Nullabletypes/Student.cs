using System;
using System.Collections.Generic;
using System.Text;

namespace Nullabletypes {
    class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double GPA { get; set; }
        public int? SAT { get; set; }

        public Student(int id, string firstname, string lastname, double gpa, int? sat) {

            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            GPA = gpa;
            SAT = sat;

            {
                Console.WriteLine($"Id = {id}, Name= {Firstname} {Lastname}, GPA = {GPA}, SAT = {SAT}");
        }   }

        public Student(int id, string firstname, string lastname, double gpa, int? sat, Major math, int v) : this(id, firstname, lastname, gpa, sat) {
        }

        public Student(int id, string firstname, string lastname, double gpa, int? sat, object ) : this(id, firstname, lastname, gpa, sat) {
        }
    }
}
