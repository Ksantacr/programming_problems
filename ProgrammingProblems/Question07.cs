
namespace ConsoleApp1
{
    public class Question07
    {
        public string mob(int n)
        {
            if (n == null)
                return "(O_o)";

            string mob = string.Empty;
            int middle = (n / 2);
            bool hasFinalGuy = false;
            bool fillLeftSide = true;

            if (n > 7)
            {
                hasFinalGuy = true;
            }

            int partialGuyIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 && hasFinalGuy)
                {
                    mob += createLeftFinalGuy();
                }

                if (middle == i)
                {
                    mob += createCompleteMob();
                    fillLeftSide = false;
                    continue;

                }
                if (fillLeftSide)
                {
                    if (partialGuyIndex == 2)
                    {
                        mob += createLeftPartialGuy();
                        partialGuyIndex = 0;
                    }
                    else
                    {
                        mob += createLeftSideGuy();
                        partialGuyIndex++;
                    }
                }
                else
                {
                    if (hasFinalGuy)
                    {
                        mob += createRightFinalGuy();
                    }
                    else
                    {
                        if (partialGuyIndex == 2)
                        {
                            mob += createRightPartialGuy();
                            partialGuyIndex = 0;
                        }
                        else
                        {
                            mob += createRightSideGuy();
                            partialGuyIndex++;
                        }
                    }
                }
            }

            return mob;

        }

        private string createLeftSideGuy()
        {
            return "(-_";
        }

        private string createRightSideGuy()
        {
            return "_-)";
        }

        private string createRightPartialGuy()
        {
            return "-_-)";
        }
        private string createLeftPartialGuy()
        {
            return "(-_-";
        }

        private string createRightFinalGuy()
        {
            return "-)";
        }

        private string createLeftFinalGuy()
        {
            return "(-";
        }

        private string createCompleteMob()
        {
            return "(-_-)";
        }
    }
}
