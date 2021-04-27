using System.IO;
using System.Linq;
using System.Reflection;

namespace CalculatorDLL
{
    public class ExtraFunctions
    {
        public static ExtraFunctions Instance;
        
        private readonly MethodInfo[] _methods;

        public int ExtraFuncCount => _methods.Length;

        public ExtraFunctions()
        {
            var dll = Assembly.LoadFile($"{Directory.GetCurrentDirectory()}/Extra.dll");
            var funcsType = dll.GetType("Extra.Functions");

            _methods = funcsType.GetMethods()
                .Where(x => 
                    x.IsStatic && 
                    !x.IsAbstract && 
                    !x.IsConstructor && 
                    x.IsPublic && 
                    x.ReturnType == typeof(double) &&
                    x.GetParameters().Length == 1 &&
                    x.GetParameters()[0].ParameterType == typeof(double))
                .Take(4)
                .ToArray();

            Instance = this;
        }

        public string GetFuncName(int funcNumber) => _methods[funcNumber].Name;
        public double ExecExtraFunc(int funcNumber, double f) => (double)_methods[funcNumber].Invoke(null, new object[] { f });
    }
}
