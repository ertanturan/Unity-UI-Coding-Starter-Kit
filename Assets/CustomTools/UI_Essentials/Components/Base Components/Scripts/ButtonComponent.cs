using UnityEngine;
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