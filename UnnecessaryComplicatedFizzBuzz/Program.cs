using UnnecessaryComplicatedFizzBuzz.Model;

namespace UnnecessaryComplicatedFizzBuzz
{
	internal class Program
	{
		static void Main(string[] args)
		{
			uint limit = 100;
			List<Modifier> modifers = new();

			Modifier fizz = new(3, "fizz");
			Modifier buzz = new(5, "buzz");

			modifers.Add(fizz);
			modifers.Add(buzz);

			var Engine = new FizzEngine(limit, modifers);

			Console.Write(Engine.Compute());
		}
	}
}