// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : WindowEventArgs.cs
// Project Name : CustomTools.UI_Essentials

using System;

public class WindowEventArgs : EventArgs
{
	public bool IsShown { get; private set; }

	public WindowEventArgs(bool isShown)
	{
		IsShown = isShown;
	}
}