using Assets.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiView : MonoBehaviour
{
    [SerializeField] private GameObject lifePanel = null;
    [SerializeField] private GameObject lifePrefab = null;


    public LifePanelBehaviour LifePanelBehaviour { get; private set; }

    private void Awake()
    {
        LifePanelBehaviour = new LifePanelBehaviour(lifePanel, lifePrefab, 3);
    }
}
