using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;
    PlayerInputController playerInputController;

    private static readonly int playerState = Animator.StringToHash("playerState");
    private static readonly float magnitudeThreshold = 0.5f;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        playerInputController = GetComponent<PlayerInputController>();
    }

    private void Start()
    {
        playerInputController.OnMoveEvent += Walking;
    }

    private void Walking(Vector2 direction)
    {
        if (direction.magnitude > magnitudeThreshold)
        {
            animator.SetInteger(playerState, (int)Define.PlayerState.Moving);
        }
        else
        {
            animator.SetInteger(playerState, (int)Define.PlayerState.Idle);
        }
    }
}
