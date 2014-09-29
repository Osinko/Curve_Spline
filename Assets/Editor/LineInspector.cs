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

				EditorGUI.BeginChangeCheck ();
				p0 = Handles.DoPositionHandle (p0, handleRotaiton);				//p0にはハンドルの位置（つまりワールド座標がはいる）
				if (EditorGUI.EndChangeCheck ()) {
						Undo.RecordObject (line, "Move point");					//Undoにlineの状態を記録
						EditorUtility.SetDirty (line);							//オブジェクトのパラメータを保存するフラグを立てます
						line.p0 = handleTransform.InverseTransformPoint (p0);	//位置をワールド座標からローカル座標へ変換して代入している
				}

				EditorGUI.BeginChangeCheck ();
				p1 = Handles.DoPositionHandle (p1, handleRotaiton);
				if (EditorGUI.EndChangeCheck ()) {
						Undo.RecordObject (line, "Move point");
						EditorUtility.SetDirty (line);
						line.p1 = handleTransform.InverseTransformPoint (p1);
				}

		}
}