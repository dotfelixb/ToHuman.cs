using System;
using System.Text;

namespace ToHuman
{
    public static class Human
    {
        public static string ToHuman(this int self) =>
            $"{self}".ToHuman();

        public static string ToHuman(this string self)
        {
            var sb = new StringBuilder();
            var digits = self.Length;
            var steps = 1;
            // partition digit
            do
            {
                var back = self[steps..].ToInt();
                var take = self[(steps - 1)..].ToInt();
                var parts = 0;
                var compose = 0;

                if (digits > 2)
                {
                    var subtract = take - back;
                    compose = $"{subtract}".ToPartition();
                    parts = subtract / compose;

                    sb.Append(Worded.Lookup(parts));
                    sb.Append(Worded.Lookup(compose));
                }
                else 
                {
                    var subtract = take - back;
                    compose = $"{subtract}".ToPartition();
                    parts = subtract / compose;

                    if (parts> 0)
                    {
                        sb.Append(Worded.Lookup(parts));
                        sb.Append(Worded.Lookup(back));
                    }
                    else
                    { 
                        sb.Append(Worded.Lookup(back));
                    }
                }

                steps += 1;
                digits -= 2;
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