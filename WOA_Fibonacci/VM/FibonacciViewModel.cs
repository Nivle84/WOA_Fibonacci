using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using WOA_Fibonacci.M;
using Prism.Events;

namespace WOA_Fibonacci.VM
{
	internal class FibonacciViewModel : BindableBase
	{
		private FibonacciModel _myModel;
		public FibonacciModel MyModel
		{
			get { return _myModel; }
			set
			{
				SetProperty(ref _myModel, value);
			}
		}

		private FibonacciRowModel _fibRowModel;

		public FibonacciRowModel FibRowModel
		{
			get { return _fibRowModel; }
			set
			{
				SetProperty(ref _fibRowModel, value);
			}
		}


		public ICommand ButtonFindCommandClicked { get; private set; }
		public ICommand ButtonCreateCommandClicked { get; private set; }

		public FibonacciViewModel()
		{
			MyModel = new FibonacciModel();
			ButtonFindCommandClicked = new DelegateCommand(ButtonFindCommandMethod);
			ButtonCreateCommandClicked = new DelegateCommand(ButtonCreateCommandMethod);
		}

		private void ButtonCreateCommandMethod()
		{
			int firstDicKey = 0;
			int secondDicKey = 0;
			Debug.Print("BlankSequence count: " + MyModel.BlankSequence.Count().ToString());

			for (int i = 0; i < MyModel.InputInteger; i++)
			{
				secondDicKey = MyModel.BlankSequence.Count() - 1;
				firstDicKey = secondDicKey - 1;

				MyModel.BlankSequence.Add(MyModel.BlankSequence.Count(), MyModel.BlankSequence[firstDicKey] + MyModel.BlankSequence[secondDicKey]);
				Debug.Print("BlankSequence count: " + MyModel.BlankSequence.Count().ToString());
			}
		}

		private void ButtonFindCommandMethod()
		{
			
		}
	}
}
