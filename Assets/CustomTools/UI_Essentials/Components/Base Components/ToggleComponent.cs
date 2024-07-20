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

		public Toggle Component
		{
			get;
			set;
		}

		protected abstract void OnValueChanged(bool value);
	}
}