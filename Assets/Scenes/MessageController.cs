using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MessageController : MonoBehaviour
{
    public Image TestImage;
    public Image SCImage;
    Color tmpColor;
    public GameObject StartLogo;
    // Start is called before the first frame update
    void Start()
    {
        tmpColor = Color.white;
        tmpColor.a = 0f;
        TestImage = GetComponent<Image>();
        TestImage.color = tmpColor;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject isLogoActive = GameObject.FindWithTag("Logo");

        if(isLogoActive!=null)
        {
            gameObject.SetActive(true);
        }
    }
}
