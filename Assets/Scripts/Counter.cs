using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private int _maxTime;

    public Text CounterText;
    public Text TimerText;
    public Text EndText;
    private int _count;
    private int _remainingTime;
    public bool IsGameActive;


    private void Awake()
    {
        _count = 0;
        _remainingTime = _maxTime;
        IsGameActive = true;
    }
    private void Start()
    {
        StartCoroutine(ScoreRoutine());
        StartCoroutine(TimerRoutine());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsGameActive)
        {
            _count++;
        }
    }

    IEnumerator ScoreRoutine()
    {
        while (IsGameActive)
        {
            CounterText.text = "Score : " + _count;
            yield return null;
        }
    }

    IEnumerator TimerRoutine()
    {
        while (_remainingTime > 0)
        {
            _remainingTime--;
            TimerText.text = "Time: " + _remainingTime;
            yield return new WaitForSeconds(1.0f);
        }
        GameOver();
    }

    private void GameOver()
    {
        EndText.gameObject.SetActive(true);
        IsGameActive = false;
    }
}
