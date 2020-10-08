using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPickUp : MonoBehaviour
{
    private GameObject activeFlower;
    
    //private LayerMask Mask = 1;
    public RaycastHit Hit;
    //public GameObject Item;
    //private RaycastHit hit;
   // private Ray rc;
    private RaycastHit rch;
    public Camera camera;

    private void Start()
    {
        //camera = gameObject.;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        /*    //print("MOUSE PLS");
            Ray rc = new Ray(camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)), camera.transform.forward);
            Debug.DrawRay(rc.origin, rc.direction, Color.red);
            //Physics.Raycast(new Vector3(transform.position.x, transform.position.y - downAim, transform.position.z), transform.forward, out hit, Mathf.Infinity, layerMask);
            if (Physics.Raycast(rc.origin, rc.direction, out rch, Mathf.Infinity))
            {
                print("ray sent out");
                if (rch.collider.gameObject.CompareTag("Flower"))
                {
                    activeFlower = Hit.collider.gameObject;
                    print("object hit!");
                }
                print(rch.collider.gameObject);

            } */
        }

        
    }
    
    
    /*if ( Input.GetMouseButtonDown (0)){ 
        RaycastHit hit; 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        if ( Physics.Raycast (ray,out hit,100.0f)) {
            StartCoroutine(ScaleMe(hit.transform));
            Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
        }
    }*/
    
    
    
    /*if (Input.GetMouseButtonDown(0))
    {
        rc = new Ray(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f)), transform.forward);
        Debug.DrawRay(rc.origin, rc.direction, Color.red);
        if (Physics.Raycast(rc.origin, rc.direction, out rch, 100))
        {
            Debug.Log("Ray hit");
            targetPos = rch.point;
            Instantiate(food, targetPos + (Vector3.up * 11f), pfTarget.transform.rotation);
        }
    }*/
 
}

