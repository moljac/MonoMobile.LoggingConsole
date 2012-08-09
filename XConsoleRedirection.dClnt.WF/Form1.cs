using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Core.Diagnostics;

namespace ConsoleRedirection
{
	public partial class FormConsole : Form
	{
		TextWriter _writer = null;

		public FormConsole()
		{
			InitializeComponent();
		}

		private void FormConsole_Load(object sender, EventArgs e)
		{
			_writer = new ConsoleStreamWriterRedirector(txtConsole);
			Console.SetOut(_writer);
		
			Console.WriteLine("Now redirecting output to the text box");
		}

		private void txtSayHello_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Hello world on stdout");
			Console.Error.WriteLine("Hello world on stderr");
		}
	}
}