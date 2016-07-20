using System;

namespace DataModificationLibrary.Abstraction
{
    //Generic class, which is the interface to work with plug-ins
    public abstract class Pluginable<T> : Plugin<T>
    {
        //The property, which is a plug-in for data modification
        protected Plugin<T> Plug { get; set; }

        //The method to display the final value to the console
        public void Print()
        {
            Console.WriteLine($"Number after transform: {Modify(Data)}");
        }
    }
}
