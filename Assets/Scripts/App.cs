using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    public static UiView UiView;

    private void Start()
    {
        UiView = GetComponent<UiView>();
    }
}
