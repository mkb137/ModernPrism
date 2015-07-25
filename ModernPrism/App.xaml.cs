using System;
using System.Windows;

namespace ModernPrism {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public sealed partial class App {

		/// <summary>
		/// <see cref="Application.OnStartup"/>
		/// </summary>
		/// <param name="args"></param>
		protected override void OnStartup( StartupEventArgs args ) {
			base.OnStartup( args );
			// Run the Prism bootstrapper
			Bootstrapper bootstrapper = new Bootstrapper();
			bootstrapper.Run();
		}
	}
}
