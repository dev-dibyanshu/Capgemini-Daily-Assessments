using System;

public class VehicleRentalEstimator
{
    public double EstimateCost(int days, int distance)
    {
        return days * 50 + distance * 0.2;
    }

    public double EstimateCost(int days, int distance, bool withDriver)
    {
        return days * 100 + distance * 0.5 + (withDriver ? 200 : 0);
    }

    public double EstimateCost(int days, bool includeInsurance)
    {
        return includeInsurance ? days * 20 + 50 : days * 20;
    }
}