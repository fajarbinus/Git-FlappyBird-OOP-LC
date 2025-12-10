using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject gameOverPanel;

    [Header("UI Texts")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreTextRealtime;


   public static UIManager Instance { get; private set;}    

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

    public void UpdateScoreDisplay(int currentScore)
    {
        if (scoreTextRealtime != null)
        {
            scoreTextRealtime.text = currentScore.ToString();
        }
    }

    private void Start()
    {
        ShowStartPanel();
        HideGameOverPanel();
    }

    public void ShowStartPanel()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(true);
        }
    }

    public void HideStartPanel()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(false);
        }
    }

    public void ShowGameOverPanel(int finalScore)
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        if (scoreText != null)
        {
            scoreText.text = finalScore.ToString();
        }
    }

    public void HideGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }


}
