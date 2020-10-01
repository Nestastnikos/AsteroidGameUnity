using Assets.Scripts.Core.Spaceship;
using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class FuelBarView : MonoBehaviour
    {
        private Slider _slider;

        private void Start()
        {
            var fuelTank = App.Models.Spaceship.FuelTank;
            _slider = GetComponent<Slider>();
            _slider.maxValue = fuelTank.MaxAmount;
            _slider.value = fuelTank.CurrentAmount;
        }

        private void OnEnable()
        {
            SpaceshipMovementAction.OnFuelChange += SetFuelBarValue;
        }

        private void OnDisable()
        {
            SpaceshipMovementAction.OnFuelChange -= SetFuelBarValue;
        }

        private void SetFuelBarValue(float amount)
        {
            _slider.value = amount;
        }
    }
}
