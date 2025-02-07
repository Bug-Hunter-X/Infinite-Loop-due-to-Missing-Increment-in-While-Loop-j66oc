public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int i = 0;
        while (i < 10)
        {
            //This is the bug line.  The variable i will never be greater than 10 because it is not incremented in the loop.
        }
    }
}