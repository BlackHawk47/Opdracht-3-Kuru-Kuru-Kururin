using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
//zorgt er voor dat de camera stil blijft staan en niet mee draaid
public class CameraRotation : MonoBehaviour
{

    private Quaternion Camera_rotate;
    void Start()
    {
        Camera_rotate = this.transform.rotation;
    }

    void Update()
    {
        this.transform.rotation = Camera_rotate;

    }
}
