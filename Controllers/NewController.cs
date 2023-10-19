using Microsoft.AspNetCore.Mvc;

namespace Ionescu_Alex_Lab1.Controllers
{
    public class NewController : Microsoft.AspNetCore.Mvc.Controller
    {

        public string Index()
        {
            return "Wellcome";
        }

        public string Greeting()
        {
            return "Hello!";
        }

        public string ParameterFunc(string name, int age)
        {
            return "Hello, " + name + ", " + age.ToString();
        }
    }
}
