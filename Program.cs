using System;
using System.Runtime.InteropServices;
///export LD_LIBRARY_PATH=...:$LD_LIBRARY_PATH
[DllImport("../../../libc.so")]
extern static int add(int a, int b);

[DllImport("../../../libasm.so", EntryPoint ="_start")]
extern static void hello();

int a = 5;
int b =2123;
Console.WriteLine("{0} + {1} = {2}", a, b, add(a,b));
hello();
