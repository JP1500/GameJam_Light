using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] PlayerController playerController;

    [SerializeField] float timer;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        slider.maxValue = playerController.lifeTime;
    }
    void Update()
    {
        slider.value = timer;

    }
}
