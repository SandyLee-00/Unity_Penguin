using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    [SerializeField] private float cameraSpeed = 0f;

    private void Awake()
    {
        player = GameManager.gameManager.Player;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void LateUpdate()
    {
        if (player.IsValid() == false) return;

        Vector3 targetPosition = player.transform.position;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed);
        
    }
}
