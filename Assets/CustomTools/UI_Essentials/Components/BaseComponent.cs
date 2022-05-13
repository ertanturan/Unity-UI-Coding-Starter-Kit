using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseComponent<T> : MonoBehaviour where T : Selectable
{
    public  T Component { get => _component; private set => _component = value; }
    private T _component;

    protected virtual void Awake()
    {
        Component = GetComponent<T>();
    }
}