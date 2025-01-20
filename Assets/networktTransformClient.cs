using UnityEngine;
using Unity.Netcode.Components;

public class networktTransformClient : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}
