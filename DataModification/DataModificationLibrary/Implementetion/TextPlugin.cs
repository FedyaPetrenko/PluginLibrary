using System;
using System.Text;
using DataModificationLibrary.Abstraction;

namespace DataModificationLibrary.Implementetion
{
    //Implement plugin for String type
    public class TextPlugin : Plugin<string>, IInputData
    {
        //Invites the user input data
        public void InputData()
        {
            Console.WriteLine("Enter text to convert to upper invariant: ");
            Data = Console.ReadLine();
            Modify(Data);
        }

        //Returns the modified data
        public override string Modify(string data)
        {
            return base.Modify(data.ToUpperInvariant());
        }

        //Overridden method to return the modified data with explanations
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Text: {Data}");
            stringBuilder.AppendLine($"After modify to uppercase: {Modify(Data)}");
            stringBuilder.AppendLine(new string('-', 50));
            return stringBuilder.ToString();
        }
    }
}
