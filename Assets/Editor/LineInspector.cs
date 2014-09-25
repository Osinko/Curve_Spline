using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(Line))]
public class LineInspector : Editor
{
		void OnSceneGUI ()
		{
				Line line = target as Line;

				Transform handleTransform = line.transform;

				Quaternion handleRotaiton = Tools.pivotRotation == PivotRotation.Local ? handleTransform.rotation : Quaternion.identity;
				//unityツールのpivot回転設定がローカルならLineオブジェクトの回転にする。それ以外は初期値に

				Vector3 p0 = handleTransform.TransformPoint (line.p0);	//ワールド座標にTransformのローカルを加算
				Vector3 p1 = handleTransform.TransformPoint (line.p1);

				Handles.color = Color.white;
				Handles.DrawLine (p0, p1);						//ラインを表示
				Handles.DoPositionHandle (p0, handleRotaiton);	//位置ハンドルを表示
				Handles.DoPositionHandle (p1, handleRotaiton);
		}

}
