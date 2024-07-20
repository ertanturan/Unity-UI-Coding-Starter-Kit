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