using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflexion
{
    public class Reflected
    {
        private Type _type;

        public Reflected(object reflect)
        {
            _type = reflect.GetType();
        }
        public void GetAllProperties()
        {            
            PropertyInfo[] propertiesInfos = _type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Les propriétés : ");
            foreach (PropertyInfo prop in propertiesInfos)
            {
                Console.WriteLine("\t" + "Nom : " + prop.Name);

            }


        }

        public void GetAllFields()
        {
            FieldInfo[] fieldsInfos = _type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Les attributs : ");
            foreach (FieldInfo field in fieldsInfos)
            {
                Console.WriteLine("\t" + "Nom :" + field.Name);
                if (field.IsPrivate)
                {
                    Console.WriteLine("\t" + "Visibilité privée");
                }
                else if (field.IsPublic)
                {
                    Console.WriteLine("\t" + "Visibilité publique");
                }
            }

        }

        public void GetAllMethods()
        {
            MethodInfo[] methodsInfos = _type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Les méthodes : ");
            foreach (MethodInfo method in methodsInfos)
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

