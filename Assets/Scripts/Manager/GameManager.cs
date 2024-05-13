using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GameManager : MonoBehaviour
{
    public static GameManager s_instance = null;
    public static GameManager GM { get { return s_instance; } }

    public GameObject Player { get; private set; }
    [SerializeField] private string playerTag;

    public string Name { get; set; }

    private void Awake()
    {
        if (s_instance != null)
        {
            Destroy(gameObject);
        }

        s_instance = this;

        Player = GameObject.FindGameObjectWithTag(playerTag);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RefreshUI()
    {
        Player.GetComponentInChildren<UI_NameWorldSpace>().RefreshUI();
    }
}
