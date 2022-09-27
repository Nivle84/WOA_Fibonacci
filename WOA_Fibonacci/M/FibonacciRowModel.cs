using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOA_Fibonacci.M
{
	internal class FibonacciRowModel : BindableBase
	{
		public int FibRow { get; set; }
		public int FibNum { get; set; }

		public FibonacciRowModel(int fibRow, int fibNum)
		{
			FibRow = fibRow;
			FibNum = fibNum;
		}
	}
}
