using FleetFlow.Service.Models.Insights;

public class SumOfOrdersComparer : IComparer<TopUserModel>
{
    public int Compare(TopUserModel class1, TopUserModel class2)
    {
        if (class1.SumOfAllOrders < class2.SumOfAllOrders)
        {
            return -1;
        }
        else if (class1.SumOfAllOrders > class2.SumOfAllOrders)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}