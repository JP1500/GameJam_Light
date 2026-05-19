using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] int totalPoints;
    [SerializeField] Pontos pontos;

    [SerializeField] TextMeshProUGUI textPoints;

    [SerializeField] GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        pontos = FindObjectOfType<Pontos>();
    }

    void Update()
    {
        textPoints.text = totalPoints.ToString("00");
    }
}
