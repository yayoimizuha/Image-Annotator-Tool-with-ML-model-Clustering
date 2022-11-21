using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public float speed = 8f;
    public float movableRange = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -movableRange, movableRange),
            Mathf.Clamp(transform.position.y, -movableRange, movableRange)
        );
    }
}