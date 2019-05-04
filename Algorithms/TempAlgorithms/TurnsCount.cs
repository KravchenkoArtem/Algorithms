namespace Algorithms.TempAlgorithms
{
    public class TurnsCount
    {
        public static int Turns(int n, int low, int high) {
            int turns = 0;
            while (high > low)
            {
                turns++;
                int mid = (low + high) / 2;
                if (mid == n) {
                    return turns;
                } else if (mid < n) {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }
            return turns;
        }
    }
}