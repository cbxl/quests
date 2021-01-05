using System;
using System.Reflection;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            User reflexion = new User();
            Reflected userClass = new Reflected(reflexion);
            userClass.GetAllProperties();
            userClass.GetAllFields();
            userClass.GetAllMethods();                       
        }

    }
}
