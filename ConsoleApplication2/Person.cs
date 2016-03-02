using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  class Person
  {
    public String LN;
    public String FN;

    public Person(String ln, String fn)
    {
      this.LN = ln;
      this.FN = fn;
    }

    public override String ToString()
    {
      return this.LN + " " + this.FN;
    }
  }
}
