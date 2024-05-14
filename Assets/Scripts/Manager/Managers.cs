using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static Define;


public class Managers : MonoBehaviour
{
    public static Managers s_instance = null;

    private static UIManager s_uiManager = new UIManager();
    private static GameManagerEX s_gameManager = new GameManagerEX();

    public static Managers Instance { get { return s_instance; } }
    public static GameManagerEX GM { get { Init(); return s_gameManager; } }
    public static UIManager UI { get { Init(); return s_uiManager; } }

    // TODO
    public GameObject Player { get; private set; }
    [SerializeField]
    private string playerTag;

    // TODO : 일단 다 갖고있는 UI 올리기 -> UI_Manager로 옮기기
    [SerializeField]
    GameObject UI_NameWorldSpace;
    [SerializeField]
    GameObject UI_ClassPopup;
    [SerializeField]
    GameObject UI_NamePopup;
    

    private void Awake()
    {
        if (s_instance != null)
        {
            Destroy(gameObject);
        }

        s_instance = this;

        // TODO :
        Player = GameObject.FindGameObjectWithTag(playerTag);
    }

    void Start()
    {
        Init();
    }

    // TODO :
    public void RefreshUI()
    {
        UI_NameWorldSpace.GetComponent<UI_NameWorldSpace>().RefreshUI();
        UI_ClassPopup.GetComponent<UI_ClassPopup>().RefreshUI();
        UI_NamePopup.GetComponent<UI_NamePopup>().RefreshUI();
    }

    private static void Init()
    {
        if(s_instance == null)
        {
            GameObject _gameObject = GameObject.Find("@Managers");
            if (_gameObject == null)
            {
                _gameObject = new GameObject { name = "@Managers" };
            }
            s_instance = Utils.GetOrAddComponent<Managers>(_gameObject);
            DontDestroyOnLoad(_gameObject);

            // UI, Game은 Init 여기서 안한다

            Application.targetFrameRate = 60;
        }
    }
}
