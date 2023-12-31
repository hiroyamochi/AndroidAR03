using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    public void Shoot(){
        
        RaycastHit hit;
        
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){
            if(hit.transform.name == "red(Clone)" || hit.transform.name == "green(Clone)" || hit.transform.name == "blue(Clone)"){
                Destroy(hit.transform.gameObject);
                Debug.Log("Hit!!");
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }

    }
}
