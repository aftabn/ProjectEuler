import java.math.*;

public class Euler_17
{
   public static void main(String args[])
   {
      final int[] ONES = {0,3,3,5,4,4,3,5,5,4};
      final int[] TENS = {0,6,6,8,8,7,7,9,8,8}; //Starting at 11
      final int[] DECADES = {0,3,6,6,5,5,5,7,6,7}; // starting at 10
      final int HUNDRED = 7;
      final int THOUSAND = 11;
      final int AND = 3;
      int sum = 0;
      int temp = 0;
      int ones, tens, hundos, thousand;
      
      for (int i = 1; i <= 1000; i++)
      {
         thousand = i/1000;
         hundos = i/100;
         tens = i/10 % 10;
         ones = i % 10;
         temp = 0;
         
         if (thousand == 1)
            temp += THOUSAND;
         else if (hundos != 0) //___ hundred
         {
            temp += ONES[hundos];
            temp += HUNDRED;
            if (tens != 0)
            {
               temp += AND;
               if (ones == 0 && tens == 1)  //____ hundred and _____
                  temp += TENS[tens];
               else if (ones == 0)   
                  temp += DECADES[tens];
               else
               {
                  temp += TENS[tens];
                  temp += ONES[ones];
               }
            }
            else if (ones != 0)
            {
               temp += AND;
               temp += ONES[ones-1];
            }   
         }   
         else if (tens != 0)
         {
            if (ones == 0 && tens == 1)  //____ hundred and _____
               temp += TENS[tens];
            else if (ones == 0)   
               temp += DECADES[tens];
            else
            {
               temp += TENS[tens];
               temp += ONES[ones];
            }
         }
         else if (ones != 0)
            temp += ONES[ones-1];             
         else;
         
         sum += temp;
      }
      System.out.println(sum);
   }
}        
      