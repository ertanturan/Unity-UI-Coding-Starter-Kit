// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 28 / 07 / 2024
// File Name : Window.cs
// Project Name : CustomTools.UI_Essentials

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Canvas))]
public abstract class Window : MonoBehaviour, IWindow, IDragHandler
{
	// ReSharper disable once InconsistentNaming
	public UnityEvent<bool> OnWindowHid;

	// ReSharper disable once InconsistentNaming
	public UnityEvent<bool> OnWindowShown;

	[field: SerializeField]
	protected float TransitionDuration = 1f;

	private readonly WindowTransitionArgs _hideArgs = new WindowTransitionArgs(false);
	private readonly WindowTransitionArgs _showArgs = new WindowTransitionArgs(true);
	private bool _isWindowsShown;
	protected Canvas WindowCanvas;

	protected RectTransform WindowRectTransform;

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

	public void OnDrag(PointerEventData eventData)
	{
		WindowRectTransform.anchoredPosition = WindowRectTransform.anchoredPosition + eventData.delta;
	}

	[field: SerializeField]
	public bool ShowAtStart
	{
		get;
		set;
	} = true;

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


	public virtual void Initialize()
	{
		WindowRectTransform = GetComponent<RectTransform>();
		WindowCanvas = GetComponent<Canvas>();
	}

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