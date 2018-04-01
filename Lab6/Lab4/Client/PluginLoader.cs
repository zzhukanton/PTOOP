using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Client
{
    public class PluginLoader
    {
        private static PluginLoader _instance;
        private static readonly object InstanceLock;

        static PluginLoader()
        {
            InstanceLock = new object();
        }

        public static PluginLoader Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PluginLoader();
                        }
                    }
                }

                return _instance;
            }
        }

        public List<Type> LoadAllVegetableTypes()
        {
            var vegetableTypes = LoadVegetableTypes() ?? new List<Type>();

            vegetableTypes.AddRange(LoadPlugins());

            return vegetableTypes;
        }

        private List<Type> LoadVegetableTypes()
        {
            var vegetableTypes = new List<Type>();

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetTypes())
                {
                    if (t.IsSubclassOf(typeof(Vegetable)))
                    {
                        vegetableTypes.Add(t);
                    }
                }
            }
            return vegetableTypes;
        }
        private List<Type> LoadPlugins()
        {
            var vegetableTypes = new List<Type>();
            string[] assemblies = Directory.GetFiles("Plugins", "*.dll");

            foreach (String file in assemblies)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        // load the assembly
                        var asm = Assembly.LoadFrom(file);

                        // get all types from the assembly that inherit ITask
                        var query = from t in asm.GetTypes()
                                    where t.IsSubclassOf(typeof(Vegetable))
                                    select t;

                        // add types to list of startup tasks
                        foreach (Type type in query)
                        {
                            vegetableTypes.Add(type);
                        }
                    }
                }
                catch
                {
                }
            }

            return vegetableTypes;
        }
    }
}
