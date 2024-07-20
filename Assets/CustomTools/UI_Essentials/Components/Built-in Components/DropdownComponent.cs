using TMPro;

namespace CustomTools.UI_Essentials.Components
{
    using UnityEngine;

    [RequireComponent(typeof(TMP_Dropdown))]
    public abstract class DropdownComponent : BaseComponent<TMP_Dropdown>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
        }

        protected abstract void OnValueChanged(int value);
    }
}