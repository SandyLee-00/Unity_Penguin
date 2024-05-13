using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_NameWorldSpace : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI NameText;

    private void Start()
    {
        NameText.text = GameManager.GM.Name;
    }

    private void Update()
    {
        
    }

    public void RefreshUI()
    {
        NameText.text = GameManager.GM.Name;
    }
}
