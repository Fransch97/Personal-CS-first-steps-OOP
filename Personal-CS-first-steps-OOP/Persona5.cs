using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_CS_first_steps_OOP
{
    internal class Persona5
    {
        private string name;
        private string surname;
        private int age;

        public Persona5(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        //setters
        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getName()
        {
            return this.name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public int getAge()
        {
            return this.age;
        }
    }
}
