	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    Transform CamMov;

    // Start is called before the first frame update
    void Start()
    {
        CamMov = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CamMov.position = new Vector3(PlayerMovement.CamXpos, CamMov.position.y, CamMov.position.z);
	if (CamMov.position.x<-1.7){
		CamMov.position = new Vector3(-1.7f, CamMov.position.y, CamMov.position.z);
	   }
    }
}
