public class Euler_12
{
   public static void main(String args[])
   {
      long triNum = 1000405L;
      long natural = 1414L;
      
      while (checkFactors(triNum) < 500)
      {
         natural++;
         triNum += natural;
      }
      
      System.out.println("Minimum number is, " + triNum);
      
      /*while (triNum < 1000000L)
      {
         natural++;
         triNum += natural;
      }*/
      
      System.out.println(triNum + ", " + natural );
      System.out.println(checkFactors(1000405L));
   }    
      
   public static long checkFactors (long num)
   {  
      int divCount = 0;
      for (int i = 1; i <= Math.sqrt(num); i++)
         if (num % i == 0)
             divCount++;
      return divCount*2;
   }   
} 
         
         
         
      