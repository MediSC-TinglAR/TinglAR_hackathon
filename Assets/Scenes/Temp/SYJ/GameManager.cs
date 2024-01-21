using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


// 게임 오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
// 씬에는 단 하나의 게임 매니저만 존재할 수 있다.
public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 싱글톤을 할당할 전역 변수

    public bool isGameover = false; // 게임 오버 상태
    public TMP_Text scoreText; // 점수를 출력할 UI 텍스트

    public int score = 0; // 게임 점수

    // 게임 시작과 동시에 싱글톤을 구성
    void Awake()
    {
        // 싱글톤 변수 instance가 비어있는가?
        if (instance == null)
        {
            // instance가 비어있다면(null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            // instance에 이미 다른 GameManager 오브젝트가 할당되어 있는 경우
            // 씬에 두개 이상의 GameManager 오브젝트가 존재한다는 의미.
            // 싱글톤 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    // 점수를 증가시키는 메서드
    public void AddScore(int newScore)
    {
        if (isGameover)
        {
            score += newScore;
            //scoreText.text = score.ToString();
        }
    }
    // 게임 오버를 실행하는 메서드
    public void OnPlayerDead()
    {
        isGameover = true;
    }


    // 다음 씬으로 전환하는 메서드
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // 게임 재시작하는 메서드
    public void RestartGame()
    {
        SceneManager.LoadScene(0); // 0은 시작 씬의 빌드 인덱스입니다. 필요에 따라 수정하세요.
        score = 0; // 게임을 재시작할 때 점수 초기화
    }
}