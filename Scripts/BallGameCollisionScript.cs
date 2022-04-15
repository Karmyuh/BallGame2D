using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGameCollisionScript : MonoBehaviour
{

    [SerializeField] GameObject _playerGO, _kol;
    [SerializeField] Rigidbody2D _playerRigid;
    [SerializeField] Text _gameOverText,_scoreText;
    [SerializeField] float _hiz = 10;
    int _score = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Time.timeScale = 0;
            _gameOverText.text = "Game Over";
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Duvar"))
        {
            Hareket();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(collision.gameObject);
            _score += 10;
            _scoreText.text = $"Score = {_score}";
        }
    }

    public void Hareket()
    {
        int _random = Random.Range(1, 8);
        if (_random == 2)
        {
            Move2();
        }
        else if (_random == 3)
        {
            Move3();
        }
        else if (_random == 4)
        {
            Move4();
        }
        else if (_random == 5)
        {
            Move1();
            Move3();
        }
        else if (_random == 6)
        {
            Move2();
            Move4();
        }
        else if (_random == 7)
        {
            Move1();
            Move4();
        }
        else if (_random == 7)
        {
            Move2();
            Move3();
        }
        else
        {
            Move1();
        }
    }
    public void Move1()
    {
        _playerRigid.velocity = Vector2.up * Time.deltaTime * _hiz;
    }
    public void Move2()
    {
        _playerRigid.velocity = Vector2.down * Time.deltaTime * _hiz;
    }
    public void Move3()
    {
        _playerRigid.velocity = Vector2.left * Time.deltaTime * _hiz;
    }
    public void Move4()
    {
        _playerRigid.velocity = Vector2.right * Time.deltaTime * _hiz;
    }
}
