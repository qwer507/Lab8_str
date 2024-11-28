namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            Console.WriteLine(CreatePhoneNumber(a));

            //string a = "He";
            //int l = 1;
            //Console.WriteLine(TrimString(a, l));

            //long a = 5678;
            //Console.WriteLine(SquareDigits(a));

            //string[] names = ["Alex", "Jacob", "Mark", "Max"];
            //Console.WriteLine(Likes(names));

            string CreatePhoneNumber(int[] numbers)
            {
                int len_phone_num = 12;
                string phone_num = "+7";
                for (int i = 0; i < numbers.Length; i++)
                    phone_num += numbers[i];
                if (phone_num.Length != len_phone_num)
                    return "-1";
                return phone_num;
            }

            string TrimString(string phrase, int len)
            {
                if (phrase.Length > len)
                {
                    if (len > 3)
                    {
                        phrase = phrase.Remove(len - 3);
                    }
                    else
                        phrase = phrase.Remove(len);
                   phrase += "...";
                }
                return phrase;
            }

            long SquareDigits(long n)
            {
                string end = "";

                while(n != 0)
                {
                    end = (Math.Pow((n % 10),2)).ToString() + end;
                    n /= 10;
                }
                return int.Parse(end);
            }

            string Likes(string[] names)
            {
                int len_name = names.Length;
                switch(len_name)
                {
                    case 0:
                        return "no one likes this";
                    case 1:
                        return $"{names[0]} likes this";
                    case 2:
                        return $"{names[0]} and {names[1]} like this";
                    case 3:
                        return $"{names[0]}, {names[1]} and {names[2]} like this";
                    default:
                        return $"{names[0]}, {names[1]} and {len_name - 2} others like this";
                }
            }
        }
    }
}
