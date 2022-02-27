using System;

public class Program
{
	public static void Main()
	{
		//Conversión implicita:
		int num1 = 9;
		double numdouble = num1;
		Console.WriteLine("Pasamos del numero " + num1 + " int a el numero " + numdouble + " double");
		float numFloat = num1;
		Console.WriteLine("Pasamos del numero " + num1 + " int a el numero " + numFloat + " float");
		long numlong = num1;
		Console.WriteLine("Pasamos del numero " + num1 + " int a el numero " + numlong + " long");
		char letra1 = 'A';
		int numInt = letra1;
		Console.WriteLine("Pasamos de la letra " + letra1 + " char a el numero " + numInt + " int");
		// short nums = 97;
		// char numchar = nums; No es posible impicitamente


		double num2 = 9.7;
		Console.WriteLine("Pasamos del numero " + num2 + " double a el numero " + Convert.ToInt32(num2) + " int");
		double num3 = 9.56;
		Console.WriteLine("Pasamos del numero " + num3 + " double a el numero " + Convert.ToSingle(num3) + " float");
		double num4 = 9.234;
		Console.WriteLine("Pasamos del numero " + num4 + " double a el numero " + Convert.ToInt16(num4) + " short");
		double num5 = 9.345;
		Console.WriteLine("Pasamos del numero " + num5 + " double a el numero " + Convert.ToDecimal(num5) + " decimal");
		Console.Read();
	}
}
