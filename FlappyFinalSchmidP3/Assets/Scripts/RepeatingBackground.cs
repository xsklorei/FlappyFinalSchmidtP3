using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;


    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        //if scrolled out of view
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        //calculates how far it needs to move
        transform.position = (Vector2)transform.position + groundOffset;
    }



}
