public class Euler_4
{
	public static void main(String[] args)
	{
		int product;
		boolean found = false;
		String palindrome = "";
		String piece1, piece2;
		
		for (int i = 999; 	i > 800 && !found; i--)
			for (int j = 999; j > i-100 && j > 800 && !found; j--)
			{
				product = i*j;
				palindrome = "" + product;
				
				piece1 = palindrome.substring(0, palindrome.length() / 2);
				piece2 = new StringBuffer(palindrome.substring(palindrome.length() / 2, palindrome.length())).reverse().toString();
				
				if (piece1.equals(piece2))
					found = true;
			}
			
		System.out.println(palindrome);
	}
}