using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int totalPoints;
    [SerializeField] Pontos pontos;

    [SerializeField] GameManager instance;
    private void Awake()
    {
        instance = this;

        if (instance != null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("Fui apagado");
            Destroy(gameObject);
        }

        pontos = FindAnyObjectByType<Pontos>();

        pontos.score = 0;
        totalPoints += pontos.score;
    }

    private void Update()
    {
        totalPoints = pontos.score;
    }
}
