using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartControl : MonoBehaviour
{
    float fadeCount = 50f;
    // public GameObject DoctorMessage;
    // public Image DocImg;
    private Image StartImg;
    public GameObject StartLogo;
    Color selectedColor;
    // Color selectedColor2;

    void Start()
    {
        selectedColor = Color.white;
        selectedColor.a = 1f;
        StartImg = StartLogo.GetComponent<Image>();
        StartImg.color = selectedColor;

        // DoctorMessage.SetActive(false);
        // DocImg = DoctorMessage.GetComponent<Image>();
        // DocImg.color = selectedColor2;
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
        if(DetectArm != null)
        {
            selectedColor.a -= 0.02f;
            StartImg.color = selectedColor;
        }
    }
}
