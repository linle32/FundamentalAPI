using System.Security.Cryptography;

namespace FundamentalAPI.OOP_Example
{
    // regular clas 
    // abstract class 
    // dependency injection
    // unit test
    public class Something : Report, IStudentService, IService2
    {
        public override void ExportReport(string category)
        {
           
        }

        public override int ExportReport(string category, int limit)
        {
            throw new NotImplementedException();
        }

        public void ExportReport2(string category)
        {
            throw new NotImplementedException();
        }

        public void ExportReport2313(string category)
        {
            throw new NotImplementedException();
        }

        public int ExportReport3232(string category)
        {
            throw new NotImplementedException();
        }
    }
}
