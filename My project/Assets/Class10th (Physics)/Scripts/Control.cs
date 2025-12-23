using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] Vector3 direction;
    [SerializeField] ForceMode forceMode;
    [SerializeField] float speed;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        forceMode = ForceMode.Force;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(direction * speed, forceMode);
    }
}
