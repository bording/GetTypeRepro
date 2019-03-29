using System;

namespace GetTypeRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Project is referencing Library.dll via PackageReference

            //Uncomment this to see it work in netcoreapp3.0 (and netcoreapp2.2 if CopyLocalLockFileAssemblies is uncommented in the csproj)
            //System.Reflection.Assembly.LoadFrom("Repro.dll");

            var type1 = Type.GetType("Library.Class1, Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", true); // < package version
            var type2 = Type.GetType("Library.Class1, Library, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", true); // == package version
            var type3 = Type.GetType("Library.Class1, Library, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null", true); // > package version
        }
    }
}
