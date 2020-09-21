using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float velocidad = 2f;
    public float Xmin;
    public float Xmax;
    public float TiempoEspera = 1f;

    private GameObject limite;
    private Animator animacion;

    void Awake()
    {
        animacion = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        updateLimite();
        StartCoroutine("LimiteEnemigo");
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void updateLimite()
    {
        if (limite == null)
        {
            limite = new GameObject("Limite");
            limite.transform.position = new Vector2(Xmin, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
            return;
        }
        if (limite.transform.position.x == Xmin)
        {
            limite.transform.position = new Vector2(Xmax, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (limite.transform.position.x == Xmax)
        {
            limite.transform.position = new Vector2(Xmin, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private IEnumerator LimiteEnemigo()
    {
        while (Vector2.Distance(transform.position, limite.transform.position) > 0.05f)
        {
            //actualiza la animacion para indicar que estas caminando
            //solo pon que de Idle va a Caminar y de Caminar va a Idle cuando este sea true
            animacion.SetBool("Esperar", false);
            Vector2 direction = limite.transform.position - transform.position;
            float xDirection = direction.x;
            transform.Translate(direction.normalized * velocidad * Time.deltaTime);
            //Importante poner
            yield return null;
        }

        Debug.Log("limite alcanzado");
        transform.position = new Vector2(transform.position.x, transform.position.y);
        updateLimite();

        //actualiza la animacion para indicar que estas esperando
        //aqui viene de regreso a la animacion Idle xd 
        animacion.SetBool("Esperar", true);

        //actualiza la animacion para indicar que estas volando
        /*aqui pones la animacion de volar ya deberias de saberlo xd solo es un trigger xd
        de idle volar pones el parametro y de volar a idle no pongas ningun parametro*/
        animacion.SetTrigger("Volando");



        Debug.Log("a la espera de " + TiempoEspera + "segundos");
        yield return new WaitForSeconds(TiempoEspera); //IMPORTANTE

        Debug.Log("espera el tiempo indicado, actualizate y ejecuta el codigo");

        StartCoroutine("LimiteEnemigo");
    }
}
