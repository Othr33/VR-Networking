using UnityEngine;
using System.Collections;

public class CopyScript : Photon.MonoBehaviour {

    public GameObject AvatarHead;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (photonView.isMine)
            transform.position = AvatarHead.transform.position;
	
	}
}
