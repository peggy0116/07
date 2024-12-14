using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHomeWork01();
            MyHomeWork02();
        }
        static void MyHomeWork01()
        {
            int[] Integer = new int[10];
            float[] FloatPoint = new float[8];
            double[] DoublePrecisione = new double[4];
            string[] strings=new string[5];
            double sum = 0;
            Console.WriteLine("請輸入10個整數:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位");
                Integer[i] = int.Parse(Console.ReadLine());
                sum += Integer[i];
            }
            Console.WriteLine("平均分數為:" + (sum/ 10).ToString());
            Console.WriteLine("請輸入8個小數:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位");
                FloatPoint[i] = float.Parse(Console.ReadLine());
                sum += FloatPoint[i];
            }
            Console.WriteLine("平均分數為:" + (sum / 8).ToString());
            Console.WriteLine("請輸入4個任意數:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位");
                DoublePrecisione[i] = double.Parse(Console.ReadLine());
                sum += DoublePrecisione[i];
            }
            Console.WriteLine("平均分數為:" + (sum / 4).ToString());
            Console.WriteLine("請輸入5個詞:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位");
                strings[i] = Console.ReadLine();
            }
        }
        static void MyHomeWork02()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            float[] floatArray = {1.2f,2.3f,3.4f,4.5f,5.6f};
            double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 };
            string[] stringArray = { "王小明, 陳大明, 李小英, 張小美, 陳不良" };
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray);
                sum += intArray[i];
            }
            Console.WriteLine("平均分數為:" + (sum / 10));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(floatArray);
               sum += floatArray[i];
            }
            Console.WriteLine("平均分數為:" + (sum / 5));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(doubleArray);
                sum += doubleArray[i];
            }
            Console.WriteLine("平均分數為:" + (sum / 5));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stringArray);
            }

        }
    }
}
