using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour
{

    public bool HasBeenUsed;
    public bool IsActive;
    public float xPos = 0f;
    public float yPos = 0f;
    public float zPos = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HasBeenUsed 
            && !IsActive)
        {
            yPos -= .05f;
        }
        gameObject.transform.position = new Vector3(xPos, yPos, zPos);
    }

    void OnCollisionEnter(Collision other)
    {
        IsActive = true;
    }

    void OnCollisionExit(Collision other)
    {
        IsActive = false;
        HasBeenUsed = true;
    }
}
