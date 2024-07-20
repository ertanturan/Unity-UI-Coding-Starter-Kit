// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : InputFieldComponent.cs
// Project Name : CustomTools.UI_Essentials

using TMPro;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class InputFieldComponent : TMP_InputField, IComponent<TMP_InputField>
	{
		protected override void Awake()
		{
			base.Awake();
			onValueChanged.AddListener(OnValueChanged);
			onEndEdit.AddListener(OnEndEdit);
			onSelect.AddListener(OnSelect);
			onDeselect.AddListener(OnDeselect);
		}

		protected abstract void OnValueChanged(string value);
		protected abstract void OnEndEdit(string value);
		protected abstract void OnSelect(string value);
		protected abstract void OnDeselect(string value);
	}
}