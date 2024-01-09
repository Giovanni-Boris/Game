using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlNave : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;
    AudioSource audioSource;
    VidaPlayer playerVida;
    CombustiblePlayer combustiblePlayer;
    Vector3 initialPosition;
    Quaternion initialRotation;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
        playerVida = GetComponent<VidaPlayer>();
        combustiblePlayer = GetComponent<CombustiblePlayer>();
        initialPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z) ;
        initialRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
    }

    void Update()
    {
        //Debug.Log(Time.deltaTime + " seg  " + (1.0f/Time.deltaTime) +"  FPS");
        ProcesarInput();
    }
    private void ProcesarInput()
    {
        propulsion();
        rotacion();
    }
    private void propulsion()
    {
        if (Input.GetKey(KeyCode.W))
        {
            combustiblePlayer.bajarCombustible();
            rigidbody.freezeRotation = true;
            rigidbody.AddRelativeForce(Vector3.down);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
        rigidbody.freezeRotation = false;
    }
    private void rotacion() 
    {
        if (Input.GetKey(KeyCode.D))
        {
            var rotarDerecha = transform.rotation;
            rotarDerecha.y -= Time.deltaTime * 1;
            transform.rotation = rotarDerecha;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            var rotarIzquierda = transform.rotation;
            rotarIzquierda.y += Time.deltaTime * 1;
            transform.rotation = rotarIzquierda;
        }
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "colisionSegura":
                print("Colision segura");
                break;
            case "Gasolina":
                print("Gasolina");
                break;
            case "Aterrizaje":
                SceneManager.LoadScene("Nivel2");
                break;
            default:
                if (playerVida.bajarVida() && combustiblePlayer.getCombustible() != 0)
                {
                    transform.position = initialPosition;
                    transform.rotation = initialRotation;
                }
                
                break;
        }
    }
}
