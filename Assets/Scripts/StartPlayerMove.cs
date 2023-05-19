using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        player.Translate(Vector2.right * moveSpeed * Time.deltaTime, Space.World);
        if (player.position.x > endPoint.position.x)
            player.position = startPoint.position;

    }
}
