public class Euler_6
{
	public static void main(String[] args)
	{
		int sum = 0;
		long bigSum = 0L;
		long square = 0L;
		long difference;
		
		for (int i = 1; i <= 100; i++)
		{
			bigSum += Math.pow(i, 2);
			sum += i;
		}
		
		square = (long)Math.pow(sum, 2);
		difference = square - bigSum;
		
		System.out.println(difference);
	}
}
			