using CursoCSharp;

Console.WriteLine("Hello, World!");

Console.WriteLine("//////////////////////////////");
try
{
	Console.WriteLine(new Date(2023, 1, 24));
	Console.WriteLine(new Date(2023, 1, 111));
	Console.WriteLine(new Date(2023, 15, 7));

}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}


Console.WriteLine("//////////////////////////////");
Console.ReadLine();