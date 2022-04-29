using ConcepsPDO;

Console.WriteLine("PDO Concepts!");

Employee employee1 = new CommissionEmployee()
{
    Id = 121,
    FirstName = "John",
    LastName = "Doe",
    BirthDate = new Date(1990, 1, 1),
    HiringDate = new Date(2018, 1, 1),
    IsActive = true,
    CommissionPercentaje = 0.03f,
    Sales = 1000
};

Console.WriteLine("Employee 1:" + employee1);