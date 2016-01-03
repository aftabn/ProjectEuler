import java.math.*;

public class Euler_16
{
   public static void main(String args[])
   {  
      BigInteger ZERO = BigInteger.valueOf(0);
      BigInteger ONE = BigInteger.valueOf(1);
      BigInteger TWO = BigInteger.valueOf(2);
      BigInteger TEN = BigInteger.valueOf(10);
      BigInteger product = TWO.pow(1000);
      int sum = 0;
      while (product != ZERO)
      {
         sum += product.mod(TEN).intValue();
         product = product.divide(TEN);
         System.out.println(product);  
      }
             
      //for (int j = 0; j < product.toString().length(); j++)
         //sum += (int)product.toString().charAt(j);
         
      System.out.println(sum);
   }
}           