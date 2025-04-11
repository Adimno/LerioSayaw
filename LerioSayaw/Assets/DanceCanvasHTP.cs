using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceCanvasHTP : MonoBehaviour
{
    public GameObject welcomeCanvas, LookCanvas, CongratsCanvas, GoodluckCanvas, ScorePartBronze;
    public GameObject WallAppearanceCanvas, GameplayFlowCanvas, ScoringSystemCanvas, IMUCanvas, IMUCanvasGuide, IMUCanvasImage;
    public GameObject FiguresCanvas;

    // assets 

    public GameObject WallCollider, MenuTutorial; 

    void Start()
    {
        // Start with only the welcome screen active
        welcomeCanvas.SetActive(true);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        WallCollider.SetActive(true);
        MenuTutorial.SetActive(false);
        IMUCanvasGuide.SetActive(false);
        IMUCanvasImage.SetActive(false);
        ScorePartBronze.SetActive(false);

    }

    public void welcomeShow()
    {
        welcomeCanvas.SetActive(true);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }
  
  // start game 
    public void LookCanvasLogic()
    {
        IMUCanvasGuide.SetActive(false);
        LookCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        WallCollider.SetActive(false);
        MenuTutorial.SetActive(true);
        
    }

    public void CharacterCanvas()
    {
        LookCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    public void DanceCanvasLogic()
    {
        GoodluckCanvas.SetActive(true);
        LookCanvas.SetActive(false);
        welcomeCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    public void CongratsCanvasLogic()
    {
        CongratsCanvas.SetActive(true);
        LookCanvas.SetActive(false);
        welcomeCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    // ========== TUTORIAL SECTIONS ==========
    public void ShowWallAppearance()
    {
        WallAppearanceCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    public void ShowGameplayFlow()
    {
        GameplayFlowCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    public void ShowScoringSystem()
    {
        ScoringSystemCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

       public void ShowScoringSystemTwo()
    {
        ScorePartBronze.SetActive(true);
        ScoringSystemCanvas.SetActive(false);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        
    }

    public void ShowIMU()
    {
        IMUCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);
        ScorePartBronze.SetActive(false);
        
    }

        public void ShowIMUGuide()
    {
        IMUCanvasGuide.SetActive(true);
        IMUCanvasImage.SetActive(true);
        IMUCanvas.SetActive(false);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        FiguresCanvas.SetActive(false);

        
    }

    public void FiguresCanvasLogic()
    {
         ScorePartBronze.SetActive(false);
        FiguresCanvas.SetActive(true);
        welcomeCanvas.SetActive(false);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
        WallAppearanceCanvas.SetActive(false);
        GameplayFlowCanvas.SetActive(false);
        ScoringSystemCanvas.SetActive(false);
        IMUCanvas.SetActive(false);
    }
}
