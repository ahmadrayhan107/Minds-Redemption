using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float countdownTime = 7f;
    private float currentTime;

    public TextMeshProUGUI timerText;

    private bool isTimerRunning = false;

    private void Start()
    {
        StartTimer();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            UpdateTimer();
        }
    }

    private void StartTimer()
    {
        currentTime = countdownTime;
        isTimerRunning = true;
    }

    private void UpdateTimer()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            isTimerRunning = false;
            // Panggil fungsi atau lakukan aksi ketika timer mencapai 0
        }

        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int seconds = Mathf.CeilToInt(currentTime);
        timerText.text = seconds.ToString();
    }
}
