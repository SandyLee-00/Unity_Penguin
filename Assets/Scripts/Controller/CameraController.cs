using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    private void Awake()
    {

    }

    void Start()
    {
        player = Managers.s_instance.Player;
    }

    void Update()
    {

    }

    private void LateUpdate()
    {
        if (player.IsValid() == false) return;

        Vector3 targetPosition = player.transform.position;
        targetPosition.z = transform.position.z;

        // transform.position = targetPosition;
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.5f);
    }
}
