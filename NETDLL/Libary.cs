using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NETDLL
{
    public class Libary
    {
        [DllImport("CLanguageDLL.dll")]
        public extern static int Add(int m, int n);
        [DllImport("CLanguageDLL.dll")]
        public extern static int Subtract(int m, int n);
        [DllImport("CLanguageDLL.dll")]
        public extern static int Multiply(int m, int n);
        [DllImport("CLanguageDLL.dll")]
        public extern static int Divide(int m, int n);
    }
}
