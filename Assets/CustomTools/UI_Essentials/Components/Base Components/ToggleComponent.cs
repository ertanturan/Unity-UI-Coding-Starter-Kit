using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    using UnityEngine;

    [RequireComponent(typeof(Toggle))]
    public abstract class ToggleComponent : BaseComponent<Toggle>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
        }

        protected abstract void OnValueChanged(bool value);
    }
}