import java.math.*;

public class Euler_3
{
	public static void main(String[] args)
	{
		long div = 0L;
		long highPrime = 0L;
		long limit = 600851475143L;
		boolean prime = false;
		
		for (long i = limit/2 + 1; i > 1 && prime == false; i--)
		{
			if (limit % i == 0)
			{
				prime = true;
				div = i;
							
				for (long j = 2L; j < div; j++)
					if (div % j == 0)
					{
						prime = false;
						break;
					}
	
				if (prime == true)
					highPrime = div;
			}
		}
		
		System.out.println(highPrime);
	}
}