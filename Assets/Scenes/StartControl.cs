using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartControl : MonoBehaviour
{
    float fadeCount = 50f;
    public TMP_Text scoreText;
    // public GameObject DoctorMessage;
    // public Image DocImg;
    private Image StartImg;
    private Image FinishImg;
    public GameObject Instruction;
    public GameObject StartLogo;
    public GameObject finishLogo;
    public GameObject startgamebtn;
    Color selectedColor;
    // Color selectedColor2;

    void Start()
    {
        finishLogo.SetActive(false);
        StartLogo.SetActive(false);
        selectedColor = Color.white;
        selectedColor.a = 1f;
        StartImg = StartLogo.GetComponent<Image>();
        StartImg.color = selectedColor;
        // StartCoroutine(ShowArm());
        
        // DoctorMessage.SetActive(false);
        // DocImg = DoctorMessage.GetComponent<Image>();
        // DocImg.color = selectedColor2;
    }

    IEnumerator ShowArm()
    {
        yield return new WaitForSeconds(5f);
    }

    IEnumerator FadeIn()
    {
        while (FinishImg.color.a < 0)
        {
            FinishImg.color += new Color(0f, 0f, 0f, 0.05f);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Button startgame = startgamebtn.GetComponent<Button>();
        // while(fadeCount>0f)
        // {
        //     selectedColor.a -= 0.02f;
        //     StartImg.color = selectedColor;
        //     fadeCount -= 1f;
        // }

        // if(fadeCount == 0f)
        // {
        //     DoctorMessage.SetActive(true);
        //     fadeCount = -1f;
        // }
        startgame.onClick.AddListener(() => ActivateGameStart());

        GameObject DetectArm = GameObject.FindWithTag("pet");
        if (DetectArm != null)
        {
            selectedColor.a -= 0.02f;
            StartImg.color = selectedColor;
            StopAllCoroutines();
        }
    }

    public void FinishGame()
    {
        finishLogo.SetActive(true);
        GameManager.instance.isLevelUp = true;
        //FinishImg = finishLogo.GetComponent<Image>();
        //FinishImg.color = FinishImg.color - new Color(0f, 0f, 0f, 1f);
        //StartCoroutine(FadeIn());

    }

    public void MoveScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void SetCherryText(int num)
    {
        scoreText.text = num.ToString();
    }

    void ActivateGameStart()
    {
        Instruction.SetActive(false);
        StartLogo.SetActive(true);
    }
}
