using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] float zaxis;
    [SerializeField] GameObject carthingfollow;
    //Camera's position should be same as car position
     void LateUpdate()
    {
        transform.position = carthingfollow.transform.position + new Vector3(0, 0, zaxis);
        
    }
}
