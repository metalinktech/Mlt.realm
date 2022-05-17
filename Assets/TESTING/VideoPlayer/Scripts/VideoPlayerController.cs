using UnityEngine;
using UnityEngine.Video;

namespace ScreenVideoPlayer
{
    public class VideoPlayerController : MonoBehaviour
    {
        [SerializeField] VideoPlayer video;

        bool clipMuted;
        bool clipPlayed;


        public void PlayOrPauseClip()
        {
            Debug.Log("PLAY");
            if (!clipPlayed)
                video.Play();
            else
                video.Pause();

            clipPlayed = !clipPlayed;
        }

        public void StopClip()
        {
            video.Stop();
            clipPlayed = false;
        }

        public void MuteClip()
        {
            if (clipMuted)
                video.SetDirectAudioMute(0, false);
            else
                video.SetDirectAudioMute(0, true);

            clipMuted = !clipMuted;
        }

        public void SkypFewSecondsClip(float time)
        {
            video.time += time;
        }

    }

}
