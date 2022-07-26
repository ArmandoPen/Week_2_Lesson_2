using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    Transform _player; 
    // Start is called before the first frame update
    void Start()
    {
        _player= GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(_player.transform, 2 * Time.deltaTime);
    }
}
