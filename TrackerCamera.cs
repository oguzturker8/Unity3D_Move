using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackerCamera : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	void Update(){ 
	transform.position = player.position + offset;
	}
}