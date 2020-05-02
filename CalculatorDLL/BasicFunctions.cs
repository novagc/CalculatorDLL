using System.Runtime.InteropServices;

namespace CalculatorDLL
{
    public static class BasicFunctions
    {
        [DllImport("./basic.dll")]
        public static extern int PlusInt(int f, int s);

        [DllImport("./basic.dll")]
        public static extern int MinusInt(int f, int s);

        [DllImport("./basic.dll")]
        public static extern int DivideInt(int f, int s);

        [DllImport("./basic.dll")]
        public static extern int MultiplyInt(int f, int s);

        [DllImport("./basic.dll")]
        public static extern double PlusDouble(double f, double s);

        [DllImport("./basic.dll")]
        public static extern double MinusDouble(double f, double s);

        [DllImport("./basic.dll")]
        public static extern double DivideDouble(double f, double s);

        [DllImport("./basic.dll")]
        public static extern double MultiplyDouble(double f, double s);
    }
}
