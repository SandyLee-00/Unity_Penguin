using System;
using UnityEngine;

/// <summary>
/// 플레이의 이동, Look에 따라 스프라이트 좌우 뒤집기 
/// </summary> 
public class PlayerMovement : MonoBehaviour
{
    private PlayerInputController playerInputController;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer spriteRenderer;

    private Vector2 movementDirection = Vector2.zero;

    const float speed = 12f;

    [SerializeField]
    GameObject PenguinSprite;
    [SerializeField]
    GameObject WizardSprite;

    private void Awake()
    {
        playerInputController = GetComponent<PlayerInputController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        playerInputController.OnMoveEvent += SetMovementDirection;
        playerInputController.OnLookEvent += SetLookDirection;
    }

    private void FixedUpdate()
    {
        // TODO : stat 만들면 speed 바꾸기 
        _rigidbody2D.velocity = movementDirection * speed;
    }

    private void SetMovementDirection(Vector2 directionVector)
    {
        movementDirection = directionVector;
    }

    private void SetLookDirection(Vector2 directionVector)
    {
        float DegreeOfDirectionVector = Mathf.Atan2(directionVector.y, directionVector.x) * Mathf.Rad2Deg;
        spriteRenderer.flipX = Mathf.Abs(DegreeOfDirectionVector) > 90f;
    }

    public void Init()
    {
        if (Managers.GM.Class == Define.PlayerClassType.Penguin)
        {
            spriteRenderer = PenguinSprite.GetComponent<SpriteRenderer>();
        }
        else if (Managers.GM.Class == Define.PlayerClassType.Wizard)
        {
            spriteRenderer = WizardSprite.GetComponent<SpriteRenderer>();
        }
    }
}
