using System;
using System.Text;

namespace ToHuman
{
    public static class Human
    {
        public static string ToHuman(this int self, bool compound = false) =>
            $"{self}".ToHuman(compound);

        public static string ToHuman(this string self, bool compound = false)
        {
            var sb = new StringBuilder();
            var digits = self.Length;
            var steps = 1;
            // partition digit
            do
            {
                var back = self[steps..].ToInt();
                var take = self[(steps - 1)..].ToInt();

                var subtract = take - back;
                var compose = $"{subtract}".ToPartition();
                var parts = subtract / compose;

                if (digits > 2)
                {
                    if (parts > 0)
                    {
                        sb.Append(Worded.Lookup(parts));
                        sb.Append(Worded.Lookup(compose));
                    }

                    digits -= 1;
                }
                else
                {
                    if (parts > 0)
                    {
                        _ = compound ?
                             sb.Append($"{Worded.Lookup(parts).Trim()}-") :
                             sb.Append(Worded.Lookup(parts));
                        sb.Append(Worded.Lookup(back));
                    }
                    else
                    {
                        sb.Append(Worded.Lookup(back));
                    }

                    digits -= 2;
                }

                steps += 1;
            } while (digits > 0);

            return sb.ToString().Trim();
        }

        static internal int ToPartition(this string self) =>
            Worded.Partition(self.Length);

        static internal int ToInt(this string self) =>
            int.TryParse(self, out var rst) ?
            rst :
            throw new InvalidCastException(nameof(self));
    }
}