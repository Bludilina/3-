using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class person : head_of_the_department

    abstract class person1
    {
        public abstract void Move();


        class man : person1
        {
            public override void Move()
            {
                Console.WriteLine("он идет");
            }
        }

        class woman : person1
        {
            public override void Move()
            {
                Console.WriteLine("она идет");
            }

        }
    }
    private string name;

    public string Name { get => name; set => name = value; }
    public int age;
    public int experience;

    public void Print()
    {
        Console.WriteLine(Name);
    }
}
}