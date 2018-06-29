using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamRotation : MonoBehaviour {

    [SerializeField] private GameObject BeamToRotate;
    private bool ButtonHit = false;
    public Material AfterHit;
    public AudioClip ButtonKick;
    [SerializeField] private AudioSource Source;
	

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knikker") && ButtonHit == false)
        {
            ButtonHit = true;
            Source.PlayOneShot(ButtonKick);
            this.gameObject.GetComponent<MeshRenderer>().material = AfterHit;
            BeamToRotate.transform.Rotate(new Vector3(0, 50, 0));

            if (BeamToRotate.transform.eulerAngles.y  >= 90)
            {
                BeamToRotate.transform.Rotate(new Vector3(0, 0, 0));
            }
        }
    }
}
