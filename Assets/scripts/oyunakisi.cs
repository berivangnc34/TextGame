using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunakisi : MonoBehaviour
{

    [SerializeField] Text hikayeyazisi;
    public durum baslangıcdurum;
    durum gunceldurum;

    // Start is called before the first frame update
    void Start()
    {
        gunceldurum = baslangıcdurum;
        //hikayeyazisi.text = baslangıcdurum.HikayeMetniniAl();
        hikayeyazisi.text = gunceldurum.HikayeMetniniAl();




        //hikayeyazısı textini oluşturdugun hikayeyazisina atıyorsun. o yüzden hikaye yazısı içindeki yazı değişiyor.
    }

    // Update is called once per frame
    void Update()
    {
        durum[] sonrakidurumlar = gunceldurum.SonrakiDurumlariAl(); //digee scripten çektik
          
       /* for(int i=0; i < sonrakidurumlar.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {

                gunceldurum = sonrakidurumlar[i];
            }
            
        } */
        
        
        
        
        //var sonrakidurumlar = gunceldurum.SonrakiDurumlariAl();

         if (Input.GetKeyDown(KeyCode.Alpha1))
         {
             gunceldurum = sonrakidurumlar[0];
         }
         else if (Input.GetKeyDown(KeyCode.Alpha2))
         {
             gunceldurum = sonrakidurumlar[1];
         }
         else if (Input.GetKeyDown(KeyCode.Alpha3))
         {
             gunceldurum = sonrakidurumlar[2];
         }
         hikayeyazisi.text = gunceldurum.HikayeMetniniAl();


     }
     
    }

