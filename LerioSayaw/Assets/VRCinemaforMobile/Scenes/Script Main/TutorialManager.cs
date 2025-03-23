using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private GameObject carinosaDance;
    [SerializeField] private GameObject lerionDance;
    [SerializeField] private AudioSource audioSource;

    // Main music tracks
    [SerializeField] private AudioClip lerionMusic;
    [SerializeField] private AudioClip carinosaMusic;

    [SerializeField] private AudioClip[] carinosaFigureClips = new AudioClip[8];

    [SerializeField] private AudioClip[] lerionFigureClips = new AudioClip[6];

    [SerializeField] private TextMeshProUGUI resultText;

    private AudioSource figureAudioSource;
    private Coroutine currentTutorialCoroutine;

    private void Awake()
    {
        figureAudioSource = gameObject.AddComponent<AudioSource>();
        figureAudioSource.playOnAwake = false;
    }

    public void TutorialCarinosa()
    {
        StopAllTutorials();

        audioSource.clip = carinosaMusic;
        audioSource.Play();

        carinosaDance.SetActive(true);
        lerionDance.SetActive(false);

        currentTutorialCoroutine = StartCoroutine(CarinosaTutorialText());
    }

    public void TutorialLerion()
    {
        StopAllTutorials();

        audioSource.clip = lerionMusic;
        audioSource.Play();

        lerionDance.SetActive(true);
        carinosaDance.SetActive(false);

        currentTutorialCoroutine = StartCoroutine(LerionTutorialText());
    }

    private void StopAllTutorials()
    {
        if (currentTutorialCoroutine != null)
        {
            StopCoroutine(currentTutorialCoroutine);
        }

        audioSource.Stop();
        figureAudioSource.Stop();

        resultText.text = "";
    }

    IEnumerator CarinosaTutorialText()
    {
        yield return new WaitForSeconds(5f);

        // Figure 1
        PlayFigureAudio(carinosaFigureClips[0]);
        resultText.text = "Figure 1 - Three Steps and Point: Dancers take three steps sideward to the right, starting with the right foot, and point the left foot in front. The right hand is in a reverse 'T' position while the left hand is on the skirt/waist. A kumintang is performed with the right hand when pointing the left foot.";

        yield return new WaitForSeconds(20f); // (25s - 5s)

        // Figure 2
        PlayFigureAudio(carinosaFigureClips[1]);
        resultText.text = "Figure 2 - Pointing: Dancers take three steps forward to meet at the center and perform four alternating touch steps in front. They then take four steps forward to switch places, passing each other by the right shoulder. Finally, they turn right to face each other and close the right foot to the left foot.";

        yield return new WaitForSeconds(19f); // (44s - 25s)

        // Figure 3
        PlayFigureAudio(carinosaFigureClips[2]);
        resultText.text = "Figure 3 - Back-to-Back: Partners meet at the center, then turn right to move into a back-to-back position slightly to the right of the partner. The girl holds the skirt while the boy places his hands on his waist. They point the right foot in front, shake their right thumb over the right shoulder, then step right sideward to stand side by side.";

        yield return new WaitForSeconds(19f); // (63s - 44s)

        // Figure 4
        PlayFigureAudio(carinosaFigureClips[3]);
        resultText.text = "Figure 4 - Hide-and-Seek with Fan: The girl holds an imaginary open fan with her right hand and covers her face while pointing the right foot in front. The boy alternates pointing his right and left foot forward while looking at the girl from underneath the imaginary fan. His hands remain on his waist as he observes his partner's movements.";

        yield return new WaitForSeconds(18f); // (81s - 63s)

        // Figure 5
        PlayFigureAudio(carinosaFigureClips[4]);
        resultText.text = "Figure 5 - Kneeling and Fanning: Dancers take three steps forward to the center, where the girl kneels while the boy moves around her right side to stand behind her. The boy then points his right and left foot alternately four times while looking over the girl's shoulders. Meanwhile, the girl looks back at him over her right and left shoulder.";

        yield return new WaitForSeconds(19f); // (100s - 81s)

        // Figure 6
        PlayFigureAudio(carinosaFigureClips[5]);
        resultText.text = "Figure 6 - Hide-and-Seek with Handkerchief: Partners meet at the center as the boy pretends to hold an imaginary handkerchief at its corners in a perpendicular position between their faces. The girl acts as if she is holding the lower end of the imaginary handkerchief while the boy's hands remain on top at face level. While performing four touch steps, they move their hands up and down as if playfully holding the handkerchief.";

        yield return new WaitForSeconds(18f); // (118s - 100s)

        // Figure 7
        PlayFigureAudio(carinosaFigureClips[6]);
        resultText.text = "Figure 7 - Flirting with Handkerchief: Partners turn their right shoulders toward each other and take eight waltz steps forward in a clockwise direction. The girl pretends to hold an imaginary handkerchief at one corner, placing it over her right and left shoulder alternately while looking back at the boy. The boy follows behind, stretching out his right and left hand alternately as if trying to catch the free end of the imaginary handkerchief.";

        yield return new WaitForSeconds(19f); // (137s - 118s)

        // Figure 8
        PlayFigureAudio(carinosaFigureClips[7]);
        resultText.text = "Figure 8 - Flirting: Dancers take 16 waltz steps from side to side while playfully interacting. The boy then kneels on his right knee and stretches out his hands as if holding the imaginary handkerchief toward the girl. Meanwhile, the girl, still standing, points her left foot and stretches her hands as if holding the other end of the imaginary handkerchief.";
    }

    IEnumerator LerionTutorialText()
    {
        yield return new WaitForSeconds(50f);

        // Figure 1
        PlayFigureAudio(lerionFigureClips[0]);
        resultText.text = "Figure 1 - Libad: The dance sequence involves coordinated movements where the boy and girl alternate facing the audience while maintaining synchronized hand motions. They perform a combination of stamping, turning, and waltzing in different directions, often transitioning between back-to-back and face-to-face positions. The routine concludes with a three-step turn, and then the entire sequence is repeated with reversed facings and positions.";

        yield return new WaitForSeconds(35f); // (85s - 50s)

        // Figure 2
        PlayFigureAudio(lerionFigureClips[1]);
        resultText.text = "Figure 2 - Kunday: This figure is similar to the previous one but includes clapping and specific hand movements called 'Kunday.' The dancers repeat the steps from Figure 1, adding synchronized claps and alternating arm positions while waltzing. The sequence ends with a three-step turn, followed by repeating the entire routine with reversed facings and positions.";

        yield return new WaitForSeconds(40f); // (125s - 85s)

        // Figure 3
        PlayFigureAudio(lerionFigureClips[2]);
        resultText.text = "Figure 3 - Katok: This figure follows the same structure as the previous ones, incorporating the hand movements from Figure 2 while repeating steps from Figures 1 and 2. It introduces a tapping motion with alternating arm positions and concludes with a three-step turn. The entire sequence is then repeated with reversed facings and positions.";

        yield return new WaitForSeconds(44f); // (169s - 125s)

        // Figure 4
        PlayFigureAudio(lerionFigureClips[3]);
        resultText.text = "Figure 4 - Kamayan: This figure builds on previous steps, adding a new element where partners join right hands and perform ten step swings while moving their hands as if shaking. After releasing hold, they execute a three-step turn, maintaining the familiar hand placements. The sequence is then repeated with left hands joined, finishing in proper places.";

        yield return new WaitForSeconds(41f); // (210s - 169s)

        // Figure 5
        PlayFigureAudio(lerionFigureClips[4]);
        resultText.text = "Figure 5 - Kawit: This figure follows the same structure as the previous ones but introduces a movement where partners hold each other's right forearms and perform ten step-brush-swings in a clockwise direction. After releasing hold, they execute a three-step turn, maintaining traditional hand placements. The sequence is then repeated with the left forearm hold, moving counterclockwise, and finishing in proper places.";

        yield return new WaitForSeconds(46f); // (256s - 210s)

        // Figure 6
        PlayFigureAudio(lerionFigureClips[5]);
        resultText.text = "Figure 6 - Labas-Pasok: This figure involves waltzing in back-to-back positions while alternating facings, incorporating the same hand movements from Figure 2. The sequence is repeated twice before transitioning into a three-step turn with traditional hand placements. Finally, the entire routine is repeated, ending with a bow to the partner or audience.";
    }

    private void PlayFigureAudio(AudioClip clip)
    {
        if (clip != null)
        {
            // Stop any currently playing figure audio
            figureAudioSource.Stop();

            // Play the new figure audio clip
            figureAudioSource.clip = clip;
            figureAudioSource.Play();
        }
    }
}