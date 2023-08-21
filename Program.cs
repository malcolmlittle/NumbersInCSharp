//WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
	int a = 20;
	int b = 5;
	int c = a + b;
	Console.WriteLine(c);

	// subtraction
	c = a - b;
	Console.WriteLine(c);

	// multiplication
	c = a * b;
	Console.WriteLine(c);

	// division
	c = a / b;
	Console.WriteLine(c);
}

void OrderPrecedence()
{
	int a = 5;
	int b = 4;
	int c = 2;
	int d = a + b * c;
	Console.WriteLine(d);

	d = (a + b) * c;
	Console.WriteLine(d);

	d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
	Console.WriteLine(d);

	int e = 7;
	int f = 4;
	int g = 3;
	int h = (e + f) / g;
	Console.WriteLine(h);
}

// added comment for github testing