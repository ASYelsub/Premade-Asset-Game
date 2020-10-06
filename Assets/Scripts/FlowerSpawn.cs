using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

//The intent of this script is to spawn eyeballs behind the dude who is moving.
public class FlowerSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject flowerPrefab;


    private float flowerSpacer;
    private float randomMax;

    private Vector3 flowerPos;
    private Vector3 flowerRot;
    private void Start()
    {
        flowerSpacer = 0;
        randomMax = UnityEngine.Random.Range(2, 4);
        flowerPos = new Vector3(0,0,0);
        //can maybe randomize the x and y as well a bit
        flowerRot = new Vector3(0,0,90);
    }

    private void Update()
    {
        if (flowerSpacer >= randomMax)
        {
            flowerPos = gameObject.transform.position;
            flowerSpacer = 0f;
            Instantiate(flowerPrefab, flowerPos, Quaternion.Euler(flowerRot));
        }
        else
        {
            flowerSpacer += Time.deltaTime;
        }
    }
}
