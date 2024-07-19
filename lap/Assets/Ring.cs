using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public int numberOfObjects = 10; // Number of objects to instantiate
    public float radius = 5f; // Radius of the circle
    public GameObject prefab; // Prefab to instantiate

    // Start is called before the first frame update
    void Start()
    {
        MakeCircle();
    }

    void MakeCircle()
    {
        // Degrees-to-radians conversion constant (Read Only).
        // This is equal to (PI * 2) / 360.
        float angle = 360f / numberOfObjects;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float x = Mathf.Sin(Mathf.Deg2Rad * angle * i) * radius;
            float z = Mathf.Cos(Mathf.Deg2Rad * angle * i) * radius;
            Vector3 position = new Vector3(x, 0.5f, z);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
