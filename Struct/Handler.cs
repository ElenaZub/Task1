using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Handler
    {
        public void Execute()
        {
            MyClass myClass = new MyClass();
            myClass.SetChange("Not change");

            MyStruct myStruct = new MyStruct();
            myStruct.SetChange("Not change");

            Console.WriteLine($"My class: {myClass.GetChange()}");
            Console.WriteLine($"My struct: {myStruct.GetChange()}");

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine($"My class: {myClass.GetChange()}");
            Console.WriteLine($"My struct: {myStruct.GetChange()}");
        }

        private void ClassTaker(MyClass myClass)
        {
            myClass.SetChange("Change");
        }

        private void StructTaker(MyStruct myStruct)
        {
            myStruct.SetChange("Change");
        }
    }
}
