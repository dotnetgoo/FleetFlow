using FleetFlow.Service.Models.Insights;

namespace FleetFlow.Service.Comparers;

public class SumOfSellsComparer : IComparer<TopProductModel>
{
    public int Compare(TopProductModel class1, TopProductModel class2)
    {
        if (class1.SumOfSells < class2.SumOfSells)
        {
            return -1;
        }
        else if (class1.SumOfSells > class2.SumOfSells)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}