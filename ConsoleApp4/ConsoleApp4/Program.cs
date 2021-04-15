using System;

namespace ConsoleApp4
{
    
    class Program
    {
        static void Twitter(string source)
        {
            int i = 0;
            string tags = "";
            string user = "";
            int count1 = 0;
            int count2 = 0;


            for (int j = 0; j < source.Length; j++)
            {
                if (source[j] == '#')
                {
                    for (int k = j; k < source.Length; k++)
                    {
                        if (source[k] == ' ' || source[k] == ',')
                        {

                            break;
                        }
                        tags = tags + source[k];

                    }
                    Console.WriteLine(tags);
                    tags = "";
                    count1++;
                }
            }
            Console.WriteLine("number of tags is {0}", count1);

            for (int j = 0; j < source.Length; j++)
            {
                if (source[j] == '@')
                {
                    for (int k = j; k < source.Length; k++)
                    {
                        if (source[k] == ' ' || source[k] == ',')
                        {
                            break;
                        }
                        user = user + source[k];

                    }
                    Console.WriteLine(user);
                    user = "";
                    count2++;
                }
            }

            Console.WriteLine("number of user is {0}", count2);






        }
        static void Main(string[] args)
        {
            string value = " Hey #DisabilityTwitter, thank you so much for your feedback about captioning our videos. We hear you, we see you, we’ve added captions to this @TwitterSpaces announcement. What do you think? We’ll continue to level up our captioning process moving forward. #UntilWeAllBelong ";


            Twitter(value);
        }
    }
}
