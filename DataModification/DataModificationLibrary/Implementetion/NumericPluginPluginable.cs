using System;
using DataModificationLibrary.Abstraction;

namespace DataModificationLibrary.Implementetion
{
    //The class, that are a plugin and a pluginable at the same time
    public class NumericPluginPluginable : Pluginable<double>, IInputData
    {
        //Invites the user input data
        public void InputData()
        {
            Console.WriteLine("Enter number to convert to absolute value and multiply by 2: ");
            Data = Convert.ToDouble(Console.ReadLine());
        }

        //Returns the modified data by itself and by plugin
        public override double Modify(double data)
        {
            Plug = new NumericPlugin();
            Data = Plug.Modify(MultiplyForTwo(data));
            return base.Modify(Data);
        }

        //Returns the modified data by itself
        private double MultiplyForTwo(double number)
        {
            return number*2;
        }
    }
}
