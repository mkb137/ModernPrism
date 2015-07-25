using System;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity.Configuration;
using ModernPrism.Modules.MyModule;

namespace ModernPrism {

	/// <summary>
	/// The Unity-based PRISM bootstrapper.
	/// </summary>
	public sealed class Bootstrapper : UnityBootstrapper {

		/// <summary>
		/// <see cref="UnityBootstrapper.ConfigureContainer"/>
		/// </summary>
		protected override void ConfigureContainer() {
			base.ConfigureContainer();
			// Set up logging
			log4net.Config.XmlConfigurator.Configure();
			// Load unity configuration from the config file
			Container.LoadConfiguration();
		}

		/// <summary>
		/// <see cref="Bootstrapper.ConfigureModuleCatalog"/>
		/// </summary>
		protected override void ConfigureModuleCatalog() {
			base.ConfigureModuleCatalog();
			ModuleCatalog moduleCatalog = (ModuleCatalog) ModuleCatalog;
			moduleCatalog.AddModule( typeof( MyModuleModule ) );
		}

		/// <summary>
		/// <see cref="Bootstrapper.CreateShell"/>
		/// </summary>
		/// <returns></returns>
		protected override DependencyObject CreateShell() {
			return new Shell();
		}

		/// <summary>
		/// <see cref="Bootstrapper.InitializeShell"/>
		/// </summary>
		protected override void InitializeShell() {
			base.InitializeShell();
			Application.Current.MainWindow = (Window) Shell;
			Application.Current.MainWindow.Show();
		}

	}
}
