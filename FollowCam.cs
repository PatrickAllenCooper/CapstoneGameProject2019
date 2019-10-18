using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	public Transform target;
    public float verticalCameraOffset = 0f;
	public float smoothTime = 0.2f;

    private Vector3 _velocity = Vector3.zero;

    public Vector3 defaultCameraConfiguration;
	
	// Update is called once per frame
	void LateUpdate() {
		Vector3 targetPosition = new Vector3(target.position.x, defaultCameraConfiguration.y, defaultCameraConfiguration.z);
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, smoothTime);
	}
}
