
FizzBuzz();

Console.ReadLine();



void FizzBuzz()
{
	foreach (var number in Enumerable.Range(1, 100))
	{
		Console.WriteLine(number switch
		{
			_ when number % 3 == 0 && number % 5 == 0 => "FizzBuzz",
			_ when number % 3 == 0 => "Fizz",
			_ when number % 5 == 0 => "Buzz",
			_ => number.ToString()
		});
	}
}
