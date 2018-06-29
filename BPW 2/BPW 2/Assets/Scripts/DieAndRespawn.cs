using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieAndRespawn : MonoBehaviour {

    [SerializeField] private Transform knikker;
    [SerializeField] private Transform spawnpoint;


	// Use this for initialization
	void Start () {

    }

    private void OnTriggerEnter(Collider other)
    {
        knikker.transform.position = spawnpoint.transform.position;

    }
}
