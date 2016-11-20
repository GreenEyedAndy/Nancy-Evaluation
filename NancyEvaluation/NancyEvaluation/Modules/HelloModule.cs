using Nancy;

namespace NancyEvaluation.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/hello"] = parameters => "Hello World";
        }
    }
}