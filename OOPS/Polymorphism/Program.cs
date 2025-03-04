public class MultipleAdds
{
    public void  Addition(int a, int b, int c)
    {
        int SumOfThreePara =   a + b + c;
        Console.WriteLine(SumOfThreePara);
    }
    public void Addition(int a, int b)
    {
        int SumOfTwoPara = a + b;
        Console.WriteLine(SumOfTwoPara);    

    }
}
class Program
{
    static void Main(string[] args)
    {
        MultipleAdds additionObj   = new MultipleAdds();
        additionObj.Addition(45, 34, 67);
        additionObj.Addition(23, 34);
        additionObj.Addition(5, 4, 6);


    }
}


