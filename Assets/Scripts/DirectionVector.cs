using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //Public Attributes
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed = 1;

    //Private Attributes
    private Vector3 _directionVector;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Calculo del vector de dirección entre el transform inicial y el transform final
        _directionVector = finalTransform.position - initialTransform.position;
        
        //Convierte el vector de dirección en un vector unitario (normalizado)
        _directionVector.Normalize();

        Debug.DrawRay(initialTransform.position, _directionVector * speed, Color.red);

        //Translate
        initialTransform.Translate(_directionVector * Time.deltaTime * speed);

        //Magnitude
        print("Magnitude: " + _directionVector.magnitude * speed);
        
        //Distance
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " + distance);

        if (distance < 10 || distance > 20)
        {
            speed *= -1;
        }

        
    }
}
