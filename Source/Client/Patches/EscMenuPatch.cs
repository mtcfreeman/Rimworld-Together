﻿using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace RimworldTogether
{
    [HarmonyPatch(typeof(MainMenuDrawer), "DoMainMenuControls")]
    public static class EscMenuPatch
    {
        [HarmonyPrefix]
        public static bool DoPre()
        {
            if (Network.isConnectedToServer && Current.ProgramState == ProgramState.Playing)
            {
                Vector2 buttonSize = new Vector2(170f, 45f);

                if (Widgets.ButtonText(new Rect(0, (buttonSize.y + 7) * 2, buttonSize.x, buttonSize.y), ""))
                {
                    DialogManager.PushNewDialog(new RT_Dialog_Wait("Syncing save with the server"));

                    Find.MainTabsRoot.EscapeCurrentTab(playSound: false);
                    ClientValues.ToggleDisconnecting(true);
                    SavePatch.ForceSave();
                }

                if (Widgets.ButtonText(new Rect(0, (buttonSize.y + 7) * 3, buttonSize.x, buttonSize.y), ""))
                {
                    DialogManager.PushNewDialog(new RT_Dialog_Wait("Syncing save with the server"));

                    Find.MainTabsRoot.EscapeCurrentTab(playSound: false);
                    ClientValues.ToggleQuiting(true);
                    SavePatch.ForceSave();
                }
            }

            return true;
        }
    }
}
