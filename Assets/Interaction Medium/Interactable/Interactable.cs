using System;
using System.Collections.Generic;
using UnityEngine;

namespace Interactable
{
    [RequireComponent(typeof(Animator))]
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private string _question;
        [SerializeField] private GameObject _highlightableObject;
        [SerializeField] private GameObject _highLightedObject;
        [SerializeField] private float _highLightHeight;
        [SerializeField] private QuestionUi _QuestionUI;
        private Animator _anime;

        public static readonly List<Interactable> Interactables = new List<Interactable>();

        void Start()
        {
            if(_highlightableObject == null)
                return;

            var obj = Instantiate(_highlightableObject,new Vector3(transform.position.x,  _highLightHeight, transform.position.z),transform.rotation ,transform);
            _highLightedObject = obj;
            Interactables.Add(this);
            _anime = GetComponent<Animator>();
            _anime.Play("Bounce");
        }


        public void ShowTheQuestion()
        {
            Destroy(_highLightedObject);
            Interactables.Remove(this);
            _QuestionUI.ShowQuestion(_question);
        }
    }
}
