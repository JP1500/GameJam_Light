using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] float currentTime;


    [Header("Outros componentes/objetos")]
    [SerializeField] Slider slider;
    [SerializeField] public PlayerController playerController;

    [SerializeField] public string sceneName;

    [Header("Aqui estou apenas fazendo um teste")]
    [SerializeField] public SceneManager sceneManager;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        playerController = FindAnyObjectByType<PlayerController>();
        slider.maxValue = playerController.lifeTime;
        currentTime = playerController.lifeTime;
    }
    void Update()
    {
        if (currentTime >= 0)
        {
            currentTime -= Time.deltaTime;

            slider.value = currentTime;
        }

        else if (currentTime <= 0)
        {
            Debug.Log("Carregando cena");
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
