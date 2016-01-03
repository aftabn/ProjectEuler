import java.util.*;
import java.io.*;
import java.math.*;

public class Euler_13
{
   public static void main (String args[])
   {  
      String line = null;
      BigInteger sum = BigInteger.ZERO;
      
      try
		{
			FileReader input = new FileReader("Euler_13_Number.txt");
			BufferedReader br = new BufferedReader(input);
         
         while((line = br.readLine()) != null)
               sum = sum.add(new BigInteger(line));
               
         
			br.close();
      }
      
      catch(FileNotFoundException ex)
		{
			System.out.println("Unable to open file 'Euler_13_Number.txt'");
		}
		
		catch(IOException ex)
		{
			System.out.println("Error reading file 'Euler_13_Number.txt'");
		}
      
      System.out.println(sum);
	}
}  	  
