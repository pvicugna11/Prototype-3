using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
