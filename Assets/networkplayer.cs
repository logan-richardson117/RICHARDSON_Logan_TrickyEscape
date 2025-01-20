using UnityEngine;
using Unity.Netcode;

public class networkplayer : NetworkBehaviour
{

    public Transform root;
    public Transform head;
    public Transform lefthand;
    public Transform righthand;

    public Renderer[] meshTODisable;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if (IsOwner)
        {
            foreach (var item in meshTODisable)
            {
                item.enabled = false;
            }
        }
    }

 
    void Update()
    {
        if(IsOwner)
        {
            root.position = VRRigReferance.singlton.root.position;
            root.rotation = VRRigReferance.singlton.root.rotation;

            head.position = VRRigReferance.singlton.head.position;
            head.rotation = VRRigReferance.singlton.head.rotation;

            lefthand.position = VRRigReferance.singlton.lefthand.position;
            lefthand.rotation = VRRigReferance.singlton.lefthand.rotation;

            righthand.position = VRRigReferance.singlton.righthand.position;
            righthand.rotation = VRRigReferance.singlton.righthand.rotation;
        }


    }
}
