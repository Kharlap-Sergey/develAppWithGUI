using System;

namespace ConsoleApp5
{
    class A
    {
        int a;
        public A(int x)
        {
            this.a = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestSByte();
            TestByte();
            TestShort();
            TestUShort();
            TestInt();
            TestUInt();
            TestLong();
            TestULong();
            TestChar();
            TestFloat();
            TestDouble();
            TestBool();
            TestDecimal();
            TestString();
            TestObject();
            TestDynamic();
        }

        public static void TestSByte()
        {
            sbyte a = 5, b = 2, c;

            Console.WriteLine("**** Sbyte *****");

            c = (sbyte)(a + b);
            Console.WriteLine(a + " + " + b + " = " + c);

            c = (sbyte)(a - b);
            Console.WriteLine(a + " - " + b + " = " + c);

            c = (sbyte)(a * b);
            Console.WriteLine(a + " * " + b + " = " + c);

            c = (sbyte)(a / b);
            Console.WriteLine(a + " / " + b + " = " + c);

            c = (sbyte)(a % b);
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = (sbyte)(a & b);
            Console.WriteLine(a + " & " + b + " = " + c);

            c = (sbyte)(a | b);
            Console.WriteLine(a + " | " + b + " = " + c);

            c = (sbyte)(a ^ b);
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = (sbyte)(~a);
            Console.WriteLine("~" + a + " = " + c);

            c = (sbyte)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (sbyte)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = (sbyte)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (sbyte)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));
            Console.WriteLine("c >>= " + a + " c = " + (c >>= a));
            Console.WriteLine("c <<= " + a + " c = " + (c <<= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            Console.WriteLine($" Size of byte = {typeof(sbyte)}");
            Console.WriteLine($" Size of byte = {a is sbyte}");
            c = (sbyte)sh;
            Console.WriteLine("sbyte = short " + c + " = " + sh);
            c = (sbyte)ch;
            Console.WriteLine("sbyte = char " + c + " = " + ch);
            c = (sbyte)l;
            Console.WriteLine("sbyte = long " + c + " = " + l);
            c = (sbyte)f;
            Console.WriteLine("sbyte = float " + c + " = " + f);
            c = (sbyte)d;
            Console.WriteLine("sbyte = double " + c + " = " + d);

            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(sbyte)}");
            Console.WriteLine($" Size of byte = {sizeof(sbyte)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a » b = {a >> b}");
            Console.WriteLine($" a « b = {a << b}");
            Console.WriteLine($" a «= b = {a <<= b}");
            Console.WriteLine($" a »= b = {a >>= b}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestByte()
        {
            byte a = 5, b = 2, c;

            Console.WriteLine("**** byte *****");

            c = (byte)(a + b);
            Console.WriteLine(a + " + " + b + " = " + c);

            c = (byte)(a - b);
            Console.WriteLine(a + " - " + b + " = " + c);

            c = (byte)(a * b);
            Console.WriteLine(a + " * " + b + " = " + c);

            c = (byte)(a / b);
            Console.WriteLine(a + " / " + b + " = " + c);

            c = (byte)(a % b);
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = (byte)(a & b);
            Console.WriteLine(a + " & " + b + " = " + c);

            c = (byte)(a | b);
            Console.WriteLine(a + " | " + b + " = " + c);

            c = (byte)(a ^ b);
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = (byte)(~a);
            Console.WriteLine("~" + a + " = " + c);

            c = (byte)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (byte)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            c = (byte)(a << 1);
            c = (byte)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));
            Console.WriteLine("c >>= " + a + " c = " + (c >>= a));
            Console.WriteLine("c <<= " + a + " c = " + (c <<= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;


            c = (byte)sh;
            Console.WriteLine("byte = short " + c + " = " + sh);
            c = (byte)ch;
            Console.WriteLine("byte = char " + c + " = " + ch);
            c = (byte)l;
            Console.WriteLine("byte = long " + c + " = " + l);
            c = (byte)f;
            Console.WriteLine("byte = float " + c + " = " + f);
            c = (byte)d;
            Console.WriteLine("byte = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(byte)}");
            Console.WriteLine($" Size of byte = {sizeof(byte)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a » b = {a >> b}");
            Console.WriteLine($" a « b = {a << b}");
            Console.WriteLine($" a «= b = {a <<= b}");
            Console.WriteLine($" a »= b = {a >>= b}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestShort()
        {
            short a = 5, b = 2, c;


            Console.WriteLine("**** Short *****");
            Console.WriteLine($" Size of byte = {typeof(short)}");
            Console.WriteLine($" Size of byte = {a is short}");

            c = (short)(a + b);
            Console.WriteLine(a + " + " + b + " = " + c);

            c = (short)(a - b);
            Console.WriteLine(a + " - " + b + " = " + c);

            c = (short)(a * b);
            Console.WriteLine(a + " * " + b + " = " + c);

            c = (short)(a / b);
            Console.WriteLine(a + " / " + b + " = " + c);

            c = (short)(a % b);
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = (short)(a & b);
            Console.WriteLine(a + " & " + b + " = " + c);

            c = (short)(a | b);
            Console.WriteLine(a + " | " + b + " = " + c);

            c = (short)(a ^ b);
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = (short)(~a);
            Console.WriteLine("~" + a + " = " + c);

            c = (short)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (short)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = (short)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (short)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));
            Console.WriteLine("c >>= " + a + " c = " + (c >>= a));
            Console.WriteLine("c <<= " + a + " c = " + (c <<= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("short = byte " + c + " = " + bt);

            c = (short)ch;
            Console.WriteLine("short = char " + c + " = " + ch);
            c = (short)l;
            Console.WriteLine("short = long " + c + " = " + l);
            c = (short)f;
            Console.WriteLine("short = float " + c + " = " + f);
            c = (short)d;
            Console.WriteLine("short = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(short)}");
            Console.WriteLine($" Size of byte = {sizeof(short)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a » b = {a >> b}");
            Console.WriteLine($" a « b = {a << b}");
            Console.WriteLine($" a «= b = {a <<= b}");
            Console.WriteLine($" a »= b = {a >>= b}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestUShort()
        {
            ushort a = 5, b = 2, c;

            Console.WriteLine("**** Ushort *****");
            Console.WriteLine($" Size of byte = {typeof(ushort)}");
            Console.WriteLine($" Size of byte = {a is ushort}");

            c = (ushort)(a + b);
            Console.WriteLine(a + " + " + b + " = " + c);

            c = (ushort)(a - b);
            Console.WriteLine(a + " - " + b + " = " + c);

            c = (ushort)(a * b);
            Console.WriteLine(a + " * " + b + " = " + c);

            c = (ushort)(a / b);
            Console.WriteLine(a + " / " + b + " = " + c);

            c = (ushort)(a % b);
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = (ushort)(a & b);
            Console.WriteLine(a + " & " + b + " = " + c);

            c = (ushort)(a | b);
            Console.WriteLine(a + " | " + b + " = " + c);

            c = (ushort)(a ^ b);
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = (ushort)(~a);
            Console.WriteLine("~" + a + " = " + c);

            c = (ushort)(a >> 1);
            Console.WriteLine(a + " >> 1 = " + c);

            c = (ushort)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            c = (ushort)(a << 1);
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));
            Console.WriteLine("c >>= " + a + " c = " + (c >>= a));
            Console.WriteLine("c <<= " + a + " c = " + (c <<= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("ushort = byte " + c + " = " + bt);

            c = ch;
            Console.WriteLine("ushort = char " + c + " = " + ch);
            c = (ushort)l;
            Console.WriteLine("ushort = long " + c + " = " + l);
            c = (ushort)f;
            Console.WriteLine("ushort = float " + c + " = " + f);
            c = (ushort)d;
            Console.WriteLine("ushort = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(ushort)}");
            Console.WriteLine($" Size of byte = {sizeof(ushort)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a » b = {a >> b}");
            Console.WriteLine($" a « b = {a << b}");
            Console.WriteLine($" a «= b = {a <<= b}");
            Console.WriteLine($" a »= b = {a >>= b}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestInt()
        {
            int a = 5, b = 2, c;

            Console.WriteLine("**** Int *****");
            Console.WriteLine($" Size of byte = {typeof(int)}");
            Console.WriteLine($" Size of byte = {a is int}");

            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);

            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);

            c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);

            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);

            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));
            Console.WriteLine("c >>= " + a + " c = " + (c >>= a));
            Console.WriteLine("c <<= " + a + " c = " + (c <<= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("int = byte " + c + " = " + bt);
            c = sh;
            Console.WriteLine("int = short " + c + " = " + sh);
            c = ch;
            Console.WriteLine("int = char " + c + " = " + ch);
            c = (int)l;
            Console.WriteLine("int = long " + c + " = " + l);
            c = (int)f;
            Console.WriteLine("int = float " + c + " = " + f);
            c = (int)d;
            Console.WriteLine("int = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(int)}");
            Console.WriteLine($" Size of byte = {sizeof(int)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a » b = {a >> b}");
            Console.WriteLine($" a « b = {a << b}");
            Console.WriteLine($" a «= b = {a <<= b}");
            Console.WriteLine($" a »= b = {a >>= b}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestUInt()
        {
            uint a = 5, b = 2, c;

            Console.WriteLine("**** UInt *****");
            Console.WriteLine($" Size of byte = {typeof(int)}");
            Console.WriteLine($" Size of byte = {a is int}");

            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);

            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);

            c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);

            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);

            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("uint = byte " + c + " = " + bt);
            c = (uint)sh;
            Console.WriteLine("uint = short " + c + " = " + sh);
            c = ch;
            Console.WriteLine("uint = char " + c + " = " + ch);
            c = (uint)l;
            Console.WriteLine("uint = long " + c + " = " + l);
            c = (uint)f;
            Console.WriteLine("uint = float " + c + " = " + f);
            c = (uint)d;
            Console.WriteLine("uint = double " + c + " = " + d);

            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(uint)}");
            Console.WriteLine($" Size of byte = {sizeof(uint)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestLong()
        {
            long a = 5, b = 2, c;

            Console.WriteLine("**** long *****");

            Console.WriteLine($" Size of byte = {typeof(long)}");
            Console.WriteLine($" Size of byte = {a is long}");

            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);

            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);

            c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);

            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);

            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("long = byte " + c + " = " + bt);
            c = sh;
            Console.WriteLine("long = short " + c + " = " + sh);
            c = ch;
            Console.WriteLine("long = char " + c + " = " + ch);
            c = (long)l;
            Console.WriteLine("long = long " + c + " = " + l);
            c = (long)f;
            Console.WriteLine("long = float " + c + " = " + f);
            c = (long)d;
            Console.WriteLine("long = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;

            Console.WriteLine($" Default byte - {default(long)}");
            Console.WriteLine($" Size of byte = {sizeof(long)}");

            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestULong()
        {
            ulong a = 5, b = 2, c;

            Console.WriteLine("**** Ulong *****");

            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);

            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);

