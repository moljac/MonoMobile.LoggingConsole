using System;
using System.Text;
using System.IO;

using Core.Diagnostics;

namespace Core.Diagnostics
{
	/// <summary>
	/// C:	fprintf(stderr, "Some error\n")
	/// c++
	/// 
	/// c#:	System.Console.Error.WriteLine("Some error\n")
	///		or
	///		TextWriter errorWriter = Console.Error;
	///		errorWriter.WriteLine("Some error\n");
	///		
	/// If you are using Visual Studio as the IDE, your probrably just as well using the 
	/// Output window in the IDE.
	/// Something like:
	/// MyVarToWatch var;
	/// System.Diagnostics.Debug.WriteLine(String.Format("My var value = {0}", var));
	/// If you want to redirect debug statements to file, you can do so via a listener, like 
	/// the following the redirects to the console:
	/// 
	///		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	///		
	///	System.Diagnostics.Debug will only be called in the debug build. If you want the 
	///	same functionality in both debug and release, use System.Diagnostics.Trace instead. 
	///	
	/// Modified from:
	/// http://saezndaree.wordpress.com/2009/03/29/how-to-redirect-the-consoles-output-to-a-textbox-in-c/
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ConsoleStreamWriterRedirector : TextWriter
	{

		public override Encoding Encoding
		{
			get { return System.Text.Encoding.UTF8; }
		}
	}
}
