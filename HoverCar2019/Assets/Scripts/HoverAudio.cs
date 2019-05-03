using UnityEngine;
using System.Collections;

public class HoverAudio : MonoBehaviour
{
	[SerializeField] private AudioSource jetSound;

	private float jetPitch;
	private const float LowPitch=.1f;
	private const float HighPitch=2.0f;
	private const float SpeedToRevs=.01f;
	private Vector3 myVelocity;
	private Rigidbody carRigidbody;



	void Awake () 
	{		
		carRigidbody = GetComponent<Rigidbody> ();	
	}

	void FixedUpdate()
    {
		myVelocity = carRigidbody.velocity;
		float forwardSpeed = carRigidbody.velocity.z;
		float engineRevs = Mathf.Abs (forwardSpeed) * SpeedToRevs;
		jetSound.pitch = Mathf.Clamp (engineRevs, LowPitch, HighPitch);
	}
}
