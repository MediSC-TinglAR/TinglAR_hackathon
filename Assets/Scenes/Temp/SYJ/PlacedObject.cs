using UnityEngine;
using UnityEngine.EventSystems;

public class PlacedObject : MonoBehaviour
{
    [SerializeField]
    private GameObject cubeSelected; // 선택된 객체를 표시하는 큐브 프리팹
    public bool IsSelected
    {
        get => SelectedObject == this;
    }
    private static PlacedObject selectedObject; // 현재 선택된 객체
    public static PlacedObject SelectedObject
    {
        get => selectedObject;
        set
        {
            if (selectedObject == value)
            {
                return;
            }

            if (selectedObject != null)
            {
                selectedObject.cubeSelected.SetActive(false); // 이전에 선택된 객체를 비활성화
            }

            selectedObject = value; // 새로운 객체를 선택

            if (value != null)
            {
                value.cubeSelected.SetActive(true); // 새로운 객체를 활성화
            }
        }
    }

    public Animator animator;
    private void Awake()
    {
        cubeSelected.SetActive(false); // 선택된 큐브를 비활성화
    }
    // 터치 후 드래그하는 위치로 현재 선택된 오브젝트를 이동
    public void OnPointerClick(BaseEventData bed)
    {

        Debug.Log("Hello");
        animator.enabled = true;
        Invoke("DestroyBubble", 1.5f);
    }

    public void DestroyBubble()
    {
        Destroy(gameObject);
        SelectedObject = null;
        BubbleSpawn.bubbleCount -= 1;
    }
}