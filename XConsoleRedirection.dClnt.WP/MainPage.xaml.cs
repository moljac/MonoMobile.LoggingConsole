using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using System.IO;
using Core.Diagnostics;

namespace XConsoleRedirection.dClnt.WP
{
	public partial class MainPage : PhoneApplicationPage
	{
		TextWriter _writer = null;

		// Constructor
		public MainPage()
		{
			InitializeComponent();
		}

		private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
		{
			_writer = new ConsoleStreamWriterRedirector(txtConsole);
			Console.SetOut(_writer);

			Console.WriteLine("Now redirecting output to the text box");

		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Hello world on stdout");
			Console.Error.WriteLine("Hello world on stderr");
		}

	}
}