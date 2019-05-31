using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightCursor : MonoBehaviour
{
    Camera theCamera;

    Ray newRay;

    private void Awake()
    {
        theCamera = GetComponent<Camera>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetLookAtPosition();
    }

    private void LateUpdate()
    {

    }

    void GetLookAtPosition()
    {
        //create a ray
        newRay = theCamera.ScreenPointToRay(Input.mousePosition);
        //create a plane
        Plane targetPlane = new Plane(Vector3.back, Vector3.zero);
        //create a variable to store ray distance
        float rayDistance;

        //ray cast using the plane
        if(targetPlane.Raycast(newRay, out rayDistance))
        {
            //get the intersection point of the ray against the plane
            Vector3 hitPosition = newRay.GetPoint(rayDistance);
            Debug.DrawLine(newRay.origin, hitPosition, Color.red);
        }
        
    }
}
