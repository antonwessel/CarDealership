namespace ClassLibrary.Core.Models;

public class Car
{
    public string Carname { get; set; }
    public string Carmodel { get; set; }
    public string Cartype { get; set; }
    public string Carcolor { get; set; }

    public Car(string carname, string carmodel, string cartype, string carcolor)
    {
        Carname = carname;
        Carmodel = carmodel;
        Cartype = cartype;
        Carcolor = carcolor;
    }
}
