using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// InputSystem �̺�Ʈ �޾Ƽ� �÷��̾��� �̺�Ʈ�� ȣ�� 
/// �ʿ��� ������ �÷��̾� �̺�Ʈ �����س��� 
/// </summary>
public class PlayerInputController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 mousePosition = value.Get<Vector2>();
        Vector2 worldPosition = _camera.ScreenToWorldPoint(mousePosition);
        Vector2 thisToMouseDirection = (worldPosition - (Vector2)transform.position).normalized;

        CallLookEvent(thisToMouseDirection);
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
