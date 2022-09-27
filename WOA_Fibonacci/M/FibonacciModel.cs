using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WOA_Fibonacci.M
{
	internal class FibonacciModel : BindableBase
	{
		private IDictionary<int, int> _blankSequence;
		public IDictionary<int, int> BlankSequence
		{
			get { return _blankSequence; }
			set
			{
				SetProperty(ref _blankSequence, value);
			}
		}

		private Dictionary<int, int>? _customSequence;
		public Dictionary<int, int>? CustomSequence
		{
			get { return _customSequence; }
			set
			{
				SetProperty(ref _customSequence, value);
			}
		}

		private IList<FibonacciRowModel> _fibonacciRowList;

		public IList<FibonacciRowModel> FibonacciRowList
		{
			get { return _fibonacciRowList; }
			set { _fibonacciRowList = value; }
		}

		private int _inputInteger;
		public int InputInteger
		{
			get { return _inputInteger; }
			set
			{
				SetProperty(ref _inputInteger, value);
			}
		}

		public FibonacciModel()
		{
			BlankSequence = new Dictionary<int, int>
			{
				{0, 0},
				{1, 1}
			};

			FibonacciRowList= new List<FibonacciRowModel>()
			{
				new FibonacciRowModel(BlankSequence[0])
			};
		}
	}
}
