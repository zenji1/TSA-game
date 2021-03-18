using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public Vector2 cameraChange;
    public Vector3 playerChange;
     public Vector2 cameraChangeMax;
     public Vector2 cameraChangeMin;
    private CameraMovement cam; 

    // Start is called before the first frame update
    void Start() {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update() {
      
    }

    private void OnTriggerEnter2d(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            cam.minPosition.x = cameraChangeMin.x;
            cam.minPosition.y = cameraChangeMin.y;
            cam.maxPosition.x = cameraChangeMax.x;
            cam.maxPosition.y = cameraChangeMax.y;
            other.transform.position += playerChange;
        }
    }
}
