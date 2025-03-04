class Choclate
{
    public void Display()
    {
        Console.WriteLine("Dispaly Details of project");
    }
    public virtual void Show()
    {
        Console.WriteLine("Show the method details of Choclate class");
    }
}
class Cadbury : Choclate
{
    public void See()
    {
        Console.WriteLine("See the Details of Cadbury class");
    }
    public override void Show()
    {
        Console.WriteLine("override the show method");
    }
    public void CallBaseMethod()
    {
        base.Show();
    }
}

class Britania
{
    public static void Main()
    {
        Cadbury cadburyObj = new Cadbury();
        cadburyObj.Show();
        cadburyObj.See();
        cadburyObj.CallBaseMethod();
       // base.Show();
    }
}