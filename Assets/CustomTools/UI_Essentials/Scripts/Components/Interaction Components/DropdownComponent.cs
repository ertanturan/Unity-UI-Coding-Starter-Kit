// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : DropdownComponent.cs
// Project Name : CustomTools.UI_Essentials

using TMPro;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class DropdownComponent : TMP_Dropdown, IComponent<TMP_Dropdown>
	{
		protected override void Awake()
		{
			base.Awake();
			onValueChanged.AddListener(OnValueChanged);
		}

		protected abstract void OnValueChanged(int value);
	}
}