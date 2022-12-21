using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16  // abstruct class  it should be override and abstrct method should be in abstruct class only
{
    abstract class MyAbstarct
    {
        public abstract void add();
    } //.example for abstract ckass
    class childabstract : MyAbstarct
    {
        public override void add()
        {
            Console.WriteLine("hello");
        }
    }
}
