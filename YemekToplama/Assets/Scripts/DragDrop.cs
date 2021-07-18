using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool DragItem = false;
    private GameObject dragObject;
    private Vector2 touchOffset;
    RaycastHit2D hit;

    LifeTime lifeCount;

    void Start()
    {
        lifeCount = GameObject.FindGameObjectWithTag("Script").GetComponent<LifeTime>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HasInput)
        {
            if(lifeCount.life > 0)
            {
                Drag();
            }        
        }
        else
        {
            if (DragItem)
            {
                Drop();
            }
        }
    }

    private bool HasInput
    {
        get
        {
            return Input.GetMouseButton(0);
        }
    }
    Vector2 Position
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    private void Drag()
    {
        var inputPosition = Position;
        if (DragItem)
        {
            dragObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 1); //Buna iyice bak
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null)
                {
                    if(hit.collider.transform.tag == "Basket")
                    {
                        //Debug.Log("Sepet");
                        DragItem = true;
                        dragObject = hit.transform.gameObject;
                        touchOffset = (Vector2)hit.transform.position - inputPosition;
                        dragObject.transform.localScale = new Vector2(0.07f, 0.07f);
                    }
                }
            }
        }
    }
    void Drop()
    {
        DragItem = false;
    }   
}
