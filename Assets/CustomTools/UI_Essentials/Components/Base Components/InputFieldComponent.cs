using TMPro;

namespace CustomTools.UI_Essentials.Components
{
    using UnityEngine;

    [RequireComponent(typeof(TMP_InputField))]
    public abstract class InputFieldComponent : BaseComponent<TMP_InputField>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
            Component.onEndEdit.AddListener(OnEndEdit);
            Component.onSelect.AddListener(OnSelect);
            Component.onDeselect.AddListener(OnDeselect);
        }

        protected abstract void OnValueChanged(string value);
        protected abstract void OnEndEdit(string      value);
        protected abstract void OnSelect(string       value);
        protected abstract void OnDeselect(string     value);
    }
}