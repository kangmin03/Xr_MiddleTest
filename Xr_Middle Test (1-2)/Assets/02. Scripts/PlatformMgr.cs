
using System.Collections;
using UnityEngine;

public class PlatformMgr : MonoBehaviour
{
    public GameObject[] tilePrefabs; // 여러 종류의 타일 프리팹을 담을 배열

    void Start()
    {
        SpawnTiles();
    }

    void SpawnTiles()
    {
        for (float y = -1.5f; y <= 50f; y += 2.5f)
        {
            float randomX = Random.Range(-2f, 2f); // X 좌표의 랜덤 값 설정
            Vector3 spawnPosition = new Vector3(randomX, y, 0f); // 타일의 위치 설정
            GameObject randomTilePrefab = tilePrefabs[Random.Range(0, tilePrefabs.Length)]; // 랜덤한 타일 프리팹 선택
            Instantiate(randomTilePrefab, spawnPosition, Quaternion.identity); // 타일 생성
        }
    }
}