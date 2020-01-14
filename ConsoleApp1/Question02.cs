
namespace ConsoleApp1
{
    public class Question02
    {
        public long[] track(long[] times)
        {
            if (times == null)
                times = new long[]{0};

            long ms = sumArray(times);

            if (ms < 0)
                ms = 0;
            long days = (((ms/1000)/60/60)/24);
            ms = (ms - (days * 24) * 60 * 60 * 1000);
            long hours = ms /1000/ 60/60;
            ms = (ms - (hours * 60 * 60 * 1000));

            long minutes = ms / 1000 / 60;
            ms = (ms - (minutes * 60 * 1000));

            long seconds = ms / 1000;
            ms = (ms - (seconds * 1000));

            return new[] { days, hours, minutes, seconds, ms };

        }


        private long sumArray(long[] times)
        {
            long total = 0;
            for (int i = 0; i < times.Length; i++)
            {
                total += times[i];
            }
            return total;
        }
    }
}
