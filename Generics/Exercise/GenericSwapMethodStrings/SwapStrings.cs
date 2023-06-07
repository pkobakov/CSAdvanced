namespace GenericSwapMethodStrings
{
    using System.Text;

    public class SwapStrings <T> 
	{ 
	    private List<T> list;
        public SwapStrings()
        {
            this.list = new List<T>();
        }

		public void Add(T item) 
		{
		    list.Add(item);
		
		}

		public void Swap (int indexA, int indexB)
		{
			T swap = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = swap;
		}

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			foreach (T item in list) 
			{
			    sb.AppendLine($"{typeof(T)}: {item}");
			
			}
            return sb.ToString().TrimEnd();
        }
    }
}