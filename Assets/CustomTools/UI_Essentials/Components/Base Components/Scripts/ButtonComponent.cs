// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : ButtonComponent.cs
// Project Name : CustomTools.UI_Essentials

using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class ButtonComponent : Button, IComponent<Button>
	{
		protected override void Awake()
		{
			base.Awake();
			onClick.AddListener(OnButtonClicked);
		}

		protected abstract void OnButtonClicked();
	}
}