using System;

namespace MauiAppCSharpBasic.Classes;

public class Car
{
    public string Model;
    public string color;
    public double speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate;  // xxx Mile per Liter

    public Car(string Model, double speed, double Fuel)
    {
        this.Model = Model;
        this.speed = speed;
        this.Fuel = Fuel;
    }

    public void Run(double Mile)
    {
        //this.TotalMile = this.TotalMile + Mile;
        this.TotalMile += Mile;
        var use_fuel = Mile*UseFuelRate;
        this.Fuel = this.Fuel - use_fuel;
    }

    public uint TimeUseForRun(double Mile)
    {
    var TimeUse=Mile/speed;
    this.Run(Mile);
    return Convert.ToUInt16(TimeUse);
    }


    public string ShowInfo()
    {
        var Info = $"Model : {this.Model} \nTotal.Mile : {this.TotalMile} \nFuel :{this.Fuel}";
        return Info;
    }

    public static implicit operator string(Car v)
    {
        throw new NotImplementedException();
    }
}
