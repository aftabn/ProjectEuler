public class Euler_7
{
	public static void main(String[] args)
	{
		int count = 6;
		boolean divisible;
		
		for (int i = 14; i < 278945416 && count < 10001; i++)
		{
			divisible = false;
			for (int j = 2; j <= i/2 && !divisible; j++)
				if (i % j == 0)
					divisible = true;
			
			if (!divisible)
				count++;
				
			if (count == 10001)
				System.out.println(i);
		}
	}
}

					