using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "durum")] //create menusunde çıkar.
public class durum : ScriptableObject
{
    [TextArea(12, 10)][SerializeField] string hikayemetni; //serial yerine public yazabilirsin
    //12 satır olsun,10dan sonra scroolbar çıksın

    public durum[] sonrakidurumlar; //durum tipinde dizi

    public string HikayeMetniniAl()
    {
        return hikayemetni;
    }
    public durum[] SonrakiDurumlariAl()
    {
        return sonrakidurumlar;
    }
   
}
