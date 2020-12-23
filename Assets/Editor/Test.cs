using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test : MonoBehaviour
{
    [MenuItem("Build/BuildApk")]
    public static void BuildApk()
    {
        TestBuild.BuildApk();
    }

}
