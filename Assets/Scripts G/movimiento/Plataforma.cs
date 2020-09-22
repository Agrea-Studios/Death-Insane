using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float speed = 2f;
    public float Xm;
    public float Xma;
    private float Tiempo = 2f;

    private GameObject alcance;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
        StartCoroutine("Alcance");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateTarget()
    {
        if (alcance == null)
        {
            alcance = new GameObject("Alcance");
            alcance.transform.position = new Vector2(Xm, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
            return;
        }

        if (alcance.transform.position.x == Xm)
        {
            alcance.transform.position = new Vector2(Xma, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (alcance.transform.position.x == Xma)
        {
            alcance.transform.position = new Vector2(Xm, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private IEnumerator Alcance()
    {
        while (Vector2.Distance(transform.position, alcance.transform.position) > 0.05f)
        {
            Vector2 direction = alcance.transform.position - transform.position;
            float direccionX = direction.x;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            yield return null;
        }

        transform.position = new Vector2(transform.position.x, transform.position.y);
        
        yield return new WaitForSeconds(Tiempo);
        UpdateTarget();
        StartCoroutine("Alcance");
    }
}
