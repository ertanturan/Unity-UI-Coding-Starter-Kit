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

		public TMP_Dropdown Component
		{
			get;
			set;
		}

		protected abstract void OnValueChanged(int value);
	}
}