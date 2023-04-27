using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        while (true)
        {
			Console.ForegroundColor = ConsoleColor.White;
			bool isExceptionTriggered = false;
			try
			{
				double a = 0;
				double b = 0;
				double c = 0;
				Console.Write("Enter a quadratic equation: ");
				string input = Console.ReadLine();
				List<string> inputs = input.Split(' ').ToList();
				List<string> orderedInput = new List<string>();
				if (inputs[0].Contains("x^2"))
				{
					if (inputs[0][0] == '-')
					{
						orderedInput.Add("-");
						inputs[0] = inputs[0].Replace("-", "");
					}
					else
					{
						orderedInput.Add("+");
					}
					orderedInput.Add(inputs[0]);
				}
				else if (inputs[2].Contains("x^2"))
				{
					orderedInput.Add(inputs[1]);
					orderedInput.Add(inputs[2]);
				}
				else if (inputs[4].Contains("x^2"))
				{
					orderedInput.Add(inputs[3]);
					orderedInput.Add(inputs[4]);
				}


				if (inputs[0].Contains("x") && !inputs[0].Contains("x^2"))
				{
					if (inputs[0][0] == '-')
					{
						orderedInput.Add("-");
						inputs[0] = inputs[0].Replace("-", "");
					}
					else
					{
						orderedInput.Add("+");
					}
					orderedInput.Add(inputs[0]);
				}
				else if (inputs[2].Contains("x") && !inputs[2].Contains("x^2"))
				{
					orderedInput.Add(inputs[1]);
					orderedInput.Add(inputs[2]);
				}
				else if (inputs[4].Contains("x") && inputs[4].Contains("x^2") == false)
				{
					orderedInput.Add(inputs[3]);
					orderedInput.Add(inputs[4]);
				}


				if (int.TryParse(inputs[0], out int result0) == true)
				{
					if (inputs[0][0] == '-')
					{
						orderedInput.Add("-");
						inputs[0] = inputs[0].Replace("-", "");
					}
					else
					{
						orderedInput.Add("+");
					}
					orderedInput.Add(inputs[0]);
				}
				else if (int.TryParse(inputs[2], out int result2) == true)
				{
					orderedInput.Add(inputs[1]);
					orderedInput.Add(inputs[2]);
				}
				else if (int.TryParse(inputs[4], out int result4) == true)
				{
					orderedInput.Add(inputs[3]);
					orderedInput.Add(inputs[4]);

				}
				if (orderedInput[1][0] == 'x')
				{
					orderedInput[1] = orderedInput[1].Replace("x^2", "1");
				}
				else
				{
					orderedInput[1] = orderedInput[1].Replace("x^2", "");
				}
				if (orderedInput[3][0] == 'x')
				{
					orderedInput[3] = orderedInput[3].Replace("x", "1");
				}
				else
				{
					orderedInput[3] = orderedInput[3].Replace("x", "");
				}



				if (orderedInput[0] == "-")
				{
					a = double.Parse(orderedInput[0] + orderedInput[1]);
				}
				else if (orderedInput[0] == "+")
				{
					a = double.Parse(orderedInput[1]);
				}

				if (orderedInput[2] == "-")
				{
					b = double.Parse(orderedInput[2] + orderedInput[3]);
				}
				else if (orderedInput[2] == "+")
				{
					b = double.Parse(orderedInput[3]);
				}

				if (orderedInput[4] == "-")
				{
					c = double.Parse(orderedInput[4] + orderedInput[5]);
				}
				else if (orderedInput[4] == "+")
				{
					c = double.Parse(orderedInput[5]);
				}

				double discriminant = Math.Pow(b, 2) - 4 * a * c;
				if (discriminant < 0)
				{
					Console.WriteLine("No real roots!");
				}
				else if (discriminant == 0)
				{
					double x = -b / (2 * a);
					Console.WriteLine($"x1 = {x}");
				}
				else if (discriminant > 0)
				{
					double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
					double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
					Console.WriteLine($"x1 = {x1}");
					Console.WriteLine($"x2 = {x2}");
				}
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Not a quadratic equation!");
				Console.ForegroundColor = ConsoleColor.White;
				isExceptionTriggered = true;
			}
			if (isExceptionTriggered == false)
			{
				break;
			}
		}
        
    }
}
