// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : ToggleComponent.cs
// Project Name : CustomTools.UI_Essentials

using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class ToggleComponent : Toggle, IComponent<Toggle>
	{
		protected override void Awake()
		{
			base.Awake();
			onValueChanged.AddListener(OnValueChanged);
		}

		protected abstract void OnValueChanged(bool value);
	}
}