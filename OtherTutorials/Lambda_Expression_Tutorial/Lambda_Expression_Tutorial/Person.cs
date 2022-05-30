using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Tutorial
{
    internal class Person
    {
        private string fname;
        private string lname;

        public Person(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public override string ToString() => $"{fname} {lname}".Trim();

        //public override string ToString()
        //{
        //    return $"{fname} {lname}".Trim();
        //}
    }
}
