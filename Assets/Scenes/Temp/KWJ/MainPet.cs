using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPet : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.instance.isLevelUp)
            animator.SetTrigger("Clap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
