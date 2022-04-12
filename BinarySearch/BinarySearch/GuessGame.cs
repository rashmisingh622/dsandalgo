namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GuessGame
    {
        public int GuessNumber(int n, int num)
        {
            return GetNumber(1, n, num);
        }

        public int GetNumber(int start, int end, int num)
        {
            long sum = end + start;
            int mid = (int)((long)sum / 2);
            var result = 0;
            if (mid == num)
            {
                result = mid;
                return mid;
            }
            else if (mid > num)
            {
                return GetNumber(start, mid - 1, num);
            }
            else if (mid < num)
            {
                return GetNumber(mid + 1, end, num);
            }
            else
            {
                return result;
            }
        }
    }
}
