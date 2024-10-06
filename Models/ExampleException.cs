namespace PMC;

public class ExampleException
{

    public void Method1()
    {
        Method2();
    }

    public void Method2()
    {
        try{
            Method3();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Excepition fix:" + ex.StackTrace);
        }
    }

    public void Method3()
    {
        Method4();
    }

    public void Method4()
    {
        throw new Exception("Occurred a exception");
    }

}

