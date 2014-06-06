public class CodeFile1 : Nancy.NancyModule
{
    public CodeFile1()
    {
        Get["/"] = _ => "Hello World!";
        Get["/abc"] = _ => "abc!";
		Get["/tables"] = _ => "list tables!";
    }
}