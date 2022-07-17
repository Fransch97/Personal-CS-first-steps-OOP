// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_CS_first_steps_OOP;

namespace OOP
{
    class Programm
    {
        static void Main(string[] args)
        {
            //classi e oggetti
            //first Instanz standart 
            Persona pers1 = new Persona();
            pers1.name = "francesco";
            pers1.surname = "negma";
            pers1.age = 2;
            Console.WriteLine(pers1.name);
            Console.WriteLine(pers1.surname);
            Console.WriteLine(pers1.age);
            Console.WriteLine("\n\n\n\n\n");


            //construct
            Persona2 pers2 = new Persona2("francesco", "negma", 25);
            Console.WriteLine(pers2.name + " " + pers2.surname + " " + pers2.age);

            pers2.name = "laae";

            Console.WriteLine(pers2.name + " " + pers2.surname + " " + pers2.age);
            Console.WriteLine("\n\n\n\n\n");


            //Overloading OOP
            Persona3 pers3 = new Persona3("francesco", "negma", 25);
            Console.WriteLine(pers3.name + " " + pers3.surname + " " + pers3.age);
            Persona3 pers3overload = new Persona3("francesco", "negma", "25");
            Console.WriteLine(pers3overload.name + " " + pers3overload.surname + " " + pers3overload.age);
            Console.WriteLine("\n\n\n\n\n");




            //private setter and getter standart
            Persona4 pers4 = new Persona4("Francesco", "nugma", 25);
            //Console.WriteLine(pers3.name + " " + pers3.surname + " " + pers3.age); will not work
            Console.WriteLine(pers4.getName() + " " + pers4.getSurname() + " " + pers4.getAge());

            pers4.setName("Marco");           
            Console.WriteLine(pers4.getName() + " " + pers4.getSurname() + " " + pers4.getAge());
            Console.WriteLine("\n\n\n\n\n");


            //class from other file
            Persona5 pers5 = new Persona5("Francesco", "nugma", 25);
            Console.WriteLine(pers5.getName() + " " + pers5.getSurname() + " " + pers5.getAge());

            pers5.setName("Marco");
            Console.WriteLine(pers5.getName() + " " + pers5.getSurname() + " " + pers5.getAge());
            Console.WriteLine("\n\n\n\n\n");


            //class methods
            Persona6 pers6 = new("Francesco", "nugma", 25);
            pers6.Saluta();

            pers6.setName("Marco");
            pers6.Saluta();
            Console.WriteLine("\n\n\n\n\n");

        }

        class Persona
        {
            public string name;
            public string surname;
            public int age;

        }

        class Persona2
        {
            public string name;
            public string surname;
            public int age;
            public Persona2(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }
        }

        class Persona3
        {
            public string name;
            public string surname;
            public int age;

            public Persona3(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public Persona3(string name, string surname, string age)
            {
                this.name = name;
                this.surname = surname;
                this.age = Convert.ToInt32(age);
            }
        }

        class Persona4
        {
            private string name;
            private string surname;
            private int age;

            public Persona4(string name, string surname, int age) 
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            //setters
            public void setName(string name)
            {
                this.name =name;
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

}
