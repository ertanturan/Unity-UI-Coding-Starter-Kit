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