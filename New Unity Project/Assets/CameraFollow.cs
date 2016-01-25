using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject follow;

    Vector3 offset;

	void Update () {
        offset = new Vector3(follow.transform.position.x, follow.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = offset;
	}
}
