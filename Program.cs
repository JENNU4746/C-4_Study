using System;

namespace C_4_Study
{
    class CSVar
    {
        //필드(전역변수)
        int globalV;
        const int MAX = 1024;

        public void Method()
        {
            //로컬 변수
            int localV = MAX;//로컬 변수는 할당 필수

            PrintC(localV);
            PrintC(globalV);
        }

        private void PrintC(int num)
        {
            Console.WriteLine(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CSVar obj = new CSVar();
            obj.Method();
        }
    }
}
