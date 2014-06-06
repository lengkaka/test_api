public class HelloWorld : Nancy.NancyModule
{
    public HelloWorld()
    {
        Get["/"] = _ => "Hello World!";
    }
}