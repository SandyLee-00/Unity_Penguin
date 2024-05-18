using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_NamePopup : UI_Popup
{
    [SerializeField]
    TMP_InputField InputField;
    [SerializeField]
    Button ConfirmButton;
    [SerializeField]
    Image PlayerImage;

    enum GameObjects
    {
        InputField
    }

    enum Buttons
    {
        ConfirmButton
    }

    TMP_InputField _inputField;

    void Start()
    {
        Button confirmButtonComponent = ConfirmButton.GetComponent<Button>();
        confirmButtonComponent.onClick.AddListener(OnClickConfirmButton);

        Init();
    }

    void Update()
    {
        
    }

    void OnClickConfirmButton()
    {
        if (InputField.text.Length <= 1 || InputField.text.Length >= 11) return;

        Managers.GM.Name = InputField.text;

        // UI_NamePopup ´Ý±â
        gameObject.SetActive(false);

        Managers.Instance.RefreshUI();
        Managers.Instance.Player.GetComponent<PlayerAnimationController>().Init();
        Managers.Instance.Player.GetComponent<PlayerMovement>().Init();
    }

    public void RefreshUI()
    {
        if (Managers.GM.Class == Define.PlayerClassType.Penguin)
        {
            PlayerImage.sprite = Resources.Load<Sprite>("Sprites/penguin_idle_01");
        }
        else if (Managers.GM.Class == Define.PlayerClassType.Wizard)
        {
            PlayerImage.sprite = Resources.Load<Sprite>("Sprites/Angie");
            PlayerImage.rectTransform.localScale = new Vector3(1.8f, 3f, 1f);
        }
    }

    public override bool Init()
    {
        if (base.Init() == false)
        {
            return false;
        }

        BindObject(typeof(GameObjects));

        return true;
    }
}
