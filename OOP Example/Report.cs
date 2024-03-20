namespace FundamentalAPI.OOP_Example
{
    public abstract class Report
    {
        public abstract void ExportReport(string category);
        public abstract int ExportReport(string category, int limit);

        public void RegularMethod()
        {

        }

    }
}
