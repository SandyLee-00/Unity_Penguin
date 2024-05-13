using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;
    PlayerInputController playerInputController;

    private static readonly int playerState = Animator.StringToHash("playerState");
    private static readonly float magnitudeThreshold = 0.5f;

    [SerializeField]
    GameObject PenguinSprite;
    [SerializeField]
    GameObject WizardSprite;

    private void Awake()
    {
        animator = PenguinSprite.GetComponentInChildren<Animator>();
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

    public void Init()
    {
        if (GameManager.GM.Class == Define.PlayerClassType.Penguin)
        {
            PenguinSprite.SetActive(true);
            WizardSprite.SetActive(false);

            animator = PenguinSprite.GetComponent<Animator>();

        }
        else if (GameManager.GM.Class == Define.PlayerClassType.Wizard)
        {
            PenguinSprite.SetActive(false);
            WizardSprite.SetActive(true);

            animator = WizardSprite.GetComponent<Animator>();
        }
    }

}
