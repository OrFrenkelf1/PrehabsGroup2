using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] GameObject hat;
    [SerializeField] GameObject hatEars;
    [SerializeField] GameObject bunny;
    [SerializeField] GameObject amongUs;
    [SerializeField] GameObject poof;

    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            First();
            anim.SetTrigger("Morph");
        }


        if (Input.GetKeyUp(KeyCode.F))
        {
            Second();
            anim.SetTrigger("Morph");
        }
    }


    void First()
    {
        print("first");
        hat.SetActive(true);
        bunny.SetActive(true);
        poof.SetActive(true);
        hatEars.SetActive(false);
        amongUs.SetActive(false);
    }

    void Second()
    {
        print("second");
        bunny.SetActive(false);
        amongUs.SetActive(true);


    }

}
