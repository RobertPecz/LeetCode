namespace LeetCode
{
    public class CheckDivisibilityByDigitSumAndProduct {
        public bool CheckDivisibility(int n) {
            int tempImput = n;
            int digitPlusSum = 0;
            int digitProductSum = 1;

            if (n < 10)
            {
                return false;
            }
           
            while (tempImput > 0)
            {
                digitPlusSum += tempImput % 10;
                digitProductSum *= tempImput % 10;
            
                tempImput /= 10;
            }
            int sum = digitPlusSum + digitProductSum;
            if(n % sum == 0)
            {
                return true;
            }
            return false;
        }
    }
}