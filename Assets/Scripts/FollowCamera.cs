using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] private GameObject thingToFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -12);
    }
}
