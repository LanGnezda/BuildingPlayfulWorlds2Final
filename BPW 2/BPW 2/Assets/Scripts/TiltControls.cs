using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
  
            if (gameObject.transform.eulerAngles.x >= 350 || gameObject.transform.eulerAngles.x <= 11)
            {
                gameObject.transform.Rotate(new Vector3(-1, 0, 0));
            }

            else
            {
                gameObject.transform.Rotate(new Vector3(0, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if ((gameObject.transform.eulerAngles.x >= 349 || gameObject.transform.eulerAngles.x <= 10))
            {
                gameObject.transform.Rotate(new Vector3(1, 0, 0));
            }

            else
            {
                gameObject.transform.Rotate(new Vector3(0, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.W))
        {

            if (gameObject.transform.eulerAngles.z >= 349 || gameObject.transform.eulerAngles.z <= 20)
            {
                gameObject.transform.Rotate(new Vector3(0, 0, 1));
            }

            else
            {
                gameObject.transform.Rotate(new Vector3(0, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if ((gameObject.transform.eulerAngles.z >= 350 || gameObject.transform.eulerAngles.z <= 21))
            {
                gameObject.transform.Rotate(new Vector3(0, 0, -1));
            }

            else
            {
                gameObject.transform.Rotate(new Vector3(0, 0, 0));
            }
        }


    }
}
