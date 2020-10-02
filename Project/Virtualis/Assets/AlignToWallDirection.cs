using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class AlignToWallDirection : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100f))
        {

            Debug.DrawRay(transform.position, Vector3.down, Color.green);
            Vector3 norm = hit.normal;

            norm.Scale(new Vector3(1f, 0, 1f));

            norm.Normalize();

            transform.rotation = Quaternion.LookRotation(norm, Vector3.up);


            Debug.DrawRay(transform.position, norm, Color.green);

        }
    }


    
}
