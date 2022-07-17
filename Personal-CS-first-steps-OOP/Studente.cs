using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personal_CS_first_steps_OOP
{
     class Studente: Persona6
    {
        public string school;
        public string @class;
        public Studente(string name, string surname, int age, string @class, string school) : base( name, surname, age)
        {
            this.school = school;
            this.@class = @class;
        }
    }
}
