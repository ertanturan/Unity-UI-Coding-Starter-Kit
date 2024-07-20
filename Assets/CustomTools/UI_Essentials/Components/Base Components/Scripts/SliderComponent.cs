// Created by : Ertan TURAN
// Created : 20 / 07 / 2024
// Last change : 20 / 07 / 2024
// File Name : SliderComponent.cs
// Project Name : CustomTools.UI_Essentials

using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class SliderComponent : Slider, IComponent<Slider>
	{
		protected override void Awake()
		{
			base.Awake();
			onValueChanged.AddListener(OnValueChanged);
		}

		protected abstract void OnValueChanged(float value);
	}
}