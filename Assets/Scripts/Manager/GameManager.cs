using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static Define;


[Serializable]
public class GameData
{
    public string Name;
    public PlayerClassType PlayerClass;
}

public class GameManager : MonoBehaviour
{
    public static GameManager s_instance = null;
    public static GameManager GM { get { return s_instance; } }

    public GameObject Player { get; private set; }
    [SerializeField]
    private string playerTag;

    GameData _gameData = new GameData();

    // TODO : 일단 다 갖고있는 UI 올리기 -> UI_Manager로 옮기기
    [SerializeField]
    GameObject UI_NameWorldSpace;
    [SerializeField]
    GameObject UI_ClassPopup;
    [SerializeField]
    GameObject UI_NamePopup;
    

    #region 스탯
    public string Name
    {
        get { return _gameData.Name; }
        set { _gameData.Name = value; }
    }

    public PlayerClassType Class
    {
        get { return _gameData.PlayerClass; }
        set { _gameData.PlayerClass = value; }
    }
    #endregion

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
        UI_NameWorldSpace.GetComponent<UI_NameWorldSpace>().RefreshUI();
        UI_ClassPopup.GetComponent<UI_ClassPopup>().RefreshUI();
        UI_NamePopup.GetComponent<UI_NamePopup>().RefreshUI();

    }

    public void Init()
    {
        Name = "Player";
        Class = PlayerClassType.Penguin;
    }
}
