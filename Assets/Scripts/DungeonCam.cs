using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCam : MonoBehaviour
{
    Camera theCamera;

    public float pixelPerUnitScale;
    public float pixelPerUnit;

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
        
    }

    private void LateUpdate()
    {
        UpdateOrthographicSize();
    }

    void UpdateOrthographicSize()
    {
        theCamera.orthographicSize = ((Screen.currentResolution.height) / (pixelPerUnitScale * pixelPerUnit)) * 0.5f;
    }
}
