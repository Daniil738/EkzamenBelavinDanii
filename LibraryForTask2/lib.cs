namespace LibraryForTask2;

public class lib
{
    public static double spend(double distance_kilometr, bool movers)
    {
        int movers_spend = 0;
        if (movers == true)
        {
            movers_spend = 15000;
        }
        return (distance_kilometr * 55) + movers_spend;
    }
}