class Program
    {
        static void Main(string[] args)
        {
            //var data = $"{Environment.UserDomainName.ToLower()}\\{Environment.UserName}";

            //DateTime d = new DateTime(2020, 10, 6);
            //int days = DateTime.Now.Subtract(Convert.ToDateTime("10/06/2020")).Days;
            Dictionary<string, int> output = new Dictionary<string, int>();
            Console.WriteLine("Enter Input String");
            var inputString = Console.ReadLine();
            //var inputString = "zf3kabxcde224lkzf3mabxc51+crsdrzf3nab=";            
            Console.WriteLine("Enter pattern length: ");
            var patternLength = Console.ReadLine();
            int no = 0;
            if(!int.TryParse(patternLength,out no))
            {
                Console.WriteLine("Invalid Input Number");
                Console.ReadLine();
                return;
            }
            if (inputString.Length < Convert.ToInt32(patternLength))
            {
                Console.WriteLine("Input string characters must be greater than search pattern Length");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("======================SEARCH STARTS========================");
            for (int index = 0; index < inputString.Length; index++)
            {                
                var eString = inputString.Substring(index,
                    inputString.Length - index < Convert.ToInt32(patternLength) 
                    ? (inputString.Length - index) 
                    : Convert.ToInt32(patternLength));

                if (output.ContainsKey(eString))
                {
                    output[eString] += 1; 
                }
                else
                {
                    output.Add(eString, 1);
                }
            }
            foreach (KeyValuePair<string, int> item in output)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine("The pattern: " + item.Key + " occurred " + item.Value + " times");
                }
            }
            Console.WriteLine("======================SEARCH ENDS==========================");
            Console.Read();
        }
    }
