namespace Microsoft.Maui.Controls.Compatibility.Platform.Android
{
	[PortHandler]
	internal enum AndroidApplicationLifecycleState
	{
		Uninitialized,
		OnCreate,
		OnStart,
		OnResume,
		OnPause,
		OnStop,
		OnRestart,
		OnDestroy
	}
}