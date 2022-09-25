using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    private Vector3 mOffSet;

    public Vector3 mousePoint;

    private float mZCoord;

    public Camera cam2;

    void OnMouseDown()
    {
        mZCoord = cam2.WorldToScreenPoint(gameObject.transform.position).z;

        mOffSet = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffSet;
    }

    public Vector3 GetMouseWorldPos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            mousePoint = hit.point;
        }
        
        mousePoint.x = 45f;
        mousePoint.z = mZCoord;

        return cam2.ScreenToWorldPoint(mousePoint);
    }
}
