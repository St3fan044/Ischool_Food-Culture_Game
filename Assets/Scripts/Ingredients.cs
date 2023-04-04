using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingredients : MonoBehaviour
{
    public AudioClip malus_sound;

    public SliderController slider;

    private Dictionary<ingridient_type, bool> ingridient_cek = new Dictionary<ingridient_type, bool>();

    private void Start()
    {
        ingridient_cek[ingridient_type.Acqua] = false;
        ingridient_cek[ingridient_type.Farina] = false;
        ingridient_cek[ingridient_type.Uova] = false;
        ingridient_cek[ingridient_type.Farina_di_Semola] = false;
        ingridient_cek[ingridient_type.Maincato_di_Salame] = false;
        ingridient_cek[ingridient_type.Prezzemolo] = false;
        ingridient_cek[ingridient_type.Pere] = false;
        ingridient_cek[ingridient_type.Pepe] = false;
        ingridient_cek[ingridient_type.Formaggio] = false;
        ingridient_cek[ingridient_type.Carne_Bovina] = false;
        ingridient_cek[ingridient_type.Pane] = false;
        ingridient_cek[ingridient_type.Uva_Sultanina] = false;
        ingridient_cek[ingridient_type.Amaretti] = false;
        ingridient_cek[ingridient_type.Noce_Moscata] = false;
        ingridient_cek[ingridient_type.Limone] = false;
        ingridient_cek[ingridient_type.Cannella] = false;
        ingridient_cek[ingridient_type.Sale_Marino] = false;
        ingridient_cek[ingridient_type.Sale] = false;
        ingridient_cek[ingridient_type.Aglio] = false;
        ingridient_cek[ingridient_type.Burro_Fuso] = false;
        ingridient_cek[ingridient_type.Salvia] = false;
        ingridient_cek[ingridient_type.Brodo_Carne] = false;
        ingridient_cek[ingridient_type.Prosciutto] = false;
        ingridient_cek[ingridient_type.Erbe_Cotte] = false;
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if (other.gameObject.CompareTag("ingredienti"))
        {
            var ing_type = other.gameObject.GetComponent<ingrifient_type>().type;

            Destroy(other.gameObject);
            
            if (ingridient_cek[ing_type] == false)
            {
                ingridient_cek[ing_type] = true;
                slider.UpdateSlider(10);
            }
        }

        if (other.gameObject.CompareTag("malus"))
        {
            Destroy(other.gameObject);
            FindObjectOfType<AudioSource>().PlayOneShot(malus_sound);
        }
    }
    
}
