public class Euler_10
{
	boolean isPrime (int n)
	{
		//check if n is divis by 2
		if (n % 2 == 0)
			return false;
		//check rest of the odd numbers up to the root of n 
		for(int i = 3; i*i <= n; i += 2)
			if (n % i == 0)
				return false;
		
		return true;
	}
	
	public static void main(String[] args)
	{
		Euler_10 check = new Euler_10();
		
		long sum = 2L;
		
		for (int i = 3; i < 2000000; i++)
			if (check.isPrime(i))
				sum += i;
		
		System.out.println(sum);
	}
}
		