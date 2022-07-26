using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bullet : MonoBehaviour
{
    public float deathTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime);
    }
    public void SetRot(Vector3 ag)
    {
        transform.eulerAngles = ag;
    }
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }
}
