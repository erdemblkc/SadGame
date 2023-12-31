using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyBehavior : MonoBehaviour
{
    public int enemySpeed = 10;
    private bool isEating = false;
    public Animator _animator;
    public string animatonName;
    public float animationTime;
    public GameObject deadAnimObject;
    void Start()
    {
        isEating = false;
        //_animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (!isEating)
        {
            EnemyGoesLeft();
        }
        else if(isEating&&Input.GetKey(KeyCode.A))
        {
            EnemyGoesRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            enemySpeed = 27;
        }
        else
        {
            enemySpeed = 23;
        }
    }

    void EnemyGoesLeft()
    {
        transform.Rotate(new Vector3(0, 0 , -1) * Time.deltaTime * enemySpeed);
    }
    void EnemyGoesRight()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * enemySpeed);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Eatable")
        {
            StartCoroutine(EatingEatables(collision));
        }
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(EatingPlayer());
        }
    }

    IEnumerator EatingEatables(Collider2D colliision)
    {
        isEating = true;
        _animator.SetBool(animatonName, true);
        yield return new WaitForSeconds(0.5f);
        Destroy(colliision.gameObject);
        yield return new WaitForSeconds(animationTime);
        _animator.SetBool(animatonName, false);
        isEating = false;
    }

    IEnumerator EatingPlayer()
    {
        isEating = true;
        _animator.SetBool(animatonName, true);
        yield return new WaitForSeconds(animationTime);
        _animator.SetBool(animatonName, true);
        deadAnimObject.GetComponent<Animator>().SetTrigger("End");
        yield return new WaitForSeconds(1f);
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(y);

    }
}
