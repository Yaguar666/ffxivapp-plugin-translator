// FFXIVAPP.Plugin.Translator
// Japanese.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution. 
//  * Neither the name of SyndicatedLife nor the names of its contributors may 
//    be used to endorse or promote products derived from this software 
//    without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE. 

using System.Windows;

namespace FFXIVAPP.Plugin.Translator.Localization
{
    public abstract class Japanese
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("Translator_", "*PH*");
            Dictionary.Add("Translator_OpenNowButtonText", "ウィジェットを開く");
            Dictionary.Add("Translator_ResetPositionButtonText", "位置をリセットする");
            Dictionary.Add("Translator_DPSTitleBar", "[DPS]");
            Dictionary.Add("Translator_HPSTitleBar", "[HPS]");
            Dictionary.Add("Translator_DTPSTitleBar", "[DTPS]");
            Dictionary.Add("Translator_EnmityTitleBar", "[敵対]");
            Dictionary.Add("Translator_FocusTitleBar", "[フォーカス]");
            Dictionary.Add("Translator_CurrentTitleBar", "[ターゲット中]");
            Dictionary.Add("Translator_DPSWidgetHeader", "DPSウィジェット");
            Dictionary.Add("Translator_HPSWidgetHeader", "HPSウィジェット");
            Dictionary.Add("Translator_DTPSWidgetHeader", "DTPSウィジェット");
            Dictionary.Add("Translator_EnmityWidgetHeader", "敵対ウィジェット");
            Dictionary.Add("Translator_FocusWidgetHeader", "フォーカスターゲットウィジェット");
            Dictionary.Add("Translator_CurrentWidgetHeader", "現在ターゲットウィジェット");
            Dictionary.Add("Translator_EnableClickThroughHeader", "ウィジェット上のクリックを下に通す");
            Dictionary.Add("Translator_WidgetOpacityHeader", "ウィジェット透過率");
            Dictionary.Add("Translator_GitHubButtonText", "プロジェクトソースを開く(GitHub)");
            Dictionary.Add("Translator_ShowTitlesOnTranslatorHeader", "ウィジェットにタイトルを表示する");
            Dictionary.Add("Translator_ColorsTabHeader", "色");
            Dictionary.Add("Translator_DefaultProgressBarForegroundHeader", "前面プログレスバーのデフォルト色");
            Dictionary.Add("Translator_UIScaleHeader", "UI比率");
            Dictionary.Add("Translator_SortDirectionHeader", "ソート順");
            Dictionary.Add("Translator_SortPropertyHeader", "ソート項目");
            Dictionary.Add("Translator_DisplayPropertyHeader", "表示形式");
            Dictionary.Add("Translator_PlayerVisibilityThresholdHeader", "プレイヤー可視率しきい値");
            Dictionary.Add("Translator_EnmityShowCurrentTargetInfoHeader", "現在のターゲットを表示する");
            Dictionary.Add("Translator_TranslatorettingsTabHeader", "ウィジェット設定");
            Dictionary.Add("Translator_AboutColorsParsingLabel", "* Colors are used as either ARGB (Alpha, Red, Green, Blue) or a named color (SkyBlue)");
            Dictionary.Add("Translator_ColorsJobsLabel", "COLORS:JOBS");
            Dictionary.Add("Translator_EnmityTranslatorettingsTabLabel", "SETTINGS:ENMITY");
            Dictionary.Add("Translator_FocusTargetTranslatorettingsTabLabel", "SETTINGS:FOCUS TARGET");
            Dictionary.Add("Translator_CurrentTargetTranslatorettingsTabLabel", "SETTINGS:CURRENT TARGET");
            return Dictionary;
        }
    }
}
