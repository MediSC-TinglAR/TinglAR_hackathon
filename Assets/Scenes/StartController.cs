using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartControl : MonoBehaviour
{
    float fadeCount = 50f;
    // public GameObject DoctorMessage;
    // public Image DocImg;
    private Image StartImg;
    private Image FinishImg;
    public GameObject doctorMessage;
    public GameObject StartLogo;
    public GameObject finishLogo;
    Color selectedColor;
    // Color selectedColor2;

    void Start()
    {
        doctorMessage.SetActive(false);
        finishLogo.SetActive(false);
        selectedColor = Color.white;
        selectedColor.a = 1f;
        StartImg = StartLogo.GetComponent<Image>();
        StartImg.color = selectedColor;
        StartCoroutine(ShowArm());
        // DoctorMessage.SetActive(false);
        // DocImg = DoctorMessage.GetComponent<Image>();
        // DocImg.color = selectedColor2;
    }

    IEnumerator ShowArm()
    {
        yield return new WaitForSeconds(5f);
        doctorMessage.SetActive(true);
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

        GameObject DetectArm = GameObject.FindWithTag("pet");
        if (DetectArm != null)
        {
            selectedColor.a -= 0.02f;
            StartImg.color = selectedColor;
            StopAllCoroutines();
            doctorMessage.SetActive(false);
        }
    }

    public void FinishGame()
    {
        finishLogo.SetActive(true);
        //FinishImg = finishLogo.GetComponent<Image>();
        //FinishImg.color = FinishImg.color - new Color(0f, 0f, 0f, 1f);
        //StartCoroutine(FadeIn());
    }

    public void MoveScene()
    {
        SceneManager.LoadScene("Main");
    }
}
