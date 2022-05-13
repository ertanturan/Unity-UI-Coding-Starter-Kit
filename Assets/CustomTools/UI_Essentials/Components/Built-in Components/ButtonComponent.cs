using UnityEngine;
using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonComponent : BaseComponent<Button>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onClick.AddListener(OnButtonClicked);
        }

        protected abstract void OnButtonClicked();
    }
}