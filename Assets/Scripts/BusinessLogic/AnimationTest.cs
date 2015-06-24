using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour
{
    private Animation _anim;

    void Start()
    {
        _anim = this.GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            _anim.Play("attack1");
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            _anim.Play("attack2");
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            _anim.Play("attack3");
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            _anim.Play("die");
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            _anim.Play("skill1");
        }

        if (Input.GetKeyDown(KeyCode.F6))
        {
            _anim.Play("skill2");
        }

        if (Input.GetKeyDown(KeyCode.F7))
        {
            _anim.Play("winner");
        }

        if (Input.GetKeyDown(KeyCode.F8))
        {
            _anim.Play("move");
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            _anim.Play("get_up");
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            _anim.Play("hit_up");
        }
    }
}
