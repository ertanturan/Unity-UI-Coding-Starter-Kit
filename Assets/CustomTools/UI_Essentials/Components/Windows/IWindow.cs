using System;

public interface IWindow
{
	public bool ShowAtStart { get; set; }

	public bool IsWindowsShown { get; set; }

	public event EventHandler<WindowEventArgs> OnWindowStateChanged;
	public void Show();
	public void Hide();

	public void Initialize();
	public void Setup();
	public void TearDown();
	public void Toggle();
}