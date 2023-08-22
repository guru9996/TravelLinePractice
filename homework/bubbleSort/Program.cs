namespace bubbleSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string? str = Console.ReadLine();
            List<int> numList = new List<int>();

            string[] numsStr = str.Split(' ');
            foreach (string? numStr in numsStr)
            {
                bool sucParse = int.TryParse(numStr, out int num);
                if (sucParse)
                {
                    numList.Add(num);
                }
            }
            for (int i = 0; i < numList.Count; i++)
            {
                for (int j = 0; j < numList.Count - i - 1; j++)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        int temp = numList[j];
                        numList[j] = numList[j + 1];
                        numList[j + 1] = temp;
                    }
                }
            }
            for(int i = 0;i < numList.Count;i++)
            {
                Console.Write(numList[i] + " ");
            }
        }
    }
}