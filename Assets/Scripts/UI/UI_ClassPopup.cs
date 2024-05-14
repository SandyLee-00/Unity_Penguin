using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ClassPopup : UI_Popup
{
    [SerializeField]
    Button PenguinButton;

    [SerializeField]
    Button WizardButton;


    void Start()
    {
        Button penguinButtonComponent = PenguinButton.GetComponent<Button>();
        penguinButtonComponent.onClick.AddListener(OnClickPenguinButton);

        Button wizardButtonComponent = WizardButton.GetComponent<Button>();
        wizardButtonComponent.onClick.AddListener(OnClickWizardButton);
    }

    void Update()
    {
        
    }

    void OnClickPenguinButton()
    {
        Managers.GM.Class = Define.PlayerClassType.Penguin;

        // UI_ClassPopup ´Ý±â
        gameObject.SetActive(false);
        
        Managers.Instance.RefreshUI();
        Managers.Instance.Player.GetComponent<PlayerAnimationController>().Init();
        Managers.Instance.Player.GetComponent<PlayerMovement>().Init();

    }

    void OnClickWizardButton()
    {
        Managers.GM.Class = Define.PlayerClassType.Wizard;

        // UI_ClassPopup ´Ý±â
        gameObject.SetActive(false);

        Managers.Instance.RefreshUI();
        Managers.Instance.Player.GetComponent<PlayerAnimationController>().Init();
        Managers.Instance.Player.GetComponent<PlayerMovement>().Init();
    }

    public void RefreshUI()
    {

    }
}
