using System;

public class WindowEventArgs : EventArgs
{
	public bool IsShown { get; private set; }

	public WindowEventArgs(bool isShown)
	{
		IsShown = isShown;
	}
}