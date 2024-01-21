using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TMP_Text scoreText; // ������ ����� UI �ؽ�Ʈ

    // Awake �޼��� ��� Start �޼��带 ����մϴ�.
    private void Start()
    {
        // GameManager.instance�� null�� �ƴ��� Ȯ���ϰ� �� �Ŀ� score�� ���������� �մϴ�.
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

    // ���� �ؽ�Ʈ ����
    public void UpdateScoreText(int newScore)
    {
        scoreText.text = newScore+"";
    }
}
