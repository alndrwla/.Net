using ConcepsPDO;

Console.WriteLine("PDO Concepts!");

Employee employee1 = new BaseCommissionEmployee()
{
    Id = 121,
    FirstName = "John",
    LastName = "Doe",
    BirthDate = new Date(1990, 1, 1),
    HiringDate = new Date(2018, 1, 1),
    IsActive = true,
    CommissionPercentaje = 0.015F,
    Sales = 1000,
    Base = 100,
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    payroll += employee.GetValueToPay();
}

Invoice invoice1 = new Invoice()
{
    Id = 1,
    Description = "Product 1",
    Quantity = 1,
    Price = 100M,
};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "Product 2",
    Quantity = 1.4F,
    Price = 8M,
};

Console.WriteLine("Invoice 1: " + invoice1);
Console.WriteLine("Invoice 2: " + invoice2);
Console.WriteLine($"Total : {$"{payroll:C2}",18}");
