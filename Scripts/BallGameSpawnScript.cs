using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGameSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject _dusmanBall;
    [Range(1, 5)] [SerializeField] float _minSpawnTime;
    [Range(2, 6)] [SerializeField] float _maxSpawnTime;
    [SerializeField] Transform _spawner;
    float _spawnHiz , _currentTime;
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _spawnHiz)
        { 
            Spawn();
        }
    }
   public void SpawnTimer()
    {
        _currentTime = 0;
        _spawnHiz = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    public void Spawn()
    {
       
        //Vector3 _dusmanPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f,4f) , 0); //Instantiate koduna _dusmanPosition verirsen haritada random verir
        Instantiate(_dusmanBall, _spawner.position, Quaternion.identity);
        SpawnTimer();
    }
}
