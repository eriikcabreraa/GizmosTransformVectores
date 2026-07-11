using UnityEngine;

public class Espacio2D : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedZ;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;

    private float rotationAngle = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.Translate(Vector3.right * speedZ * Time.deltaTime); 
        playerTransform.Translate(Vector3.up * speedY * Time.deltaTime);

        playerTransform.Rotate(speedRotation * Time.deltaTime,0,0);

        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, speedRotationSphere * Time.deltaTime * rotationAngle);
    }
    
}
