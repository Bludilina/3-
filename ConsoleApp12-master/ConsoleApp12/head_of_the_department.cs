using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class head_of_the_department : teacher
    {
        private new string name;
        public int age;
        public int experience;
        void info()
        {
            Console.WriteLine("Ввести данные о себе");
        }
    }
}
