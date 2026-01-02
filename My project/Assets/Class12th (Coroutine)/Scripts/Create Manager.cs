using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] Transform[] transforms; 
    [SerializeField] GameObject prefab;
    [SerializeField] WaitForSeconds waitForSeconds;
    [SerializeField] float time;
    [SerializeField] int random;

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
            random = Random.Range(0, transforms.Length);

            yield return new WaitForSeconds(time);

            GameObject clone = Instantiate(prefab, gameObject.transform);

            clone.transform.localPosition = transforms[random].position;

            clone.transform.rotation = Quaternion.Euler(0f, 180.0f, 0f);
        }
    }
}