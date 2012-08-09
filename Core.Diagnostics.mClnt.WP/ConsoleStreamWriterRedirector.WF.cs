using System;
using System.Text;
using System.IO;

using Core.Diagnostics;
using System.Windows.Controls;

namespace Core.Diagnostics
{
	/// <summary>
	/// TODO: add StackPanel, etc
	/// </summary>
	public partial class ConsoleStreamWriterRedirector
	{
		TextBlock _output = null;

		public ConsoleStreamWriterRedirector(TextBlock output)
		{
			_output = output;
		}

		public override void Write(char value)
		{
			base.Write(value);
			_output.Text += value.ToString();

		}
	}
}
