﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppSettings;

public class WND_InstanceSetting : UIFormBase
{

    // Use this for initialization

    private UISlider sliderVoice;
    private UISlider sliderMusic;
    private GameObject spExit;
    private UISprite spVoice;
    private UISprite spMusic;
    private GameObject btnChangeIcon;
    private UITexture headIcon;
    private GameObject btnGiveUp;
    private GameObject btnConfim;
    private int myIconIndex;
    private UIToggle Fast;
    private UIToggle Mid;
    private UIToggle Slow;
    private UIToggle togVoice;
    private UIToggle togMusic;
    protected override void OnInit(object userdata)
    {
        base.OnInit(userdata);
        spVoice = transform.Find("bg/frame/spVoice").GetComponent<UISprite>();
        sliderVoice = spVoice.transform.Find("sliderVoice").GetComponent<UISlider>();
        spMusic = transform.Find("bg/frame/spMusic").GetComponent<UISprite>();
        sliderMusic = spMusic.transform.Find("sliderMusic").GetComponent<UISlider>();
        spExit = transform.Find("bg/frame/spExit").gameObject;
        headIcon = transform.Find("bg/frame/texHead").GetComponent<UITexture>();
        btnGiveUp = transform.Find("bg/frame/btnGiveUp").gameObject;
        btnConfim = transform.Find("bg/frame/btnConfim").gameObject;
        Fast = transform.Find("bg/frame/spDialogSpeed/toggleFast").GetComponent<UIToggle>();
        Mid = transform.Find("bg/frame/spDialogSpeed/toggleMid").GetComponent<UIToggle>();
        Slow = transform.Find("bg/frame/spDialogSpeed/toggleSlow").GetComponent<UIToggle>();
        togVoice = spVoice.GetComponent<UIToggle>();
        togMusic = spMusic.GetComponent<UIToggle>();

        UIEventListener.Get(btnGiveUp).onClick = GiveUpClick;

        UIEventListener.Get(spExit.gameObject).onClick = ExitClick;
        UIEventListener.Get(btnConfim).onClick = ExitClick;
        EventDelegate.Add(togVoice.onChange, OnVoiceMute);
        EventDelegate.Add(togMusic.onChange, OnMusicMute);
        sliderVoice.onDragFinished = OnVoiceSave;
        sliderMusic.onDragFinished = OnMusicSave;
        EventDelegate.Add(sliderMusic.onChange, MusicChange);
        EventDelegate.Add(sliderVoice.onChange, VoiceChange);
        EventDelegate.Add(Fast.onChange, FastChange);
        EventDelegate.Add(Mid.onChange, MidChange);
        EventDelegate.Add(Slow.onChange, SlowChange);

    }

    protected override void OnOpen()
    {
        base.OnOpen();

        headIcon.Load(myIconIndex);
        if (Game.DataManager.DialogSpeed == 0.1f)
            Fast.value = true;
        else if (Game.DataManager.DialogSpeed == 0.5f)
            Mid.value = true;
        else if (Game.DataManager.DialogSpeed == 1.0f)
            Slow.value = true;
        togMusic.value = Game.Sound.MusicMute;
        togVoice.value = Game.Sound.ALLMute;
        sliderMusic.value = Game.Sound.MusicVolume;
        sliderVoice.value = Game.Sound.AllVolume;

    }
    private void OnMusicSave()
    {
        Game.Sound.SaveMusicVolume(sliderMusic.value);
    }

    private void OnVoiceSave()
    {
        Game.Sound.SaveAllVolume(sliderVoice.value);
    }

    private void OnMusicMute()
    {
        Game.Sound.MusicMute = togMusic.value;
    }

    private void OnVoiceMute()
    {
        Game.Sound.ALLMute = togVoice.value;
    }
    private void VoiceChange()
    {
        Game.Sound.AllVolume = sliderVoice.value;
    }
    private void MusicChange()
    {
        Game.Sound.MusicVolume = sliderMusic.value;
    }
    private void ExitClick(GameObject obj)
    {
        Game.UI.CloseForm<WND_InstanceSetting>();

    }
    private void GiveUpClick(GameObject obj)
    {
        UIUtility.ShowMessageBox(MessageBoxType.YesNo, 1003005, (result) =>
        {
            if (result == MessageBoxReturnType.Yes)
            {
                if (MapMgr.Inited)
                {
                    MapMgr.Instance.BackToMaintown();
                }
            }
        });

    }

    private void FastChange()
    {
        if (UIToggle.current.value == true)
        {
            Game.DataManager.DialogSpeed = 0.1f;
        }

    }
    private void MidChange()
    {
        if (UIToggle.current.value == true)
        {
            Game.DataManager.DialogSpeed = 0.5f;
        }

    }
    private void SlowChange()
    {
        if (UIToggle.current.value == true)
        {
            Game.DataManager.DialogSpeed = 1.0f;
        }

    }
}
