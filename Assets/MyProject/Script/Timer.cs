using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] float currentTime;


    [Header("Outros componentes/objetos")]
    [SerializeField] Slider slider;
    [SerializeField] public PlayerController playerController;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        playerController = FindObjectOfType<PlayerController>();
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
    }
}
