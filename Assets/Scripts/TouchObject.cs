using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 

            if (Physics.Raycast(ray,out hit, 1000))
            {
                if(hit.transform.name == this.transform.name)
                {
                    this.gameObject.SetActive(false);
                    //transform.RotateAround(ObjCenter.transform.positin,Vector3.up,20*Time.deltaTime);
                    //Sound.Play();
                }
            }
        }
    }
}
