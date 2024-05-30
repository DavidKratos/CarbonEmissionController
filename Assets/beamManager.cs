using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class beamManager : MonoBehaviour
{
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     void OnDrawGizmos()
//     {
//         Gizmos.color = Color.green;


//         Gizmos.DrawLine(Camera.main.ScreenToWorldPoint(Input.mousePosition), -transform.up * hit.distance);
//     }

// RaycastHit hit;
//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetMouseButtonDown(0))
//         {
//             Debug.Log(" ... ");
//             Ray ray = Camera.main.ScreenPointToRay(transform.position);
//             if(Physics.Raycast(ray,out hit,100f))
//             {
//                  Color tmpCol = hit.collider.gameObject.GetComponent<Renderer>().material.color;
//                  Debug.Log(" > " + tmpCol);
//             }
//         }
//     }

  Camera cam;
    Vector3 pos = new Vector3(200, 200, 0);


    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

        if(Physics.Raycast(ray.origin, ray.direction,out hit))
        {
            Debug.Log(" .> " + hit.collider.name);
            if(Input.GetMouseButtonDown(0))
            hit.collider.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)Random.Range(0,255),(byte)Random.Range(0,255),(byte)Random.Range(0,255),255);
        }


    }
}
