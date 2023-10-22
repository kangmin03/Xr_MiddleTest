
using System.Collections;
using UnityEngine;

public class PlatformMgr : MonoBehaviour
{
    public GameObject[] tilePrefabs; // ���� ������ Ÿ�� �������� ���� �迭

    void Start()
    {
        SpawnTiles();
    }

    void SpawnTiles()
    {
        for (float y = -1.5f; y <= 50f; y += 2.5f)
        {
            float randomX = Random.Range(-2f, 2f); // X ��ǥ�� ���� �� ����
            Vector3 spawnPosition = new Vector3(randomX, y, 0f); // Ÿ���� ��ġ ����
            GameObject randomTilePrefab = tilePrefabs[Random.Range(0, tilePrefabs.Length)]; // ������ Ÿ�� ������ ����
            Instantiate(randomTilePrefab, spawnPosition, Quaternion.identity); // Ÿ�� ����
        }
    }
}