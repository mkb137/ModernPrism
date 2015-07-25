using System;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace ModernPrism.Modules.MyModule {

	/// <summary>
	/// The Prism module definition.
	/// </summary>
	public sealed class MyModuleModule : IModule {
		/// <summary>
		/// The application-level container.
		/// </summary>
		// ReSharper disable once NotAccessedField.Local
		private readonly IUnityContainer	_container;
		/// <summary>
		/// The application-level region manager.
		/// </summary>
		// ReSharper disable once NotAccessedField.Local
		private readonly IRegionManager		_regionManager;

		/// <summary>
		/// The constructor. Parameter values will be injected via Unity.
		/// </summary>
		/// <param name="regionManager"></param>
		/// <param name="container"></param>
		public MyModuleModule( IRegionManager regionManager, IUnityContainer container ) {
			this._regionManager = regionManager;
			this._container		= container;
		}

		/// <summary>
		/// <see cref="IModule.Initialize"/>
		/// </summary>
		public void Initialize() {
//			this._regionManager.RegisterViewWithRegion( RegionNames.MainRegion, typeof( AnnularFlowRegimeSetup ) );
		}
	}
}
