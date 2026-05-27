using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [Header("Atributos")]
    [SerializeField] float speed;
    [SerializeField] public float lifeTime;

    public bool canMove;
    bool canMoveLeft;
    bool canMoveRight;
    bool canMoveUp;
    bool canMoveDown;

    public static PlayerController instance;

    [Header("Componentes externos")]
    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameManager gameManager;

    private void Awake()
    {
        canMove = true;
        canMoveLeft = false;
        canMoveRight = false;

        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gameManager = GetComponent<GameManager>();
        gameManager = FindAnyObjectByType<GameManager>();
        speed += gameManager.speedBonus;
        lifeTime += gameManager.timerBonus;
    }
    void Start()
    {

    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (canMove)
        {
            if (canMoveLeft && !canMoveRight && !canMoveUp && !canMoveDown)
            {
                rb.linearVelocityX = -speed;
            }

            else if (!canMoveLeft && canMoveRight && !canMoveUp && !canMoveDown)
            {
                rb.linearVelocityX = speed;
            }
            else if (!canMoveLeft && !canMoveRight && canMoveUp && !canMoveDown)
            {
                rb.linearVelocityY = speed;
            }
            else if (!canMoveLeft && !canMoveRight && !canMoveUp && canMoveDown)
            {
                rb.linearVelocityY = -speed;
            }
            else
            {
                rb.linearVelocityX = 0f;
                rb.linearVelocityY = 0f;
            }
        }
    }

    public void MoveLeft()
    {
        canMoveLeft = true;
    }
    public void StopMoveLeft()
    {
        canMoveLeft = false;
    }
    public void MoveRight()
    {
        canMoveRight = true;
    }
    public void StopMoveRight()
    {
        canMoveRight = false;
    }
    public void MoveUp()
    {
        canMoveUp = true;
    }
    public void StopMoveUp()
    {
        canMoveUp = false;
    }
    public void MoveDown()
    {
        canMoveDown = true;
    }
    public void StopMoveDown()
    {
        canMoveDown = false;
    }
}

