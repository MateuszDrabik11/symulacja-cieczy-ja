using System;
using System.Runtime.InteropServices;
///export LD_LIBRARY_PATH=...:$LD_LIBRARY_PATH
[DllImport("/home/drabcio/vs/symulacja cieczy - ja/libc.so")]
extern static int add(int a, int b);

[DllImport("/home/drabcio/vs/symulacja cieczy - ja/libasm.so", EntryPoint ="_start")]
extern static void hello();

int a = 5;
int b =2123;
Console.WriteLine("{0} + {1} = {2}", a, b, add(a,b));
hello();