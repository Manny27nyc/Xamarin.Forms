namespace Microsoft.Maui
{
	public abstract class MauiApp : App
	{
		public abstract IWindow GetWindowFor(IActivationState state);

		public MauiApp()
		{
			
		}
	}
}