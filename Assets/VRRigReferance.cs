using UnityEngine;

public class VRRigReferance : MonoBehaviour
{
    public static VRRigReferance singlton;


    public Transform root;
    public Transform head;
    public Transform lefthand;
    public Transform righthand;


    private void Awake()
    {
        singlton = this;
    }

}
