using UnityEngine;

namespace ScreenVideoPlayer
{
    public class ScreenZone : MonoBehaviour
    {
        [SerializeField] GameObject screen;
        [SerializeField] GameObject buttonsPanel;
        [SerializeField] GameObject infPanel;
        [SerializeField] GameObject statue;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                statue.SetActive(false);
                screen.SetActive(true);
                infPanel.SetActive(false);
                buttonsPanel.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                screen.SetActive(false);
                statue.SetActive(true);
                buttonsPanel.SetActive(false);
                infPanel.SetActive(true);
            }
        }

    }

}
