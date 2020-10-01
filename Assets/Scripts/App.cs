using Assets.Scripts.Core;
using UnityEngine;

public class App : MonoBehaviour
{
    public static UiView UiView;
    public static Models Models;

    private void Awake()
    {
        UiView = GetComponentInChildren<UiView>();
        Models = GetComponentInChildren<Models>();
    }
}
