public class Euler_5
{
	public static void main(String[] args)
	{
		boolean found = false;
		boolean divisible;
		
		for (int i = 20; i <= 2147483647 && !found; i++)
		{
			divisible = true;
			for (int j = 2; j <= 20 && divisible; j++)
			{
				if (i % j != 0)
					divisible = false;
				else if (j == 20 && divisible)
					found = true;
			}
			
			if (found)
				System.out.println(i);
		}
	}
}
		