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
        //string query1 = "update employee_payroll set Gender = 'M' where id in (1,4);\r\nupdate employee_payroll set Gender = 'F' where id between 2 and 3;";
        //Payroll_Service_Operation.Queryexecte(query1);
        Employee employee = new Employee()
        {
            Name = "a",
            City = "b",
            Address = "c"

        };

        Employee employee1 = new Employee()
        {
            EmpId = 3,
            Name = "updatedName",
            City = "UpdatedCity",
            Address = "UpdatedAddress"

        };
        EmployeeOperation operation = new EmployeeOperation();
        operation.AddEmployee(employee);
        operation.exuctedorNot(operation.AddEmployee(employee));
        operation.exuctedorNot(operation.UpdateEmployee(employee1));
        operation.DisplayAllData();
    }

}

