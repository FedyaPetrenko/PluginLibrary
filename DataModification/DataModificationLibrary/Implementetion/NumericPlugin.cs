using System;
using System.Text;
using DataModificationLibrary.Abstraction;

namespace DataModificationLibrary.Implementetion
{
    //Implement plugin for Numeric type
    public class NumericPlugin : Plugin<double>, IInputData
    {
        //Invites the user input data
        public void InputData()
        {
            Console.WriteLine("Enter number to convert to absolute value: ");
            Data = Convert.ToDouble(Console.ReadLine());
            Modify(Data);
        }

        //Returns the modified data
        public override double Modify(double number)
        {
            return base.Modify(Abs(number));
        }

        //Returns the absolute value of the number
        private double Abs(double number)
        {
            if (number < 0)
                return -number;
            return number;
        }

        //Overridden method to return the modified data
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Number: {Data}");
            stringBuilder.AppendLine($"After transform to absolute value: {Modify(Data)}");
            stringBuilder.AppendLine(new string('-', 50));
            return stringBuilder.ToString();
        }
    }
}
