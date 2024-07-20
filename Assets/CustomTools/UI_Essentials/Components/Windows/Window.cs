using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public abstract class Window : MonoBehaviour, IWindow
{
	// ReSharper disable once InconsistentNaming
	public UnityEvent<bool> OnWindowHid;

	// ReSharper disable once InconsistentNaming
	public UnityEvent<bool> OnWindowShown;

	[field: SerializeField]
	protected float TransitionDuration = 1f;

	public bool ToggleHandle
	{
		set
		{
			if (value)
			{
				Hide();
			}
			else
			{
				Show();
			}
		}
	}

	readonly private WindowTransitionArgs _hideArgs = new WindowTransitionArgs(false);
	readonly private WindowTransitionArgs _showArgs = new WindowTransitionArgs(true);
	private bool _isWindowsShown;

	protected void Awake()
	{
		Initialize();
		if (ShowAtStart)
		{
			Show();
		}
		else if (!ShowAtStart)
		{
			Hide();
		}
	}

	[field: SerializeField]
	public bool ShowAtStart
	{
		get;
		set;
	}

	public bool IsWindowsShown
	{
		get => _isWindowsShown;
		set
		{
			if (value == _isWindowsShown)
			{
				return;
			}

			_isWindowsShown = value;
			if (value)
			{
				Setup();
			}

			OnWindowStateChanged?.Invoke(this, new WindowEventArgs(_isWindowsShown));
			if (!value)
			{
				TearDown();
			}
		}
	}

	public event EventHandler<WindowEventArgs> OnWindowStateChanged;

	public abstract void Initialize();
	public abstract void Setup();
	public abstract void TearDown();

	public void Toggle()
	{
		ToggleHandle = !_isWindowsShown;
	}

	[ContextMenu("Show")]
	public virtual void Show()
	{
		Setup();

		void ShowCallback()
		{
			IsWindowsShown = true;
			OnWindowShown?.Invoke(IsWindowsShown);
		}

		StartCoroutine(ExecuteTransition(_showArgs, ShowCallback));
	}

	[ContextMenu("Hide")]
	public virtual void Hide()
	{
		void HideCallback()
		{
			IsWindowsShown = false;
			OnWindowHid?.Invoke(IsWindowsShown);
		}

		StartCoroutine(ExecuteTransition(_hideArgs, HideCallback));
		TearDown();
	}

	protected abstract IEnumerator ExecuteTransition(WindowTransitionArgs args, Action callback);
}