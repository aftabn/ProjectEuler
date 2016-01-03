public class Euler_2
{
	public static void main(String args[])
   {
      int term1 = 1;
      int term2 = 1;
      int result = 0;
      int sum = 0;
      
      while (result < 4000000)
      {
         if (result % 2 == 0)
            sum += result;
            
         result = term1 + term2;
         term2 = term1; 
         term1 = result;
       }   
      
       System.out.println(sum);
    }        
}