            c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);

            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);

            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("+" + a + " = " + +a);

            c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);



            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine("c |= " + a + " c = " + (c |= a));
            Console.WriteLine("c &= " + a + " c = " + (c &= a));
            Console.WriteLine("c ^= " + a + " c = " + (c ^= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("ulong = byte " + c + " = " + bt);
            c = (ulong)sh;
            Console.WriteLine("ulong = short " + c + " = " + sh);
            c = ch;
            Console.WriteLine("ulong = char " + c + " = " + ch);
            c = (ulong)l;
            Console.WriteLine("ulong = long " + c + " = " + l);
            c = (ulong)f;
            Console.WriteLine("ulong = float " + c + " = " + f);
            c = (ulong)d;
            Console.WriteLine("ulong = double " + c + " = " + d);
            a = 5;
            b = 2;
            c = 7;
            Console.WriteLine($" Default byte - {default(ulong)}");
            Console.WriteLine($" Default byte - {default(ulong)}");
            Console.WriteLine($" Size of byte = {typeof(ulong)}");
            Console.WriteLine($" Size of byte = {a is ulong}");
            Console.WriteLine($" Type of a - {a.GetTypeCode()}");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" a &= b = {a &= b}");
            Console.WriteLine($" a ^= b = {a ^= b}");

        }
        public static void TestChar()
        {
            Console.WriteLine("**** Char *****");

            char a, b;
            bool c;
            a = 'd';
            b = 'g';

            c = a == b;
            Console.WriteLine(a + " == " + b + " " + c.ToString());
            c = a > b;
            Console.WriteLine(a + " > " + b + " " + c.ToString());
            c = a < b;
            Console.WriteLine(a + " < " + b + " " + c.ToString());

            char chA = 'A';
            char ch1 = '1';
            string str = "test string";
            Console.WriteLine(chA.CompareTo('B'));
            Console.WriteLine(chA.Equals('A'));
            Console.WriteLine(Char.GetNumericValue(ch1));
            Console.WriteLine(Char.IsControl('\t'));
            Console.WriteLine(Char.IsDigit(ch1));
            Console.WriteLine(Char.IsLetter(','));
            Console.WriteLine(Char.IsLower('u'));
            Console.WriteLine(Char.IsNumber(ch1));
            Console.WriteLine(Char.IsPunctuation('.'));
            Console.WriteLine(Char.IsSeparator(str, 4));
            Console.WriteLine(Char.IsSymbol('+'));
            Console.WriteLine(Char.IsWhiteSpace(str, 4));
            Console.WriteLine(Char.Parse("S"));
            Console.WriteLine(Char.ToLower('M'));
            Console.WriteLine('x'.ToString());

            dynamic ValBool3 = null;
            char ValBool1 = '1';
            char ValBool2 = '2';
            Console.WriteLine($" Default byte - {default(A)}");
            // Console.WriteLine($" Size of byte = {sizeof(A)}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            //Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
        }
        public static void TestFloat()
        {
            float a = 5, b = 2, c;

            Console.WriteLine("**** float *****");
            Console.WriteLine($" Size of byte = {typeof(float)}");
            Console.WriteLine($" Size of byte = {a is float}");

            /* c = a + b;
             Console.WriteLine(a + " + " + b + " = " + c);

             c = a - b;
             Console.WriteLine(a + " - " + b + " = " + c);

             c = a * b;
             Console.WriteLine(a + " * " + b + " = " + c);

             c = a / b;
             Console.WriteLine(a + " / " + b + " = " + c);

             c = a % b;
             Console.WriteLine(a + " % " + b + " = " + c);*/

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            /*c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);*/

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("short = byte " + c + " = " + bt);

            c = (short)ch;
            Console.WriteLine("short = char " + c + " = " + ch);
            c = (short)l;
            Console.WriteLine("short = long " + c + " = " + l);
            c = (short)f;
            Console.WriteLine("short = float " + c + " = " + f);
            c = (short)d;
            Console.WriteLine("short = double " + c + " = " + d);

            dynamic ValBool3 = null;
            float ValBool1 = 21;
            float ValBool2 = 23;
            Console.WriteLine($" Default byte - {default(A)}");
            // Console.WriteLine($" Size of byte = {sizeof(A)}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            //Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            //Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            //Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            //Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            //Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            //Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            //Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            //Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            //Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
        }
        public static void TestDouble()
        {
            double a = 5, b = 2, c;

            Console.WriteLine("**** Double *****");
            Console.WriteLine($" Size of byte = {typeof(double)}");
            Console.WriteLine($" Size of byte = {a is double}");

            /* c = a + b;
             Console.WriteLine(a + " + " + b + " = " + c);

             c = a - b;
             Console.WriteLine(a + " - " + b + " = " + c);

             c = a * b;
             Console.WriteLine(a + " * " + b + " = " + c);

             c = a / b;
             Console.WriteLine(a + " / " + b + " = " + c);

             c = a % b;
             Console.WriteLine(a + " % " + b + " = " + c);*/

            a = 5;
            Console.WriteLine("a++ = " + a++);

            a = 5;
            Console.WriteLine("++" + a + "= " + ++a);

            a = 5;
            Console.WriteLine(a + "-- = " + a--);

            a = 5;
            Console.WriteLine("--" + a + " = " + --a);

            a = 5;
            Console.WriteLine("-" + a + " = " + -a);
            Console.WriteLine("+" + a + " = " + +a);

            /*c = a & b;
            Console.WriteLine(a + " & " + b + " = " + c);

            c = a | b;
            Console.WriteLine(a + " | " + b + " = " + c);

            c = a ^ b;
            Console.WriteLine(a + " ^ " + b + " = " + c);

            c = ~a;
            Console.WriteLine("~" + a + " = " + c);

            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);

            a = -5;
            c = a >> 1;
            Console.WriteLine(a + " >> 1 = " + c);

            c = a << 1;
            Console.WriteLine(a + " << 1 = " + c);*/

            a = 5;
            c = 7;
            Console.WriteLine("c = " + c);
            Console.WriteLine("c += " + a + " c = " + (c += a));
            Console.WriteLine("c -= " + a + " c = " + (c -= a));
            Console.WriteLine("c *= " + a + " c = " + (c *= a));
            Console.WriteLine("c /= " + a + " c = " + (c /= a));

            Console.WriteLine(c + " < " + a + ' ' + (c < a));
            Console.WriteLine(c + " > " + a + ' ' + (c > a));
            Console.WriteLine(c + " <= " + a + ' ' + (c <= a));
            Console.WriteLine(c + " >= " + a + ' ' + (c >= a));
            Console.WriteLine(c + " == " + a + ' ' + (c == a));
            Console.WriteLine(c + " != " + a + ' ' + (c != a));
            byte bt = 1;
            short sh = -32000;
            char ch = '\u0002';
            long l = 1000000000000000000l;
            float f = 1.9f;
            double d = 123456789.624;

            c = bt;
            Console.WriteLine("short = byte " + c + " = " + bt);

            c = (short)ch;
            Console.WriteLine("short = char " + c + " = " + ch);
            c = (short)l;
            Console.WriteLine("short = long " + c + " = " + l);
            c = (short)f;
            Console.WriteLine("short = float " + c + " = " + f);
            c = (short)d;
            Console.WriteLine("short = double " + c + " = " + d);

            dynamic ValBool3 = null;
            double ValBool1 = 2.3;
            double ValBool2 = 232;
            Console.WriteLine($" Default byte - {default(A)}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
        }
        public static void TestBool()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine("**** Boolean *****");
            Console.WriteLine($" Size of byte = {typeof(bool)}");
            Console.WriteLine($" Size of byte = {a is bool}");

            bool ValBool1 = true, ValBool2 = false;
            bool? ValBool3 = null;
            Console.WriteLine(" Bool operations: ");
            Console.WriteLine($" a = {ValBool1} b = {ValBool2}");
            Console.WriteLine(" a + b not supported");
            Console.WriteLine(" a - b not supported");
            Console.WriteLine(" a / b not supported");
            Console.WriteLine(" a * b not supported");
            Console.WriteLine(" a % b not supported");
            Console.WriteLine(" a++ not supported");
            Console.WriteLine(" a— not supported");
            Console.WriteLine(" ++a not supported");
            Console.WriteLine(" —a = not supported");
            Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");
            Console.WriteLine(" Bool to byte not supported");
            Console.WriteLine(" Bool to short not supported");
            Console.WriteLine(" Bool to int not supported");
            Console.WriteLine(" Bool to long not supported");
            Console.WriteLine(" Bool to float not supported");
            Console.WriteLine(" Bool to double not supported");
            Console.WriteLine(" Bool to decimal not supported");
            Console.WriteLine(" Bool to char not supported");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine(" a <= b not supported");
            Console.WriteLine(" a >= b not supported");
            Console.WriteLine(" a < b not supported");
            Console.WriteLine(" a > b not supported");
            Console.WriteLine(" a » b not supported");
            Console.WriteLine(" a « b not supported");
            Console.WriteLine(" ~a not supported");
            Console.WriteLine(" a += b not supported");
            Console.WriteLine(" a -= b not supported");
            Console.WriteLine(" a /= b not supported");
            Console.WriteLine(" a *= b not supported");
            Console.WriteLine(" a %= b not supported");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            Console.WriteLine($" a «= b not supported");
            Console.WriteLine($" a »= b not supported");
            Console.WriteLine($" Size of byte = {sizeof(bool)}");
            Console.WriteLine($" Default byte - {default(bool)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a not supported");
            Console.WriteLine($" +a not supported");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = not supported");
        }
        public static void TestDecimal()
        {
            Console.WriteLine("**** Dynamic *****");

            decimal ValBool1 = 5, ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(decimal)}");
            Console.WriteLine($" Size of byte = {ValBool1 is decimal}");
            Console.WriteLine(" Bool operations: ");
            Console.WriteLine($" a = {ValBool1} b = {ValBool2}");
            Console.WriteLine($" a + b = {ValBool1 + ValBool2}");
            Console.WriteLine($" a - b = {ValBool1 = ValBool2}");
            Console.WriteLine($" a / b = {ValBool1 / ValBool2}");
            Console.WriteLine($" a * b = {ValBool1 * ValBool2}");
            Console.WriteLine($" a % b = {ValBool1 % ValBool2}");
            Console.WriteLine($" a++ = {ValBool1++}");
            Console.WriteLine($" a— = {ValBool1--}");
            Console.WriteLine($" ++a = {++ValBool1}");
            Console.WriteLine($" —a = {--ValBool1}");
            //Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            //Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            //Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            //Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            //Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            //Console.WriteLine($" !a = {!ValBool1}");
            Console.WriteLine($" Byte to short - {(short)(ValByte1)}");
            Console.WriteLine($" Byte to int - {(int)ValByte1}");
            Console.WriteLine($" Byte to long - {(long)ValByte1}");
            Console.WriteLine($" Byte to float - {(float)ValByte1}");
            Console.WriteLine($" Byte to double - {(double)ValByte1}");
            Console.WriteLine($" Byte to decimal - {(decimal)ValByte1}");
            Console.WriteLine($" Byte to char - {(char)ValByte1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte = {sizeof(dynamic)}");
            Console.WriteLine($" Default byte - {default(dynamic)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestString()
        {
            Console.WriteLine("**** String *****");

            string a = "BN";
            string b = "TU";

            dynamic res;
            Console.WriteLine($" Size of byte = {typeof(string)}");
            Console.WriteLine($" Size of byte = {a is string}");
            res = a == b;
            Console.WriteLine(a + " == " + b + " " + res.ToString());
            res = a + b;
            Console.WriteLine(a + " == " + b + " " + res);

            string firstname;
            string lastname;


            firstname = "Steven Clark";
            lastname = "Clark";

            Console.WriteLine("clone ", firstname.Clone());
            Console.WriteLine("Compare two string value and returns 0 for true and 1 for fals.e", firstname.CompareTo(lastname));

            Console.WriteLine("Check whether specified value exists or not in string.", firstname.Contains("ven"));

            Console.WriteLine("Check whether specified value is the last character of string.", firstname.EndsWith("n"));
            Console.WriteLine("Compare two string and returns true and false.", firstname.Equals(lastname));


            Console.WriteLine("Returns HashCode of String.", firstname.GetHashCode());

            Console.WriteLine("Returns type of string.", firstname.GetType());

            Console.WriteLine("Returns type of string.", firstname.GetTypeCode());

            Console.WriteLine("Returns the first index position of specified value.", firstname.IndexOf("e"));

            Console.WriteLine("Covert string into lower case.", firstname.ToLower());

            Console.WriteLine("Convert string into Upper case.", firstname.ToUpper());

            Console.WriteLine("Insert substring into string.", firstname.Insert(0, "Hello"));

            Console.WriteLine("Check Whether string is in Unicode normalization.", firstname.IsNormalized());

            Console.WriteLine("Returns the last index position of specified value.", firstname.LastIndexOf("e"));

            Console.WriteLine("Returns the Length of String.", firstname.Length);

            Console.WriteLine("/Deletes all the characters from begining to specified index.", firstname.Remove(5));

            Console.WriteLine(" Replace the character.", firstname.Replace('e', 'i'));

            string[] split = firstname.Split(new char[] { 'e' });


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine("Check wheter first character of string is same as specified value.", firstname.StartsWith("S"));

            Console.WriteLine("Returns substring.", firstname.Substring(2, 5));

            Console.WriteLine("Converts an string into char array.", firstname.ToCharArray());

            Console.WriteLine("Trim.", firstname.Trim());


            string ValBool3 = null;
            string ValBool1 = "23";
            string ValBool2 = "231";
            Console.WriteLine($" Default byte - {default(string)}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
        }
        public static void TestObject()
        {
            Console.WriteLine("**** Object *****");

            A p1 = new A(54);
            var p3 = p1;
            bool c;
            Console.WriteLine($" Size of byte = {typeof(A)}");
            Console.WriteLine($" Size of byte = {p1 is A}");

            c = p1 == p3;
            Console.WriteLine("p1 == p3 " + c.ToString());

            Console.WriteLine(Object.ReferenceEquals(p1, p3));
            Console.WriteLine(Object.Equals(p1, p3));
            Console.WriteLine(Object.ReferenceEquals(p1, p3));
            Console.WriteLine($"p1's value is: {p1.ToString()}");
        }
        public static void TestDynamic()
        {
            Console.WriteLine("**** Dynamic *****");

            dynamic ValBool1 = 5, ValBool2 = 6;


            Console.WriteLine(" Bool operations: ");
            Console.WriteLine($" a = {ValBool1} b = {ValBool2}");
            Console.WriteLine($" a + b = {ValBool1 + ValBool2}");
            Console.WriteLine($" a - b = {ValBool1 = ValBool2}");
            Console.WriteLine($" a / b = {ValBool1 / ValBool2}");
            Console.WriteLine($" a * b = {ValBool1 * ValBool2}");
            Console.WriteLine($" a % b = {ValBool1 % ValBool2}");
            Console.WriteLine($" a++ = {ValBool1++}");
            Console.WriteLine($" a— = {ValBool1--}");
            Console.WriteLine($" ++a = {++ValBool1}");
            Console.WriteLine($" —a = {--ValBool1}");
            Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            ValBool1 = true;
            ValBool2 = false;
            Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");
            Console.WriteLine($" Byte to short - not supported");
            Console.WriteLine($" Byte to int - not supported");
            Console.WriteLine($" Byte to long - not supported");
            Console.WriteLine($" Byte to float - not supported");
            Console.WriteLine($" Byte to double - not supported");
            Console.WriteLine($" Byte to decimal - not supported");
            Console.WriteLine($" Byte to char - not supported");
            ValBool1 = 5;
            ValBool2 = 6;
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte not supported");

            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = not supported");
            Console.WriteLine($" c = null, c ??= b = not supported");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");

            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");


            Console.WriteLine($" Default byte - {default(dynamic)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
        }
    }   
}
