using Nancy;
using NancyEvaluation.model;

namespace NancyEvaluation.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            var model = new WelcomeModel { Name = "Andy" };
            Get["/"] = parameters => View["index.html", model];
        }
    }
}