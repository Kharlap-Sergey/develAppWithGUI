using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    class A
    {
        int a;
        public A(int x)
        {
            this.a = x;
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
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

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        public static void TestSByte()
        {
            Console.WriteLine("**** Sbyte *****");
            sbyte ValBool1 = 5;
            sbyte ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(sbyte)}");
            Console.WriteLine($" Size of byte = {ValBool1 is sbyte}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}"); */
             Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(sbyte)}");
            Console.WriteLine($" Default byte - {default(sbyte)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestByte()
        {
            byte a = 5, b = 2, c;

            Console.WriteLine("**** byte *****");
            byte ValBool1 = 5;
            byte ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(byte)}");
            Console.WriteLine($" Size of byte = {ValBool1 is byte}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}"); */
             Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(byte)}");
            Console.WriteLine($" Default byte - {default(byte)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");

        }
        public static void TestShort()
        {
            short a = 5, b = 2, c;


            Console.WriteLine("**** Short *****");
            short ValBool1 = 5;
            short ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(short)}");
            Console.WriteLine($" Size of byte = {ValBool1 is short}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}"); */
             Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(short)}");
            Console.WriteLine($" Default byte - {default(short)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestUShort()
        {
            ushort a = 5, b = 2, c;

            Console.WriteLine("**** Ushort *****");
            ushort ValBool1 = 5;
            ushort ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(ushort)}");
            Console.WriteLine($" Size of byte = {ValBool1 is ushort}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}"); */
             Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(ushort)}");
            Console.WriteLine($" Default byte - {default(ushort)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestInt()
        {
            int a = 5, b = 2, c;

            Console.WriteLine("**** Int *****");
            int ValBool1 = 5;
            int ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(int)}");
            Console.WriteLine($" Size of byte = {ValBool1 is int}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(int)}");
            Console.WriteLine($" Default byte - {default(int)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestUInt()
        {
            uint ValBool1 = 5;
            uint ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(uint)}");
            Console.WriteLine($" Size of byte = {ValBool1 is uint}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            //Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            //Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            //Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            //Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte = {sizeof(uint)}");
            Console.WriteLine($" Default byte - {default(uint)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestLong()
        {
            Console.WriteLine("**** long *****");

            long ValBool1 = 5;
            long ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(long)}");
            Console.WriteLine($" Size of byte = {ValBool1 is long}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            //Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            //Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            //Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            //Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte = {sizeof(long)}");
            Console.WriteLine($" Default byte - {default(long)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestULong()
        {
            Console.WriteLine("**** Ulong *****");

            ulong ValBool1 = 5;
            ulong ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(ulong)}");
            Console.WriteLine($" Size of byte = {ValBool1 is ulong}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            /*Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");*/
            Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            /*Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");*/
            Console.WriteLine($" Size of byte = {sizeof(ulong)}");
            Console.WriteLine($" Default byte - {default(ulong)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            //Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestChar()
        {
            Console.WriteLine("**** Char *****");

            char ValBool1 = 'a';
            char ValBool2 = 'b';
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(char)}");
            Console.WriteLine($" Size of byte = {ValBool1 is char}");
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
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            /*Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
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
            Console.WriteLine($" Size of byte = {sizeof(char)}");
            Console.WriteLine($" Default byte - {default(char)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestFloat()
        {
            Console.WriteLine("**** float *****");
            float ValBool1 = 5;
            float ValBool2 = 6;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(float)}");
            Console.WriteLine($" Size of byte = {ValBool1 is float}");
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
            /*Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" Byte to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            /*Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");*/
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            /*Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");*/
            Console.WriteLine($" Size of byte = {sizeof(float)}");
            Console.WriteLine($" Default byte - {default(float)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestDouble()
        {
            Console.WriteLine("**** Double *****");
            double ValBool1 = 1;
            double ValBool2 = 2;
            dynamic ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(double)}");
            Console.WriteLine($" Size of byte = {ValBool1 is double}");
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
            /*Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");*/
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            /*Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            Console.WriteLine($" ~a = {~ValBool1}");*/
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            /*Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");*/
            Console.WriteLine($" Size of byte = {sizeof(double)}");
            Console.WriteLine($" Default byte - {default(double)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            Console.WriteLine($" -a = {-ValBool1}");
            Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
        }
        public static void TestBool()
        {
            bool a = true;
            bool b = false;
            bool ValBool1 = true, ValBool2 = false;
            bool? ValBool3 = null;
            Console.WriteLine($" Size of byte = {typeof(bool)}");
            Console.WriteLine($" Size of byte = {ValBool1 is bool}");
            Console.WriteLine(" Bool operations: ");
            Console.WriteLine($" a = {ValBool1} b = {ValBool2}");
            //Console.WriteLine($" a + b = {ValBool1 + ValBool2}");
            Console.WriteLine($" a - b = {ValBool1 = ValBool2}");
            //Console.WriteLine($" a / b = {ValBool1 / ValBool2}");
            //Console.WriteLine($" a * b = {ValBool1 * ValBool2}");
            //Console.WriteLine($" a % b = {ValBool1 % ValBool2}");
            //Console.WriteLine($" a++ = {ValBool1++}");
            //Console.WriteLine($" a— = {ValBool1--}");
            //Console.WriteLine($" ++a = {++ValBool1}");
            //Console.WriteLine($" —a = {--ValBool1}");
            Console.WriteLine($" a | b = {ValBool1 | ValBool2}");
            Console.WriteLine($" a & b = {ValBool1 & ValBool2}");
            Console.WriteLine($" a ^ b = {ValBool1 ^ ValBool2}");
            Console.WriteLine($" a || b = {ValBool1 || ValBool2}");
            Console.WriteLine($" a && b = {ValBool1 && ValBool2}");
            Console.WriteLine($" !a = {!ValBool1}");
            /*Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");*/
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            //Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            //Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            //Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            //Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            //Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            //Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            //Console.WriteLine($" ~a = {~ValBool1}");
            //Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            //Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            //Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            //Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            //Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            //Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            //Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte = {sizeof(bool)}");
            Console.WriteLine($" Default byte - {default(bool)}");
            Console.WriteLine($" Type of a - {ValBool1.GetTypeCode()}");
            Console.WriteLine($" a==b? 1 : 2 - {(ValBool1 == ValBool2 ? 1 : 2)}");
            Console.WriteLine($" a = b, a = {ValBool1 = ValBool2}");
            //Console.WriteLine($" -a = {-ValBool1}");
            //Console.WriteLine($" +a = {+ValBool1}");
            Console.WriteLine($" c = null, c ?? b = {ValBool3 ?? ValBool1}");
            Console.WriteLine($" c = null, c ??= b = {ValBool3 ??= ValBool1}");
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
            Console.WriteLine($" to short - {(short)(ValBool1)}");
            Console.WriteLine($" to int - {(int)ValBool1}");
            Console.WriteLine($" to long - {(long)ValBool1}");
            Console.WriteLine($" to float - {(float)ValBool1}");
            Console.WriteLine($" to double - {(double)ValBool1}");
            Console.WriteLine($" to decimal - {(decimal)ValBool1}");
            Console.WriteLine($" to char - {(char)ValBool1}");
            Console.WriteLine($" a == b = {ValBool1 == ValBool2}");
            Console.WriteLine($" a != b = {ValBool1 != ValBool2}");
            Console.WriteLine($" a <= b = {ValBool1 <= ValBool2}");
            Console.WriteLine($" a >= b = {ValBool1 >= ValBool2}");
            Console.WriteLine($" a < b = {ValBool1 < ValBool2}");
            Console.WriteLine($" a > b = {ValBool1 > ValBool2}");
            //Console.WriteLine($" a » b = {ValBool1 >> ValBool2}");
            //Console.WriteLine($" a « b = {ValBool1 << ValBool2}");
            //Console.WriteLine($" ~a = {~ValBool1}");
            Console.WriteLine($" a += b = {ValBool1 += ValBool2}");
            Console.WriteLine($" a -= b = {ValBool1 -= ValBool2}");
            Console.WriteLine($" a /= b = {ValBool1 /= ValBool2}");
            Console.WriteLine($" a *= b = {ValBool1 *= ValBool2}");
            Console.WriteLine($" a %= = {ValBool1 %= ValBool2}");
            //Console.WriteLine($" a |= b = {ValBool1 |= ValBool2}");
            //Console.WriteLine($" a &= b = {ValBool1 &= ValBool2}");
            //Console.WriteLine($" a ^= b = {ValBool1 ^= ValBool2}");
            //Console.WriteLine($" a «= b = {ValBool1 <<= ValBool2}");
            //Console.WriteLine($" a »= b = {ValBool1 >>= ValBool2}");
            Console.WriteLine($" Size of byte = {sizeof(decimal)}");
            Console.WriteLine($" Default byte - {default(decimal)}");
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
