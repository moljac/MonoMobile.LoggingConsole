using System;
using System.Text;
using System.IO;

using Core.Diagnostics;
using Android.Widget;


namespace Core.Diagnostics
{
	public partial class ConsoleStreamWriterRedirector
	{
		TextView _output = null;

		public ConsoleStreamWriterRedirector(TextView output)
		{
			_output = output;
		}

		public override void Write(char value)
		{
			base.Write(value);
			_output.Text += (value.ToString());
		}
	}
}
