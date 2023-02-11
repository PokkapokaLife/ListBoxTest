using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace ListBoxTest
{
	public class ButtonTemplate
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public string Text { get; set; }
		public Brush ButtonBackground { get; set; }
	}

	public class MainWindowVM
	{
		public ReactiveCollection<ButtonTemplate> ButtonList { get; set; } = new ReactiveCollection<ButtonTemplate>();


		public MainWindowVM()
		{
		}

		private void IndexChanged(int index)
		{
		}

	}
}
