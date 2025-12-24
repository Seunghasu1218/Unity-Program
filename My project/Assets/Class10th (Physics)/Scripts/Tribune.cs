using UnityEngine;

public class Tribune : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}
