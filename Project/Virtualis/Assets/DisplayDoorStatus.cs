

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDoorStatus : MonoBehaviour
{

    [SerializeField] Text doorButtonText;
    [SerializeField] GameObject doorObject;

    bool prevStatus;
    // Start is called before the first frame update
    void Start()
    {
        prevStatus = doorObject.activeSelf; 
        doorButtonText.text = "Door: Closed";
    }

    // Update is called once per frame
    void Update()
    {
        if (prevStatus)
        {
            if(doorObject.activeSelf == false)
            {
                doorButtonText.text = "Door: Open";
                prevStatus = false;
            }
        }
        else
        {
            if (doorObject.activeSelf == true)
            {
                doorButtonText.text = "Door: Closed";
                prevStatus = true;
            }
        }
    }
}
