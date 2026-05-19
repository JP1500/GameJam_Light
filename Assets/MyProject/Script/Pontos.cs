using UnityEngine;
using TMPro;

public class Pontos : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pontos;
    public int score;
    public static Pontos instance;
    [SerializeField] GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        instance = this;
        UpdateScore();
    }
    public void AddScore()
    {
        score++;

        Debug.Log("Pontos: " + score);

        UpdateScore();
    }
    void UpdateScore()
    {
        pontos.text = score.ToString("00");
    }

  private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("lixo"))
        {
            AddScore();
        }
    }
}

