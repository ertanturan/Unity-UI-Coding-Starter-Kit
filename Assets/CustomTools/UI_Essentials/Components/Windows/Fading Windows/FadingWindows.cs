using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class FadingWindows : Window
{
	private CanvasGroup _canvasGroup;

	public override void Initialize()
	{
		_canvasGroup = GetComponent<CanvasGroup>();
	}

	public override void Setup()
	{
		_canvasGroup.blocksRaycasts = true;
	}

	public override void TearDown()
	{
		_canvasGroup.blocksRaycasts = false;
	}

	protected override IEnumerator ExecuteTransition(WindowTransitionArgs args, Action callback)
	{
		float targetAlpha = args.ShouldShow ? 1 : 0;
		float startAlpha = _canvasGroup.alpha;
		float elapsedTime = 0f;

		while (elapsedTime < TransitionDuration)
		{
			_canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / TransitionDuration);
			elapsedTime += Time.deltaTime;
			yield return null;
		}

		_canvasGroup.alpha = targetAlpha;
		callback?.Invoke();
	}
}