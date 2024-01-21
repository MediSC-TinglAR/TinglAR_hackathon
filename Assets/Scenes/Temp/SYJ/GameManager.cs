using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


// ���� ���� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� ���� �Ŵ���
// ������ �� �ϳ��� ���� �Ŵ����� ������ �� �ִ�.
public class GameManager : MonoBehaviour
{
    public static GameManager instance; // �̱����� �Ҵ��� ���� ����

    public bool isGameover = false; // ���� ���� ����
    public TMP_Text scoreText; // ������ ����� UI �ؽ�Ʈ

    public int score = 0; // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    void Awake()
    {
        // �̱��� ���� instance�� ����ִ°�?
        if (instance == null)
        {
            // instance�� ����ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���
            // ���� �ΰ� �̻��� GameManager ������Ʈ�� �����Ѵٴ� �ǹ�.
            // �̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �ΰ� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    // ������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        if (isGameover)
        {
            score += newScore;
            //scoreText.text = score.ToString();
        }
    }
    // ���� ������ �����ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
    }


    // ���� ������ ��ȯ�ϴ� �޼���
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // ���� ������ϴ� �޼���
    public void RestartGame()
    {
        SceneManager.LoadScene(0); // 0�� ���� ���� ���� �ε����Դϴ�. �ʿ信 ���� �����ϼ���.
        score = 0; // ������ ������� �� ���� �ʱ�ȭ
    }
}