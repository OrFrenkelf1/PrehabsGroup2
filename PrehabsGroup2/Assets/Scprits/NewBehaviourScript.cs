//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class NewBehaviourScript : MonoBehaviour
//{

//    [SerializeField] GameObject hat;
//    [SerializeField] GameObject hatEars;
//    [SerializeField] GameObject bunny;
//    [SerializeField] GameObject amongUs;
//    [SerializeField] GameObject poof;

//    [SerializeField] Animator anim;

//    // Start is called before the first frame update
//    void Start()
//    {
//        print("start");
//        StartCoroutine(Example());
//    }

//    IEnumerator Example()
//    {
//        print("IEnumerator");
//        if (Input.GetKey(KeyCode.F))
//        {
//            First();
//            print("first");
//            anim.SetTrigger("Morph");

//            yield return new WaitForSeconds(1);
//            Second();
//            print("second");
//            anim.SetTrigger("Morph2");
//        }
//    }
//    //private void Update()
//    //{

//    //    if (Input.GetKey(KeyCode.F))
//    //    {
//    //        First();
//    //        anim.SetTrigger("Morph");

//    //        Second();
//    //        anim.SetTrigger("Morph2");
//    //    }


//    //    //if (Input.GetKeyUp(KeyCode.F))
//    //    //{
//    //    //    Second();
//    //    //    anim.SetTrigger("Morph2");
//    //    //}
//    //}


//    void First()
//    {
//        print("first");
//        hat.SetActive(true);
//        bunny.SetActive(true);
//        poof.SetActive(true);
//        hatEars.SetActive(false);
//        amongUs.SetActive(false);
//    }

//    void Second()
//    {
//        print("second");
//        bunny.SetActive(false);
//        amongUs.SetActive(true);
//    }

//}


using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject hat;
    [SerializeField] GameObject hatEars;
    [SerializeField] GameObject bunny;
    [SerializeField] GameObject amongUs;
    [SerializeField] GameObject poof;

    [SerializeField] Animator anim;

    private bool isCoroutineRunning = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && !isCoroutineRunning)
        {
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        isCoroutineRunning = true;

        First();
        anim.SetTrigger("Morph");

        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);


        Second();
        anim.SetTrigger("Morph2");



        isCoroutineRunning = false;
    }

    void First()
    {
        hat.SetActive(true);
        bunny.SetActive(true);
        poof.SetActive(true);
        hatEars.SetActive(false);
        amongUs.SetActive(false);
    }

    void Second()
    {
        bunny.SetActive(false);
        amongUs.SetActive(true);
    }
}

