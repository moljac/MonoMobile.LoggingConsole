using System;
using System.Text;
using System.IO;

using Core.Diagnostics;
using System.Windows.Forms;

namespace Core.Diagnostics
{
	public partial class ConsoleStreamWriterRedirector
	{
		TextBox _output = null;

		public ConsoleStreamWriterRedirector(TextBox output)
		{
			_output = output;
		}

		public override void Write(char value)
		{
			base.Write(value);
			_output.AppendText(value.ToString());

		}
	}
}
