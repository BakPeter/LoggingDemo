using log4net;

namespace ConsoleApp
{
    public class Person
    {
        private static int s_counter = 0;
        private ILog Logger { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int Id { set; get; }

        public Person(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Id = ++s_counter;

            Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //_looger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }

    public override string ToString()
        {
            //return this.GetPropertiesAsText().ToString();
            var retVal = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            Logger.Info(retVal);

            return retVal;
        }
    }
}
