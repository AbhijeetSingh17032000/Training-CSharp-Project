1.
static void Main(string[] args)
        {
            int[] Values = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = from TableName in Values
                         where TableName > 0
                         orderby TableName
                         select TableName;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();
	}

2.
static void Main(string[] args)
        {
            int[] Values = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result1 = Values.Distinct();
            var result = from TableName in Values
                         select TableName;
            var result2 = from TableName in result1
                         select TableName;
            Console.WriteLine("The numbers in the array are :");
            foreach (var item in result)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
            Console.WriteLine("The number and the Frequency are:");
            foreach (var item in result2)
            {
                var QSCount = (from emp in Values
                               where emp == item
                           select emp).Count();
                Console.WriteLine("Number "+item+" appears " + QSCount+" times");
            }
            

            Console.Read();
	}

3.
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            Console.WriteLine();

            string str = Console.ReadLine(); 
            char[] ch = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
            }
            var result = ch.Distinct();
            foreach (char c in result)
            {
                var QSCount = (from emp in ch
                               where emp == c
                               select emp).Count();
                Console.WriteLine("Character " + c + " appears " + QSCount + " times");
            }

            Console.Read();
        }

4.
 	static void Main(string[] args)
        {
            
            Console.Write("How many city's record you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            String[] b = new String[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter "+(i+1)+" city record :");
                b[i] = Console.ReadLine();
            }

            Console.Write("Input starting character for the string :");
            Console.WriteLine();
            string disp1 = Console.ReadLine();
            Console.Write("Input ending character for the string :");
            Console.WriteLine();
            string disp2 = Console.ReadLine();

            var result = (from studentData in b
                         where studentData.StartsWith(disp1) && studentData.EndsWith(disp2)
                         select studentData).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("The city starting with " + disp1 + " and ending with " + disp2 + " is : " + item);
            }

            Console.Read();
        }


5.
        static void Main(string[] args)
        {
            
            Console.Write("How many records you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter "+(i+1)+" record :");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("How many records you want to display? ");
            Console.WriteLine();
            int display = Convert.ToInt32(Console.ReadLine());

            var result = (from studentData in b

                          orderby studentData descending
                          select studentData
                          ).Take(display);
            Console.WriteLine("The top "+display+" records from the list are :");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

6.