using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_NamePopup : MonoBehaviour
{
    [SerializeField]
    TMP_InputField InputField;
    [SerializeField]
    Button ConfirmButton;

    void Start()
    {
        Button confirmButtonComponent = ConfirmButton.GetComponent<Button>();
        confirmButtonComponent.onClick.AddListener(OnClickConfirmButton);
    }

    void Update()
    {
        
    }

    void OnClickConfirmButton()
    {
        if (InputField.text.Length <= 1 || InputField.text.Length >= 11) return;

        GameManager.GM.Name = InputField.text;

        // UI_NamePopup �ݱ�
        Destroy(gameObject);
        GameManager.GM.RefreshUI();
    }
}