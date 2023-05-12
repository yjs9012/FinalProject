using UnityEngine;

public class DragUI : MonoBehaviour
{
    public Transform pointer;

    [Header("Select To Include In Drag")]
    public bool x;
    public bool y;
    public bool z;

    public void Drag()
    {
        float newX = x ? pointer.position.x : transform.position.x;
        float newY = y ? pointer.position.y : transform.position.y;
        float newZ = z ? pointer.position .z : transform.position .z;
        transform.position=new Vector3(newX,newY,newZ);
        if (OVRInput.Get(OVRInput.Button.Two)) // B ¹öÆ°
        {
            float rotationAmount = 20.0f * Time.deltaTime;
            Quaternion rotation = Quaternion.Euler(0.0f, rotationAmount, 0.0f);
            transform.localRotation *= rotation;
        }
    }
}
