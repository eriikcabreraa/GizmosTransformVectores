using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Public Attributes
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Target X: " + target.position.x + " / Target Y: " + target.position.y + " / Target Z: " + target.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target.position);
    }
}
