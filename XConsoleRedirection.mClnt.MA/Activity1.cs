using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.IO;
using Core.Diagnostics;

namespace XConsoleRedirection.mClnt.MA
{
	[Activity(Label = "XConsoleRedirection.mClnt.MA", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity
	{
		TextWriter _writer = null;
		EditText txtConsole = null;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button>(Resource.Id.button1);
			txtConsole = FindViewById<EditText>(Resource.Id.txtConsole);

			button1.Click += new EventHandler(button1_Click);

			Activity_Load();

		}

		private void Activity_Load()
		{
			_writer = new ConsoleStreamWriterRedirector(txtConsole);
			Console.SetOut(_writer);

			Console.WriteLine("Now redirecting output to the text box");
		}

		void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Hello world on stdout");
			Console.Error.WriteLine("Hello world on stderr");
		}
	}
}

