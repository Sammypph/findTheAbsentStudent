using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheAbsentStudent
{
    class Program
    {
        // Complete the findTheAbsentStudents function below.
        static int[] FindTheAbsentStudents(int n, int[] a)
        {
            List<int> initialValues = new List<int>();
            List<int> supposedId = new List<int>();
            IEnumerable<int> actualPresent = initialValues.Distinct();

            for (int i = 0; i < n; i++)
            {
                initialValues.Add(a[i]);
            }

            for (int j = 1; j <= n; j++)
            {
                supposedId.Add(j);
            }

            foreach (int studentId in actualPresent)
            {
                if (supposedId.Contains(studentId))
                {
                    supposedId.Remove(studentId);
                }
            }
            
            return supposedId.ToArray();

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = FindTheAbsentStudents(n, a);

           Console.WriteLine(string.Join(" ", result));
        }
    }
}
