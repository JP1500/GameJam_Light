using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [Header("Valor do upgrade")]
    [SerializeField] int value;

    [Header("Bonus do upgrade")]
    [SerializeField] float timerBonus;
    [SerializeField] int pointBonus;
    [SerializeField] float speedBonus;

    [Header("Componentes externos")]
    [SerializeField] public GameManager gameManager;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    public void OnClick()
    {
        if (gameManager.totalPoints >= value)
        {
            gameManager.totalPoints -= value;
            gameManager.timerBonus += timerBonus;
            gameManager.pointBonus += pointBonus;
            gameManager.speedBonus += speedBonus;
            Destroy(gameObject);
        }
    }
}
