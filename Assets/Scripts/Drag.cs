using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public bool move;
    private Vector3 posStart;
    private Vector3 pos;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition;
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                posStart = transform.position;
                touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 25f));
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 25f));
                if (GetComponent<Collider2D>().OverlapPoint(touchPosition))
                {
                    transform.position = new Vector3(touchPosition.x, touchPosition.y, 0);
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                if (move)
                {
                    transform.position = pos;
                }
                else
                {
                    transform.position = posStart;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropSpace")
        {
            Debug.Log("colidiu");
            pos = collision.transform.position;
            move = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropSpace")
        {
            move = false;
        }
    }
}
