using System;
using System.Collections.Generic;
using System.Text;
using DataModificationLibrary.Abstraction;

namespace DataModificationLibrary.Implementetion
{
    //The class, that contains a collection of plugins and is a plugin
    public class PluginCollection : Plugin<ICollection<IInputData>>
    {
        //The modify method will apply all plugins from collection to input
        public override ICollection<IInputData> Modify(ICollection<IInputData> data)
        {
            Console.WriteLine("INPUT DATA");
            Console.WriteLine(new string('-', 50));
            foreach (var plugin in data)
            {
                plugin.InputData();
            }
            Data = data;
            return base.Modify(Data);
        }

        //Overridden method to return the modified data
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(new string('-', 50));
            stringBuilder.AppendLine("OUTPUT DATA");
            stringBuilder.AppendLine(new string('-', 50));
            foreach (var plugin in Data)
            {
                stringBuilder.AppendLine(plugin.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
