using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Tip
{
    private double mealAmount;
    private double tipPercent;
    private const double TAXPERCENT = .101;
    public Tip(double amount, double tipPerc)
    {
        mealAmount = amount;
        tipPercent = tipPerc;
    }

    public double CalculateTax()
    {
        return mealAmount * TAXPERCENT;
    }

    public double CalculateTip()
    {
        return mealAmount * tipPercent;
    }

    public double Total()
    {
        return mealAmount = CalculateTax() + CalculateTip();
    }
}