// FFXIVAPP.Plugin.Translator
// Russian.cs
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
    public abstract class Russian
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("Translator_", "*PH*");
            Dictionary.Add("Translator_OpenNowButtonText", "Открыть Сейчас");
            Dictionary.Add("Translator_ResetPositionButtonText", "Сбросить Настройки");
            Dictionary.Add("Translator_DPSTitleBar", "[УВС]");
            Dictionary.Add("Translator_HPSTitleBar", "[ЛВС]");
            Dictionary.Add("Translator_DTPSTitleBar", "[УВСД]");
            Dictionary.Add("Translator_EnmityTitleBar", "[АГРЕССИЯ]");
            Dictionary.Add("Translator_FocusTitleBar", "[ЦЕЛЬ в ФОКУСЕ]");
            Dictionary.Add("Translator_CurrentTitleBar", "[ВЫБРАННАЯ ЦЕЛЬ]");
            Dictionary.Add("Translator_DPSWidgetHeader", "ВИДЖЕТ УВС");
            Dictionary.Add("Translator_HPSWidgetHeader", "ВИДЖЕТ ЛВС");
            Dictionary.Add("Translator_DTPSWidgetHeader", "ВИДЖЕТ УВСД");
            Dictionary.Add("Translator_EnmityWidgetHeader", "ВИДЖЕТ АГРЕССИИ");
            Dictionary.Add("Translator_FocusWidgetHeader", "ВИДЖЕТ ЦЕЛЬ в ФОКУСЕ");
            Dictionary.Add("Translator_CurrentWidgetHeader", "ВИДЖЕТ ВЫБРАННАЯ ЦЕЛЬ");
            Dictionary.Add("Translator_EnableClickThroughHeader", "Забокировать Перетаскивание Мышью");
            Dictionary.Add("Translator_WidgetOpacityHeader", "Прозрачность Виджета");
            Dictionary.Add("Translator_GitHubButtonText", "Страница Проекта (GitHub)");
            Dictionary.Add("Translator_ShowTitlesOnTranslatorHeader", "Показать Заголовки на Виджетах");
            Dictionary.Add("Translator_ColorsTabHeader", "Цвета");
            Dictionary.Add("Translator_DefaultProgressBarForegroundHeader", "Стандартный передний план Полоски Прогресса");
            Dictionary.Add("Translator_UIScaleHeader", "Размер Интерфейса");
            Dictionary.Add("Translator_SortDirectionHeader", "Отсортировать по Расположению");
            Dictionary.Add("Translator_SortPropertyHeader", "Сортировать по Свойствам");
            Dictionary.Add("Translator_DisplayPropertyHeader", "Отобразить Свойства");
            Dictionary.Add("Translator_PlayerVisibilityThresholdHeader", "Порого Видимости Игроком");
            Dictionary.Add("Translator_EnmityShowCurrentTargetInfoHeader", "Показать Выбранную Цель");
            Dictionary.Add("Translator_TranslatorettingsTabHeader", "Настройки Виджета");
            Dictionary.Add("Translator_AboutColorsParsingLabel", "* Цвета используют кодировку ARGB (Alpha, Red, Green, Blue) или именные цвета (SkyBlue)");
            Dictionary.Add("Translator_ColorsJobsLabel", "ЦВЕТА:JOBS");
            Dictionary.Add("Translator_EnmityTranslatorettingsTabLabel", "НАСТРОЙКИ ВИДЖЕТА:АГРЕССИЯ");
            Dictionary.Add("Translator_FocusTargetTranslatorettingsTabLabel", "НАСТРОЙКИ ВИДЖЕТА:ЦЕЛЬ В ФОКУСЕ");
            Dictionary.Add("Translator_CurrentTargetTranslatorettingsTabLabel", "НАСТРОЙКИ ВИДЖЕТА:ВЫБРАННАЯ ЦЕЛЬ");
            return Dictionary;
        }
    }
}
