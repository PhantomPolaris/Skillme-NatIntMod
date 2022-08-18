using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interactable
{
    internal class QuestionUi : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _question;
        [SerializeField] private Button _confirmButton;

        private void Start()
        {
            _confirmButton.onClick.AddListener(ConfirmQuestion);
            gameObject.SetActive(false);
        }

        private void ConfirmQuestion()
        {
            gameObject.SetActive(false);
        }

        public void ShowQuestion(string question)
        {
            gameObject.SetActive(true);
            _question.text = question;
        }
    }
}