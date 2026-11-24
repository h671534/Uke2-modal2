namespace SpaceAcademy;

public static class FuelCalculator
{
    public static int Calculate(int crewCount, int days) //person[0-20]  day[0-30]   Calcu[0-30]
    {

        // if(crewCount > 20 & days > 30)
        // {
        //     return 
        // }
        return crewCount * days * 3; //
    }
}
