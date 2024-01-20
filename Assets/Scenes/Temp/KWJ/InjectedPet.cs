using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InjectedPet : MonoBehaviour
{
    [SerializeField] private ParticleSystem m_InjectionEffect;
    [SerializeField] private MeshRenderer m_Renderer;

    private void OnTriggerEnter(Collider other)
    {
        m_Renderer.material.color = new Color(0f, 0f, 0f);
        m_InjectionEffect.Play();
        StartCoroutine(GetPortion());
    }

    private void OnTriggerExit(Collider other)
    {
        m_InjectionEffect.Stop();
    }

    private IEnumerator GetPortion()
    {
        while (m_Renderer.material.color.r < 0.95f)
        {
            yield return new WaitForSeconds(0.5f);
            m_Renderer.material.color += new Color(0.1f, 0.1f, 0.1f);
        }
    }
}
