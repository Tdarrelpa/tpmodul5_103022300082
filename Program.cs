// See https://aka.ms/new-console-template for more information
using CobaHaloGeneric;
using CobaDataGeneric;
public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Darrel");

        DataGeneric<int> nilai = new DataGeneric<int>(100);
        DataGeneric<double> IPK = new DataGeneric<double>(3.6);
        DataGeneric<string> dataString = new DataGeneric<string>("Darrel");
        nilai.PrintData();
        IPK.PrintData();
        dataString.PrintData();
    }
}