using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ClassPopup : MonoBehaviour
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
        GameManager.GM.Class = Define.PlayerClassType.Penguin;

        // UI_ClassPopup ´Ý±â
        gameObject.SetActive(false);
        
        GameManager.GM.RefreshUI();
        GameManager.GM.Player.GetComponent<PlayerAnimationController>().Init();
        GameManager.GM.Player.GetComponent<PlayerMovement>().Init();

    }

    void OnClickWizardButton()
    {
        GameManager.GM.Class = Define.PlayerClassType.Wizard;

        // UI_ClassPopup ´Ý±â
        gameObject.SetActive(false);

        GameManager.GM.RefreshUI();
        GameManager.GM.Player.GetComponent<PlayerAnimationController>().Init();
        GameManager.GM.Player.GetComponent<PlayerMovement>().Init();
    }

    public void RefreshUI()
    {

    }
}
