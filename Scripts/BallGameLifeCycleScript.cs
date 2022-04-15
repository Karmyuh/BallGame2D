using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGameLifeCycleScript : MonoBehaviour
{
    [SerializeField] float _ballLife;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _ballLife)
        {
            Destroy(this.gameObject);
        }
    }
}
