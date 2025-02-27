using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameScene : UI_Scene
{
    public enum Images
    {
        MainWindowPanel,
        ProfileImage,
        CharacterLevelPanel,
        CharacterImage,
        CharacterStatusPanel,
    }

    public enum Buttons
    {
        MainButton,
        StageButton,
        StoryButton,
        CharacterButton,
        CafeButton,
        SettingButton,
        ProfileButton,
        CharacterWindowBackButton,
    }

    public enum Texts
    {
        ProfileNameText,
        LevelText,
        AttackStatusText,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindImages(typeof(Images));
        BindButtons(typeof(Buttons));
        BindTexts(typeof(Texts));

        //TODO


        return true;
    }
}
