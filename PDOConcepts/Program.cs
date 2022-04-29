using ConcepsPDO;

Console.WriteLine("PDO Concepts!");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 3, 11));
    Console.WriteLine(new Date(2022, 11, 31));
}  catch (Exception error){
    Console.WriteLine(error.Message);
}