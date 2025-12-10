using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{   
    [SerializeField]private int _currentScore = 0;
    public static ScoreManager Instance { get; private set;}
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        //Debug.Log("value" + _currentScore);
        //_currentScore = _currentScore + value;
        _currentScore += value;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateScoreDisplay(_currentScore);
        }
    }

    public int GetCurrentScore()
    {
        return _currentScore;
    }

    public void ResetScore()
    {
        _currentScore = 0;
    }



}
