using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DozerPush : MonoBehaviour
{
    [SerializeField] GameObject _start;
    [SerializeField] GameObject _finish;
    [SerializeField] public float speed = 1.0f;
    bool _atStart;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = _start.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed* Time.deltaTime;
        if (transform.position == _start.transform.position)
        {
            _atStart = true;
        }
        else if (transform.position == _finish.transform.position) { 
            _atStart = false;
        }

        if (_atStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, _finish.transform.position, step);
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, _start.transform.position, step);
        }
    }
}
