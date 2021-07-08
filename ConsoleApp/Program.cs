using System;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        static void Main(string[] args)
        {
            log.Info("this is info message");
            log.Debug("this is debug message ");
            log.Error("this is error message");
            //new Person("csccspeter", "fcwefbak", 6464, log).ToString();
            //new Person("peter", "bak", 40, log).ToString();
            //new Person("eli", "cohem", 200, log).ToString();
            //new Person("pecscter", "bcsscak", 65440, log).ToString();
            //new Person("csccspeter", "fcwefbak", 6464, log).ToString();

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
    //class Person
    //{
    //    private static int s_counter = 0;
    //    private ILog Logger { get; set; }
    //    public string LastName { get; set; }
    //    public string FirstName { get; set; }
    //    public int Age { get; set; }
    //    public int Id { set; get; }

    //    public Person(string lastName, string firstName, int age, ILog logger)
    //    {
    //        LastName = lastName;
    //        FirstName = firstName;
    //        Age = age;
    //        Logger = logger;
    //        Id = ++s_counter;
    //        //_looger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    //    }

    //    public override string ToString()
    //    {
    //        //return this.GetPropertiesAsText().ToString();
    //        var retVal = Newtonsoft.Json.JsonConvert.SerializeObject(this);
    //        Logger.Info(retVal);

    //        return retVal;
    //    }
    //}
}
