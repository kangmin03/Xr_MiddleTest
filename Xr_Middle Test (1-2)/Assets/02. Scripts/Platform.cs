using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Vector2 move_dir = Vector2.right;
    public float distance = 2.0f;
    public float move_time = 4.0f;
    public void Start()
    {
        StartCoroutine(SpeedTime((Vector2)transform.position + move_dir * distance, move_time));
    }

    IEnumerator SpeedTime(Vector2 EndPosition, float EndTime)
    {
        float MoveTime = 0.0f;
        Vector2 StartPosition = transform.position;
        while (MoveTime < EndTime)
        {
            Vector2 new_pos = Vector2.Lerp(StartPosition, EndPosition, MoveTime / EndTime);
            transform.position = new_pos;
            MoveTime += Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }

        Arrive();
    }

    public void Arrive()
    {
        move_dir *= -1.0f;
        StartCoroutine(SpeedTime((Vector2)transform.position + move_dir * distance, move_time));
    }
}