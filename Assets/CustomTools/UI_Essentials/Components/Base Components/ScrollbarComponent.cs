using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
	public abstract class ScrollbarComponent : Scrollbar, IComponent<Scrollbar>
	{
		protected override void Awake()
		{
			base.Awake();
			onValueChanged.AddListener(OnValueChanged);
		}

		protected abstract void OnValueChanged(float value);
	}
}