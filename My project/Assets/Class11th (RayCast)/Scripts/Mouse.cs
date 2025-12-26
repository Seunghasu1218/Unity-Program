using Unity.Collections;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycasthit;

    [SerializeField] float duration = 1.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycasthit, Mathf.Infinity))
            {
                Debug.DrawLine(ray.origin, raycasthit.point, Color.red, duration);
            }
        }
    }
}
