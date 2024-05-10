using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public GameObject Player { get; private set; }
    [SerializeField] private string playerTag;

    // TODO : ObjectPool ¸¸µé±â 
    /*public ObjectPool ObjectPool { get; private set; }*/

    private void Awake()
    {
        if (gameManager != null)
        {
            Destroy(gameObject);
        }
        gameManager = this;

        Player = GameObject.FindGameObjectWithTag(playerTag);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
