using Payroll_Service_ADO_database;

internal class Program
{
    public static void Main(string[] args)
    {
        //Payroll_Service_Operation.CreateDatabase();
        //Payroll_Service_Operation.CreateTable();
        //Payroll_Service_Operation.InsertDatebase();
        //Payroll_Service_Operation.ReadFromDatabase();
        //Payroll_Service_Operation.RetriveBetweenDatebase();
        string query1 = "update employee_payroll set Gender = 'M' where id in (1,4);\r\nupdate employee_payroll set Gender = 'F' where id between 2 and 3;";
        Payroll_Service_Operation.Queryexecte(query1);
    }

}

