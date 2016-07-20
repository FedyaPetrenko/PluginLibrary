using System;
using System.Text;
using DataModificationLibrary.Abstraction;

namespace DataModificationLibrary.Implementetion
{
    //Implement plugin for DateTime type
    public class DateTimePlugin : Plugin<DateTime>, IInputData
    {
        //Invites the user input data
        public void InputData()
        {
            Console.WriteLine("Enter date and time to convert to UTC (day.month.year hour:minute:second): ");
            Data = Convert.ToDateTime(Console.ReadLine());
            Modify(Data);
        }

        //Returns the modified data
        public override DateTime Modify(DateTime data)
        {
            return base.Modify(data.ToUniversalTime());
        }

        //Overridden method to return the modified data
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Time now: {Data}");
            stringBuilder.AppendLine($"After transform to UTC: {Modify(Data)}");
            stringBuilder.AppendLine(new string('-', 50));
            return stringBuilder.ToString();
        }
    }
}
