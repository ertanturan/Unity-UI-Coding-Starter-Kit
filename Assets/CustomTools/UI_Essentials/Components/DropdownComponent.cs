using UnityEngine;

namespace CustomTools.UI_Essentials.Components
{
    using System;
    using TMPro;
    using UnityEngine.UI;

    [RequireComponent(typeof(Dropdown))]
    public abstract class DropdownComponent : BaseComponent<Dropdown>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
        }

        protected abstract void OnValueChanged(int value);
    }
}