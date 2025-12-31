using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] WaitForSeconds waitForSeconds;
    [SerializeField] float time;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(time);
    }

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            GameObject clone = Instantiate(prefab, gameObject.transform);

            clone.transform.position = new Vector3(Random.Range(-2.0f, 2.0f),0f,0f);

            clone.transform.rotation = Quaternion.Euler(0f, 180.0f, 0f);
        }
    }
}