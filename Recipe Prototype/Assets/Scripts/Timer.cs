using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private float _timer;
    private bool _counting = false;
    
    // Update is called once per frame
    void Update()
    {
        CountDown();
    }

    void CountDown()
    {
        _counting = true;
        if (_counting)
        {
            _timer -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(_timer / 60f);
            int seconds = Mathf.FloorToInt(_timer % 60f);
            int milliseconds = Mathf.FloorToInt((_timer * 100f) % 100f);
            _timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }
    }
}
