using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class URPToonShaderChanger : MonoBehaviour
{
    [MenuItem("Assets/ChangeURPToon")]
    public static void ChangeURPToonShader()
    {
        Shader shader = Shader.Find("SimpleURPToonLitExample(With Outline)");
        foreach (var obj in Selection.objects)
        {
            if (obj.GetType() == typeof(Material)) { 
                Material mat = (Material)obj;
                if (mat.shader == shader) continue;
                Texture tex = mat.mainTexture;
                Debug.Log(tex);
                mat.shader = shader;
                mat.mainTexture = tex;
                EditorUtility.SetDirty(mat);
            }
        }
    }
}
