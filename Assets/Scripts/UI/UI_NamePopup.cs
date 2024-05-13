using System;
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
    [SerializeField]
    Image PlayerImage;

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

        // UI_NamePopup ´Ý±â
        gameObject.SetActive(false);

        GameManager.GM.RefreshUI();
        GameManager.GM.Player.GetComponent<PlayerAnimationController>().Init();
        GameManager.GM.Player.GetComponent<PlayerMovement>().Init();
    }

    public void RefreshUI()
    {
        if (GameManager.GM.Class == Define.PlayerClassType.Penguin)
        {
            PlayerImage.sprite = Resources.Load<Sprite>("Sprites/penguin_idle_01");
        }
        else if (GameManager.GM.Class == Define.PlayerClassType.Wizard)
        {
            PlayerImage.sprite = Resources.Load<Sprite>("Sprites/Angie");
            PlayerImage.rectTransform.localScale = new Vector3(1.8f, 3f, 1f);
        }
    }
}
