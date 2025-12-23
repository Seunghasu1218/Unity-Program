using UnityEngine;

public class Cheracter : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
