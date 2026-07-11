using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-1, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Draw E
        Debug.DrawLine(new Vector2(0, 0), new Vector2(0, 6), Color.red);
        Debug.DrawLine(new Vector2(0, 6), new Vector2(3, 6), Color.red);
        Debug.DrawLine(new Vector2(0, 3), new Vector2(3, 3), Color.red);
        Debug.DrawLine(new Vector2(0, 0), new Vector2(3, 0), Color.red);

        //Draw R
        Debug.DrawLine(new Vector2(4, 0), new Vector2(4, 6), Color.red);
        Debug.DrawLine(new Vector2(4, 6), new Vector2(7, 6), Color.red);
        Debug.DrawLine(new Vector2(7, 6), new Vector2(7, 3), Color.red);
        Debug.DrawLine(new Vector2(7, 3), new Vector2(4, 3), Color.red);
        Debug.DrawLine(new Vector2(4, 3), new Vector2(7, 0), Color.red);

        //Draw I
        Debug.DrawLine(new Vector2(8, 0), new Vector2(10, 0), Color.red);
        Debug.DrawLine(new Vector2(9, 0), new Vector2(9, 6), Color.red);
        Debug.DrawLine(new Vector2(8, 6), new Vector2(10, 6), Color.red);

        //Draw K
        Debug.DrawLine(new Vector2(11, 0), new Vector2(11, 6), Color.red);
        Debug.DrawLine(new Vector2(11, 3), new Vector2(14, 6), Color.red);
        Debug.DrawLine(new Vector2(11, 3), new Vector2(14, 0), Color.red);

    }
}
