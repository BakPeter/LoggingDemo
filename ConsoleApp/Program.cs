using System;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly log4net.ILog log = LogHelper.GetLogger();
        static void Main(string[] args)
        {
            log.Info("this is Info message");
            log.Debug("this is Debug message ");
            log.Warn("this is Error message");

            var n = 0;
            try
            {
                var x = 10 / n;
            }
            catch(DivideByZeroException ex)
            {
                log.Error("divided bt 0", ex);
            }

            for (int i = 0; i < 5; i++)
            {
                log4net.GlobalContext.Properties["Counter"] = i;
                log.Fatal($"#i = {i} this is Fatal messages");
            }

            Counter j = new Counter();
            log4net.GlobalContext.Properties["Counter"] = j;
            for (j.LoopCounter = 0;  j.LoopCounter  < 5; j.LoopCounter++)
            {
                log.Fatal("this is Fatal messages, j type");
            }


            new Person("ththdgrg", "htth", 6464).ToString();
            new Person("fegfe", "efef", 40).ToString();
            new Person("eli", "cohem", 200).ToString();
            new Person("mkumu", "mmumu", 65440).ToString();
            new Person("hrthtrh", "fcwergrghfbak", 6464).ToString();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        //public static int Sum(params int[] nums)
        //{
        //    int retVal = 0;
        //    foreach (var num in nums)
        //    {
        //        retVal += num;
        //    }

        //    return retVal;
        //}
    }
}
