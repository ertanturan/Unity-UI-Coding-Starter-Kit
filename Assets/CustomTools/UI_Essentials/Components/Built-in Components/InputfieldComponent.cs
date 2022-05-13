using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    using UnityEngine;

    [RequireComponent(typeof(InputField))]
    public abstract class InputfieldComponent : BaseComponent<InputField>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
            Component.onEndEdit.AddListener(OnEndEdit);
        }

        protected abstract void OnValueChanged(string value);
        protected abstract void OnEndEdit(string      value);
    }
}