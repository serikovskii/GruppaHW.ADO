using HW.Gruppa.ADO.DataAccess;

namespace HW.Gruppa.ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            dataService.CreateTable();
        }
    }
}
