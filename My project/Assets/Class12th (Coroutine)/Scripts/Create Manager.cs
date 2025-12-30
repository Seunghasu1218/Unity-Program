using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float time;

    void Start()
    {
       GameObject clone = Instantiate(prefab);

       clone.transform.rotation = Quaternion.Euler(0f, 180.0f, 0f);
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 5.0f)
        {
            GameObject clone = Instantiate(prefab);

            clone.transform.rotation = Quaternion.Euler(0f, 180.0f, 0f);

            time = 0.0f;
        }
    }
}