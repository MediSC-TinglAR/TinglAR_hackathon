using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject SpawnObject; //Prefab���� ������ ������Ʈ

    public int xPos;
    public int zPos;
    public int bubbleCount;
    public int score=0;

    public bool playingGame = true;
    public bool didInit = false;

    void Start()
    {
        StartCoroutine(StartSpawing());
    }

    private void FixedUpdate()
    {

        if (bubbleCount < 5 && didInit)
            StartCoroutine(StartSpawing());
    }

    IEnumerator StartSpawing()
    {  
            while (bubbleCount < 5) // �� 5���� ����
            {
                Vector3 spawnPosition = GetRandomSpawnPosition();

                // Prefab ������Ʈ�� �ν��Ͻ�ȭ
                GameObject spawnedObject = Instantiate(SpawnObject, spawnPosition, Quaternion.identity); // (������ ���, ��ġ, ����)

                Debug.Log($"=========enemyCount: {bubbleCount}");

                // ��ġ ���� �α� ���
                Debug.Log($"=========Object spawned at position: {spawnPosition}");

                // ���� ī�޶��� ��ġ �� ���� ���� �α� ���
                Camera mainCamera = Camera.main;
                if (mainCamera != null)
                {
                    Debug.Log($"=========Main Camera position: {mainCamera.transform.position}");
                    Debug.Log($"=========Main Camera forward direction: {mainCamera.transform.forward}");
                }

            bubbleCount += 1;
            score += 1;

            yield return new WaitForSeconds(4); // 4�� �������� ����

            }

        didInit = true;
    }

    Vector3 GetRandomSpawnPosition()
    {
        float xPos = Random.Range(2, 4); // Position X�� -2~ 4 ������ ���� ���� ����
        float zPos = Random.Range(2, 4); // Position Z�� 3 ~ 5 ������ ���� ���� ����

        return new Vector3(xPos, Random.Range(-1, 1), zPos);
    }

}
