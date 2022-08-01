using static System.Console;
using System.Linq;

namespace HomeTast_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] slnames =
            {
                "Иванов Иван АИванович",
                "Иванов АИван АИванович",
                "Иванов БИван БИванович",
                "Иванов ВИван БИванович",
                "Иванов ГИван КИванович",
                "Иванов ДИван КИванович",
                "Иванов ДАИван ШИванович",
                "Иванов СИван ШИванович",
                "Иванов УИван ЩИванович",
                "Иванов Иван Иванович",
            };

            foreach (string name in slnames)
            {
                //Write("{0}\n",name);
                Write($"${name}\n");
            }



            foreach (string name in Sort(slnames))
            {
                //Write("{0}\n",name);
                Write($"${name}\n");
            }
        }

        internal static string[] Sort(string[] names)
        {
            Profile[] unsorted = new Profile[names.Length];
            for (int i=0;i< names.Length; i++)
            {
                string[] sstr = names[i].Split(' ');
                unsorted[i] = new Profile() { FirstName = sstr[1], LastName = sstr[0], MiddleName =  sstr[2] };
            }
            //------------------------------------------
            int n = names.Length;
            for (int j = 0; j < names.Length-1; j++)
                for (int i = 0; i < names.Length-1; i++)
                if (!unsorted[i].Compare(unsorted[i + 1]))
                {
                    Profile el = unsorted[i];
                    unsorted[i] = unsorted[i + 1];
                    unsorted[i + 1] = el;
                }

            //------------------------------------------
            string [] sorted = new string[names.Length];
            return sorted;
        }

        internal struct Profile
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }

            public bool Compare(Profile el)
            {
                int result = String.Compare(FirstName, el.FirstName);
                if (result == 0)
                    if (String.Compare(MiddleName, el.MiddleName) >= 0)
                        return true;
                    else return false;
                else
                {
                    if (result > 0) return true;
                    else return false;
                }
            }
        }
    }
}