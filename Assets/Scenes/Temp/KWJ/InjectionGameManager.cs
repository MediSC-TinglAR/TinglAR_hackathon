using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjectionGameManager : MonoBehaviour
{
    public BubbleSpawn BubbleSpawner;
    public PlaceOnPlane placeOnPlane;
    public DetectImageManager detectImageManager; 
    // Start is called before the first frame update
    void Start()
    {
        detectImageManager.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
