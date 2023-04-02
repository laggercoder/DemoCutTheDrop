using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByMouse : MonoBehaviour
{
    public bool isDragging = false;
    private Vector3 startPosition;
    private float maxDisntance = 3.0f;
    public static MoveByMouse moveByMouse;
    protected virtual void Awake()
    {
        this.startPosition = transform.position;
        moveByMouse = this;
    }
    void OnMouseDown()
    {
        isDragging = true;
        Debug.Log("call is mouse down method");
    }

    void OnMouseUp()
    {
        isDragging = false;
        Debug.Log("call mouseUp method");
    }

    protected virtual void FixedUpdate()
    {
        this.DraggingX();
    }
    protected virtual void DraggingX()
    {
        if (isDragging)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            objectPosition.y = startPosition.y;
            if (objectPosition.x > startPosition.x + maxDisntance) objectPosition.x = startPosition.x + maxDisntance;
            if (objectPosition.x < startPosition.x - maxDisntance) objectPosition.x = startPosition.x - maxDisntance;
            transform.position = objectPosition;
        }

    }
    protected virtual void DraggingY()
    {
        if (isDragging)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            objectPosition.x = transform.position.x;
            if (objectPosition.x > startPosition.x + maxDisntance) objectPosition.y = startPosition.y + maxDisntance;
            if (objectPosition.x < startPosition.x - maxDisntance) objectPosition.y = startPosition.y - maxDisntance;
            transform.position = objectPosition;
        }

    }




}
