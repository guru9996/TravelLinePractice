namespace bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine();
            List<int> numList = new List<int>();

            string[] numsStr = s.Split(' ');
            int num;
            foreach (string? numStr in numsStr)
            {
                bool sucParse = int.TryParse(numStr, out num);
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