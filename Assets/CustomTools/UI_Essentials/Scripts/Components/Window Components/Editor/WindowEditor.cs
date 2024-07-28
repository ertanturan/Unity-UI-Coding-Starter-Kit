// Created by : Ertan TURAN
// Created : 28 / 07 / 2024
// Last change : 28 / 07 / 2024
// File Name : WindowEditor.cs
// Project Name : CustomTools.UI_Essentials

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Window), true)]
public class WindowEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		if (EditorApplication.isPlaying)
		{
			Window window = (Window) target;
			EditorGUILayout.BeginHorizontal();

			if (window.IsWindowsShown)
			{
				if (GUILayout.Button("Hide"))
				{
					window.Hide();
				}
			}
			else if (GUILayout.Button("Show"))
			{
				window.Show();
			}

			EditorGUILayout.EndHorizontal();
		}
	}
}