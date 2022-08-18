using System;
using UnityEngine;
using UnityEngine.UI;

namespace Interactable
{
    public class Interacting : MonoBehaviour
    {
        [SerializeField] private double _minDistance = 3;
        [SerializeField] private Button _button;
        [SerializeField] private Interactable _currentInteracting;

        private void Start()
        {
            _button.onClick.AddListener(ShowQuestion);
            _button.gameObject.SetActive(false);
        }

        private void ShowQuestion()
        {
            _button.gameObject.SetActive(false);
            _currentInteracting.ShowTheQuestion();
        }

        private void Update()
        {
            foreach (var interactable in Interactable.Interactables)
            {
                if (Vector3.Distance(interactable.transform.position, gameObject.transform.position) < _minDistance)
                {
                    _button.gameObject.SetActive(true);
                    _currentInteracting = interactable;
                }
                else if (_button.IsActive())
                {
                    _button.gameObject.SetActive(false);
                }
            }
        }
    }
}
