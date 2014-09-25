using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(Line))]
public class LineInspector : Editor
{
		void OnSceneGUI ()
		{
				Line line = target as Line;
		
				Handles.color = Color.white;
				Handles.DrawLine (line.p0, line.p1);
		}
}
