using System;

namespace DiceTools
{
    static class Dice
    {
        private static Random generator = new Random();

        public static int[] D(int dice, int rolls)
        {
            int[] res = new int[rolls];

            for (int i = 0; i < rolls; i++)
            {
                var roll = generator.Next(1, dice + 1);

                res[i] = roll;
            }

            return res;
        }

        public static int D(int dice, int rolls, DiceModes mode)
        {
            if (mode == DiceModes.Min)
            {
                return Dice.Min(dice, rolls);
            }
            else if (mode == DiceModes.Max)
            {
                return Dice.Max(dice, rolls);
            }
            else
            {
                return Dice.Sum(dice, rolls);
            }
        }

        public static int D6()
        {
            return D(6, 1)[0];
        }

        public static int D3()
        {
            return D(3, 1)[0];
        }

        public static int[] D6(int rolls)
        {
            return D(6, rolls);
        }

        public static int[] D3(int rolls)
        {
            return D(3, rolls);
        }

        public static int Sum(int dice, int rolls)
        {
            int res = 0;

            int[] values = D(dice, rolls);
            for (int i = 0; i < values.Length; i++)
            {
                res += values[i];
            }

            return res;
        }

        public static int Min(int dice, int rolls)
        {
            int res = int.MaxValue;

            int[] values = D(dice, rolls);
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < res)
                {
                    res = values[i];
                }
            }

            return res;
        }

        public static int Max(int dice, int rolls)
        {
            int res = int.MinValue;

            int[] values = D(dice, rolls);
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > res)
                {
                    res = values[i];
                }
            }

            return res;
        }
    }
}
