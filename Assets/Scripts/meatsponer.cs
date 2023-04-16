using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatsponer : MonoBehaviour
{
    public GameObject meatmeat;
    public float nextspawn = 0.5f;
    public float minispawnposition;
    public float maxispawnposition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(meatDrop());
    }

    IEnumerator meatDrop()
    {
        while (true)
        {
            var wanted = Random.Range(minispawnposition, maxispawnposition);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(meatmeat,position, Quaternion.identity);
            yield return new WaitForSeconds(nextspawn);
        }
    }
}
