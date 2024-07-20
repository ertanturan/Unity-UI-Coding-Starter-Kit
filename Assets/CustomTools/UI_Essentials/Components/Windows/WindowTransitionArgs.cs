// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : WindowTransitionArgs.cs
// Project Name : CustomTools.UI_Essentials

public class WindowTransitionArgs
{
	public bool ShouldShow { get; set; }

	public WindowTransitionArgs(bool shouldShow)
	{
		ShouldShow = shouldShow;
	}
}