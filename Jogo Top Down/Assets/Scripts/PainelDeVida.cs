using UnityEngine;
using UnityEngine.UI;
public class PainelDeVida : MonoBehaviour
{
    public Personagem personagem;

    public Slider sliderVida;
    public Slider sliderEnergia;
    
    void Start()
    {
        sliderVida.minValue = 0;
        sliderVida.maxValue = personagem.getVida();
        
        
        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
    }

    
    void Update()
    {
        sliderVida.value = personagem.getVida();
        sliderEnergia.value = personagem.getEnergia();
    }
}
