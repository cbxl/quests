using System;
using System.Reflection;

namespace Reflexion
{
    class Reflect
    {
        private String _lastName { get; set; }
        private String _phoneNumber { get; set; }
        public String pseudo { get; set; }

        public Reflect()
        {
            _lastName = String.Empty;
            _phoneNumber = String.Empty;
            pseudo = "pseudo001";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var reflect = new Reflect();
            GetAllProperties(reflect);
            GetAllFields(reflect);
            GetAllMethods(reflect);            
        }

        private static void GetAllProperties (object reflect)
        {
            Type type = reflect.GetType();
            PropertyInfo[] propertiesInfos = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            


            Console.WriteLine("Les propriétés sont : ");
            foreach (var prop in propertiesInfos)
            {
                Console.WriteLine("\t" + prop.Name);
               
            }

            
        }

        private static void GetAllFields(object reflect)
        {
            Type type = reflect.GetType();
            FieldInfo[] fieldsInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Les attributs sont : ");
            foreach (var field in fieldsInfos)
            {
                Console.WriteLine("\t" + field.Name);
            }

        }

        private static void GetAllMethods(object reflect)
        {
            Type type = reflect.GetType();
            MethodInfo[] methodsInfos = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Les méthodes sont : ");
            foreach (var method in methodsInfos)
            {
                Console.WriteLine("\t" + method.Name);
                if (method.IsPublic)
                    Console.WriteLine("Visibilité : " + "\t" + "publique");
                else if (method.IsPrivate)
                    Console.WriteLine("Visibilité : " + "\t" + "privée");
                else if (method.IsFamily)
                    Console.WriteLine("Visibilité : " + "\t" + "protégée");
            }

        }
        
    }
}
