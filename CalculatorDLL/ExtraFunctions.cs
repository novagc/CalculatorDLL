﻿using System.Reflection;

namespace CalculatorDLL
{
    public class ExtraFunctions
    {
        public static ExtraFunctions Instance;
        
        private MethodInfo[] _methods;

        public ExtraFunctions()
        {
            var ExtraDLL = Assembly.LoadFile(@"./extra.dll");
            var funcsType = ExtraDLL.GetType("Extra.Functions");

            _methods = new[]
            {
                funcsType.GetMethod("Sin", BindingFlags.Static),
                funcsType.GetMethod("Cos", BindingFlags.Static),
                funcsType.GetMethod("Tan", BindingFlags.Static),
                funcsType.GetMethod("Cot", BindingFlags.Static)
            };

            Instance = this;
        }

        public double Sin(double f) => (double)_methods[0].Invoke(null, new object[] { f });

        public double Cos(double f) => (double)_methods[1].Invoke(null, new object[] { f });

        public double Tan(double f) => (double)_methods[2].Invoke(null, new object[] { f });

        public double Cot(double f) => (double)_methods[3].Invoke(null, new object[] { f });
    }
}
