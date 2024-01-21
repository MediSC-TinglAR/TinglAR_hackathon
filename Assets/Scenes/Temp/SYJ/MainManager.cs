using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TMP_Text scoreText; // 점수를 출력할 UI 텍스트

    // Awake 메서드 대신 Start 메서드를 사용합니다.
    private void Start()
    {
        // GameManager.instance가 null이 아닌지 확인하고 그 후에 score를 가져오도록 합니다.
        if (GameManager.instance != null)
        {
            int myScore = GameManager.instance.score;
            UpdateScoreText(myScore);
        }
        else
        {
            Debug.LogError("GameManager instance is null. Make sure GameManager is properly initialized.");
        }
    }

    // 점수 텍스트 갱신
    public void UpdateScoreText(int newScore)
    {
        scoreText.text = newScore+"";
    }
}
