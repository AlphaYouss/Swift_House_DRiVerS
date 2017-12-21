using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using System.Collections.Generic;
using System;

public class customCarController : MonoBehaviour
{
    [SerializeField] private WheelCollider[] m_WheelColliders = new WheelCollider[4];
    [SerializeField] private GameObject[] m_WheelMeshes = new GameObject[4];
    [SerializeField] private WheelEffects[] m_WheelEffects = new WheelEffects[4];
    [SerializeField] private Quaternion[] m_WheelMeshLocalRotations;

	public static Rigidbody carRigidbody;

    float velocity;
    float maxSpeed;

    // Use this for initialization
    void Start()
    {
        velocity = 1;
        maxSpeed = 1000;
    }

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody>();
        m_WheelMeshLocalRotations = new Quaternion[4];
        //for (int i = 0; i < 4; i++)
        //{
        //    m_WheelMeshLocalRotations[i] = m_WheelMeshes[i].transform.localRotation;
        //}
        carRigidbody.centerOfMass = new Vector3(carRigidbody.centerOfMass.x, -1000f, carRigidbody.centerOfMass.z);
    }

    //private bool OnCollision()
    //{
    //    if (Physics.Raycast(origin: transform.position, direction: Vector3.forward, maxDistance: 1.5f)) {
    //        velocity = (velocity / 10) * -1;
    //        if(velocity >= 0)
    //        {
    //            velocity = -1;
    //        }
    //        transform.Translate(new Vector4(0, 0, velocity / 1000));
    //        return true;
    //    }
    //    if(Physics.Raycast(transform.position,Vector3.back,1f)) {
    //        velocity = (velocity / 10) * -1;
    //        if (velocity <= 0)
    //        {
    //            velocity = 1;
    //        }
    //    }
    //    if (Physics.Raycast(origin: transform.position, direction: Vector3.left, maxDistance: 1f))
    //    {
    //        transform.Translate(0.5f, 0, 0);
    //    }
    //    if (Physics.Raycast(origin: transform.position, direction: Vector3.right, maxDistance: 1f))
    //    {
    //        transform.Translate(-0.5f, 0, 0);
    //    }
    //    return false;
    //}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 40), "velocity = " + velocity);
    }
		
    //Move the car with the right speed and rotation
	public static void MoveCar(float rotation, float velocity)
    {
		carRigidbody.transform.Translate(new Vector4(0, 0, velocity / 1000));
		carRigidbody.transform.Rotate (0, rotation, 0);
        //carRigidbody.AddForce(new Vector3(0, 0, velocity), ForceMode.Impulse);

        //carRigidbody.AddForce(new Vector3(0, -10f, 0));
        //so far this is the best option only problem is that it likes to go flying
    }
}
