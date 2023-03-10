
///////////////////////////////////////////////////////////////////////////////////یاسین منعم///////////////////////////////////////////////////////////////////////////
using System.Threading.Channels;

bool check =true;
do
{
    Console.WriteLine("Are you engaged? y or n");
   string ch = Console.ReadLine();
    switch (ch.ToUpper())
    {
        case "y":
            Console.WriteLine("do you have kids? y or n");
            break; check = true;
            string ch1 = Console.ReadLine();
            switch (ch1.ToUpper())
            {
                case "y":
                    Console.WriteLine("are they girls? y or n");
                    break; check = true;
                    string ch3 = Console.ReadLine();
                    switch (ch3.ToUpper())
                    {
                        case "y":
                            Console.WriteLine("does she go to school? y or n");
                            break; check = true;
                            string ch4 = Console.ReadLine();
                            switch (ch4.ToUpper())
                            {
                                case "y":
                                    Console.WriteLine("best luck for her");
                                    break; check = true;
                                case "n":
                                    Console.WriteLine("hope the best for her");
                                    break; check =true;
                                default:
                                    Console.WriteLine("sorry i cant understand");
                                    break;
                            }
                        case "n":
                            Console.WriteLine("then they are boys ");
                            break; check =true;
                    }
                case "n":
                    Console.WriteLine("are you satisfied with life? y or n");
                    break; check = true;
                    string ch2 = Console.ReadLine();
                    switch (ch2.ToUpper())
                    {
                        case "y":
                            Console.WriteLine("best wishes for you");
                             break; check = true;
                        case "n":
                            Console.WriteLine("I hope it gets better");
                             break; check = true;
                        default:
                            Console.WriteLine("Im happy to help you");
                            break;
                    }
            }
        case "n":
            Console.WriteLine("do you have job? y or n");
            break; check = true;
            string ch5 = Console.ReadLine();
            switch (ch5.ToUpper())
            {
                case "y":
                    Console.WriteLine("Great,do you work in company? y or n");
                    break; check = true;
                    string ch6 = Console.ReadLine();
                    switch (ch6.ToUpper())
                    {
                        case "y":
                            Console.WriteLine("perfect,they must give you good salary");
                            break; check = true;
                        case "n":
                            Console.WriteLine("I hope you get perfect job");
                             break; check =true;
                        default:
                            Console.WriteLine("sorry i cant understand");
                            break;
                    }
                case "n":
                    Console.WriteLine("do you have any profession? y or n");
                    break; check = true;
                    string ch7 = Console.ReadLine();
                    switch (ch7.ToUpper())
                    {
                        case "y":
                            Console.WriteLine("then you must go and find job  related  to your profession");
                             break; check = true;
                        case "n":
                            Console.WriteLine("it cant be like that,do you have skill? y or n");
                            break; check = true;
                            string ch8 = Console.ReadLine();
                            switch (ch8.ToUpper())
                            {
                                case "y":
                                    Console.WriteLine("then you must go and search which kind of job related to your skill");
                                     break; check = true;
                                case "n":
                                    Console.WriteLine("everyone have skill and you dont find that in yourself");
                                     break; check =true;
                                default:
                                    Console.WriteLine("I dont uderstand your answer");
                            }
                    }
            }
    }
} while (check);