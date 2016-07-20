using System;
using System.Collections.Generic;
using DataModificationLibrary.Abstraction;
using DataModificationLibrary.Implementetion;

namespace DataModificationDemo
{
    internal static class Program
    {
        private static void Main()
        {
            //Instantiating plugins
            var numPlugin = new NumericPlugin();
            var dateTimePlugin = new DateTimePlugin();
            var textPlugin = new TextPlugin();

            //Create instance a collection of plugins
            var collection = new PluginCollection();

            //Apply all plugins from collection to input
            collection.Modify(new List<IInputData> {numPlugin, dateTimePlugin, textPlugin});

            //Display the results
            Console.WriteLine(collection.ToString());

            //Create instance the class, that are a plugin and a pluginable at the same time
            var pluginable = new NumericPluginPluginable();

            //The output request entering data
            pluginable.InputData();

            //Output data after modification
            pluginable.Print();

            Console.Read();
        }
    }
}
