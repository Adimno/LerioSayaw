using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // The VideoPlayer component
    public Button playButton;        // Button to play the video
    public Button skipButton;        // Button to skip the video
    public GameObject videoPanel;    // Panel containing the video player (optional)
    public GameObject resultPanel;   // The panel that appears after the video ends or is skipped

    void Start()
    {
        // Ensure the panels and buttons are in their default states
        resultPanel.SetActive(false);      // Hide the result panel
        videoPlayer.gameObject.SetActive(false);  // Hide video initially

        // Listen for button click events
        playButton.onClick.AddListener(PlayVideo);
        skipButton.onClick.AddListener(SkipVideo);

        // Optionally, trigger the method when the video finishes
        videoPlayer.loopPointReached += EndReached;
    }

    // Play the video and hide the play button
    public void PlayVideo()
    {
        videoPlayer.gameObject.SetActive(true);  // Show the video player
        videoPlayer.Play();                      // Start playing the video
        playButton.gameObject.SetActive(false);  // Hide the play button after click
    }

    // Skip the video and show the result panel
    public void SkipVideo()
    {
        videoPlayer.Stop();                      // Stop the video
        videoPlayer.gameObject.SetActive(false); // Hide the video player
        resultPanel.SetActive(true);             // Show the result panel
    }

    // This method is triggered when the video reaches the end
    void EndReached(VideoPlayer vp)
    {
        // Show the result panel when the video finishes playing
        resultPanel.SetActive(true);
        videoPlayer.gameObject.SetActive(false); // Hide the video player
    }
}
