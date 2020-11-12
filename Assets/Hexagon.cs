using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public float shrink_Spd = 2.5f;
    private LineRenderer line;
    Color lerpedColor = Color.white;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        line = GetComponent<LineRenderer>();
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * Time.deltaTime * shrink_Spd;
        lerpedColor = Color.Lerp(Color.white, Color.blue, Time.deltaTime * 5);
        line.startColor = lerpedColor;
        line.endColor = lerpedColor;
        if(transform.localScale.x <0.1f)
        {
            Destroy(gameObject);
        }
    }
}
