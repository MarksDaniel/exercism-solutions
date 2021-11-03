using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed) {
            case 10: return 0.77; 
            case 9: return 0.8;
            case >= 5: return 0.9; 
            case >= 1: return 1.0;
            default: return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) (ProductionRatePerHour(speed) / 60);
    }
}
